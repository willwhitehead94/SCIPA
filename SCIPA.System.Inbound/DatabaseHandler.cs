using System;
using System.Threading;
using SCIPA.Models;
using SCIPA.Domain.Logic;
using ValueType = SCIPA.Models.ValueType;

namespace SCIPA.Domain.Inbound
{
    public class DatabaseHandler:DataHandler
    {
        /// <summary>
        /// Database Communicator Model object used to store the connection settings.
        /// </summary>
        public Models.DatabaseCommunicator Communicator = null;

        /// <summary>
        /// The DCM is used to connect to, execute queries against, and retrieve data from
        /// the required databases.
        /// </summary>
        private DatabaseConnectionManager dcm = null;

        /// <summary>
        /// Boolean value to indicate whether the system is already attempting to connect to the database.
        /// </summary>
        private bool _currentlyAttemptingConnection = false;

        private bool _keepingChecking = true;

        /// <summary>
        /// Constructor takes a database communicator object. If the file in question is already
        /// being watched, this is ignored. Otherwise, the file is watched by a system file watcher
        /// object.
        /// </summary>
        /// <param name="comms">Database Communicator Model</param>
        public DatabaseHandler(DatabaseCommunicator comms)
        {
            Communicator = comms;
            dcm = new DatabaseConnectionManager(comms.DbType, comms.ConnectionString, comms.Query, true);

            StartWatchingDatabase();
        }

        private void StartWatchingDatabase()
        {
            ThreadPool.QueueUserWorkItem(ConnectAndCollect);
        }

        /// <summary>
        /// Connects to the already set DCM object, executes the query
        /// and enqueues the first returned value.
        /// The DateTime of the new Value is the collection time.
        /// </summary>
        /// <param name="obj">System threading object.</param>
        private void ConnectAndCollect(object obj)
        {
            while (_keepingChecking)
            {
                double ms = 60000 / MaximumReadsPerMinute;
                

                //Never attempt concurrent access
                if (!_currentlyAttemptingConnection)
                {
                    _currentlyAttemptingConnection = true;

                    //Execute the query.
                    dcm.Execute();

                    //If the query returns at least one row
                    if (dcm.GetAffectedRows() > 0)
                    {
                        //Create a new Value object for the queue.
                        var result = new Value()
                        {
                            EventTime = DateTime.Now,
                            Inbound = true,
                            StringValue = dcm.GetResultLists()[0][0],
                            Type = ValueType.String
                        };

                        if (result.StringValue != "")
                        {
                            //Enqueue the new Value.
                            EnqueueData(result);
                        }

                        _currentlyAttemptingConnection = false;
                    }
                }
                Thread.Sleep((int)ms);
            }
        }

        public override Communicator GetCommunicator()
        {
            return Communicator;
        }
    }
}