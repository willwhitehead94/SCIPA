using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Controllers
{
    public class CommunicatorController : Controller
    {
        #region Static Variables
        /// <summary>
        /// List of objects as downloaded from the RDB.
        /// </summary>
        private static List<Communicator> _allCommunicators = null;

        /// <summary>
        /// Dictionary object to state a list of objects associated with each device, with the Device ID as the key to the Dictionary.
        /// </summary>
        private static Dictionary<int, List<Communicator>> _deviceDictionary = null;

        #endregion Static Variables



        #region Public Methods

        /// <summary>
        /// Retrieves a list of all communicators for all devices as stored on the RDB.
        /// </summary>
        /// <returns>List of Communicator objects.</returns>
        public static List<Communicator> GetAll()
        {
            try
            {
                return AllCommunicators();
            }
            catch (NullReferenceException nulled)
            {
                Service.DebugPrint("The list of Communicator objects being used/called is null...");
                return null;
            }
            catch (Exception e)
            {
                Service.DebugPrint("The list of Communicator objects being used/called wasn't null, but posed a further exception... Failed!");
                return null;
            }
        }

        /// <summary>
        /// Retrieves a list of all communicators for a given device via the device's ID.
        /// </summary>
        /// <param name="deviceId">The ID of the Device to search for communicators.</param>
        /// <param name="attemptNumber">Internal param only. Used when the method becomes recursive.</param>
        /// <returns>List of Communicator objects or NULL depending on what is most appropriate.</returns>
        public static List<Communicator> GetAllForDevice(int deviceId, int attemptNumber = 0)
        {
            if (_deviceDictionary == null)
            {
                UpdateLocalDictionary();
            }

            if (_deviceDictionary[deviceId].Count > 0)
            {
                return _deviceDictionary[deviceId];
            }

            DownloadAllForDevice(deviceId);

            attemptNumber++;
            List<Communicator> tempList = GetAllForDevice(deviceId, attemptNumber);

            if (attemptNumber > 1 || tempList.Count == 0)
            {
                return null;
            }
            else
            {
                return tempList;
            }
        }

        #endregion Public Methods



        #region Private Methods

        /// <summary>
        /// Generic Accessor for the _all... Communicator object List to reduce the 'if null' code.
        /// </summary>
        /// <returns>A list of Communicator objects.</returns>
        private static List<Communicator> AllCommunicators()
        {
            bool nulled = (_allCommunicators == null ? true : false);
            bool empty = (!nulled && (_allCommunicators.Count < 1) ? true : false);

            if (nulled || empty)
            {
                DownloadAllCommunicators();
            }

            return _allCommunicators;
        }

        /// <summary>
        /// Connects to the RDB and downloads all of the relevant data as per the controllers requirements.
        /// </summary>
        /// <param name="enabledOnly">Optional boolean to determine whether or not to ignore the disabled objects.</param>
        /// <returns>Success/Fail boolean.</returns>
        private static bool DownloadAllCommunicators(bool enabledOnly = false)
        {
            //Connect to database using default connection
            DatabaseHandler dbHandler = new DatabaseHandler();

            //Temporary list
            List<Communicator> tempList = new List<Communicator>();

            //Get the select statement
            string query = SelectStatement();

            //If only downloading Communicators that are listed as 'enabled', append this string to the query.
            if (enabledOnly)
            {
                query += " WHERE [enabled] = 1";
            }

            //Use the handler to execute the query.
            if (dbHandler.Execute(query))
            {
                //For each record returned, copy the data into a list of objects.
                foreach (DataRow row in dbHandler.GetDataTableFromDataSet(0).Rows)
                {
                    Service.DebugPrint(string.Format("Now reading Communicators {0} of {1} from the database for device {2}...", tempList.Count + 1, dbHandler.GetDataTableFromDataSet(0).Rows.Count, row[0].ToString()));

                    //Create new Communicator object.
                    tempList.Add(DataRowToDevice(row));
                }
            }

            Service.DebugPrint(string.Format("There were {0} Communicators read from the database.", tempList.Count));

            //If at least one Communicator is returned, store the objects(s) and return true.
            if (tempList.Count > 0)
            {
                _allCommunicators = tempList;
                return true;
            }
            else
            {
                //Indicates that no objects have been downloaded.
                return false;
            }
        }

        /// <summary>
        /// Connect to the RDB and download all Communicators for a given device, including disabled Communicators.
        /// </summary>
        /// <param name="deviceId">The ID of the device to search for Communicators for.</param>
        /// <returns>A success/fail boolean.</returns>
        private static bool DownloadAllForDevice(int deviceId)
        {
            //Connect to database using default connection
            DatabaseHandler dbHandler = new DatabaseHandler();

            //Object list
            List<Communicator> tempList = new List<Communicator>();

            //Get the select statement
            string query = SelectStatement();

            //Append the where clause to select only the required device from the database.
            query += string.Format(" WHERE [deviceId] = {0}", deviceId);

            //Use the handler to execute the query.
            if (dbHandler.Execute(query))
            {
                //For each record returned, copy the data into a list of objects.
                foreach (DataRow row in dbHandler.GetDataTableFromDataSet(0).Rows)
                {
                    Service.DebugPrint(string.Format("Now reading {3} {0} of {1} from the database for device {2}...", tempList.Count + 1, dbHandler.GetDataTableFromDataSet(0).Rows.Count, row[0].ToString(), tempList.GetType().ToString()));

                    //Create new object.
                    tempList.Add(DataRowToDevice(row));
                }
            }

            Service.DebugPrint(string.Format("There were {0} {1} read from the database.", tempList.Count, tempList.GetType().ToString()));

            //If at least one object is returned, store the objects and return true by deleting all known objects for device and re-adding.
            if (tempList.Count > 0)
            {
                _allCommunicators.RemoveAll(d => d.DeviceId.Equals(deviceId));
                _allCommunicators.AddRange(tempList);

                return true;
            }
            else
            {
                //Indicates that no valid data has been downloaded.
                return false;
            }
        }

        /// <summary>
        /// Single point of select statement creation is done here. Means easier updating of required query should the DB change structure.
        /// </summary>
        /// <returns>SQL Select Statement from the Device table.</returns>
        private static string SelectStatement()
        {
            //Select all the required information
            string query = "SELECT [id] ,[deviceId] ,[commandTypeId] ,[communicatorId] ,[commandText], [returnValueTypeId], [enabled]  FROM [SCIPA].[dbo].[Command]";

            return query;
        }

        /// <summary>
        /// Converts a single data row to an object.
        /// </summary>
        /// <param name="record">Single data row instance.</param>
        /// <returns>New Communicator object.</returns>
        private static Communicator DataRowToDevice(DataRow record)
        {
            Communicator _temp = new Communicator
               (
                   record[0].ToString(), record[1].ToString(), record[2].ToString(),
                   record[3].ToString(), record[4].ToString()
               );

            return _temp;
        }

        /// <summary>
        /// Updates the local dictionary to store a Device's ID and all associated entities.
        /// </summary>
        private static void UpdateLocalDictionary()
        {
            if (AllCommunicators() != null)
            {
                foreach (Communicator obj in AllCommunicators())
                {
                    if (_deviceDictionary.ContainsKey(obj.DeviceId))
                    {
                        _deviceDictionary[obj.DeviceId].Add(obj);
                    }
                    else
                    {
                        _deviceDictionary.Add(obj.DeviceId, new List<Communicator>());
                        _deviceDictionary[obj.DeviceId].Add(obj);
                    }
                }
            }
        }

        #endregion Private Methods
    }
}
