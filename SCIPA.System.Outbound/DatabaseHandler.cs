﻿using System;
using System.Text;
using SCIPA.Domain.Generic;
using SCIPA.Models;

namespace SCIPA.Domain.Outbound
{
    /// <summary>
    /// Database variant of the Handler class for outbound data.
    /// </summary>
    public class DatabaseHandler:DataHandler
    {
        /// <summary>
        /// The DCM is used to connect to, execute queries against, and retrieve data from
        /// the required databases.
        /// </summary>
        private DatabaseConnectionManager dcm = null;

        /// <summary>
        /// The value that caused the required write.
        /// </summary>
        private Value _value = null;

        /// <summary>
        /// Constructor takes a database communicator object. 
        /// </summary>
        /// <param name="comms">Database Communicator Model</param>
        public DatabaseHandler(DatabaseCommunicator comms, Rule rule, Value value)
        {
            _communicator = comms;
            dcm = new DatabaseConnectionManager(comms.DbType, comms.ConnectionString, comms.Query, true);

            //Make the Value available.
            _value = value;

            //Output the data required - any instance of [val] is replaced with the actual value
            StringBuilder builder = new StringBuilder(rule.Action.OutputValue);
            builder.Replace("[val]", _value.StringValue);

            //Output the string
            OutputValue(builder.ToString());
        }

        /// <summary>
        /// The DCM does not allow checking of connection states, as such, this check will always return
        /// true.
        /// </summary>
        public bool CheckConnection
        {
            get
            {
                //Unable to test the connection to the database. Always returns true!
                return true;
            }
        }

        /// <summary>
        /// Print the passed Value parameter to the Communicator's file path.
        /// </summary>
        /// <param name="value">Message to print to file.</param>
        /// <returns>Successful/Fail boolean.</returns>
        public bool OutputValue(string value)
        {
            DebugOutput.Print($"Attempting to write '{value}' to database.");

            try
            {
                //Ensure appropriate access to the file can be obtained.
                if (CheckConnection)
                {
                    dcm.Execute(value);
                    DebugOutput.Print($"Successful execution of '{value}'.");
                    return true;
                }
                DebugOutput.Print($"Did not execute '{value}' because of CheckConnection fail.");
            }
            catch (Exception e)
            {
                DebugOutput.Print($"Did not execute '{value}' because of ", e.Message);
            }

            return false;
        }
    }
}