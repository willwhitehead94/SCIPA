using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;
using System.Data;

namespace DataAccessLayer.Controllers
{
    public class CommandController : Controller
    {
        #region Static Variables
        /// <summary>
        /// List of Command objects as downloaded from the RDB.
        /// </summary>
        private static List<Command> _allCommands = null;

        /// <summary>
        /// Dictionary object to state a list of Commands associated with each device, with the Device ID as the key to the Dictionary.
        /// </summary>
        private static Dictionary<int, List<Command>> _deviceDictionary = null;

        #endregion Static Variables



        #region Public Methods

        /// <summary>
        /// Retrieves a list of all commands for all devices as stored on the RDB.
        /// </summary>
        /// <returns>List of Command objects.</returns>
        public static List<Command> GetAllCommands()
        {
            try
            {
                return AllCommands();
            }
            catch (NullReferenceException nulled)
            {
                Service.DebugPrint("The list of Command objects being used/called is null...");
                return null;
            }
            catch (Exception e)
            {
                Service.DebugPrint("The list of Command objects being used/called wasn't null, but posed a further exception... Failed!");
                return null;
            }
        }

        /// <summary>
        /// Retrieves a list of all commands for a given device via the device's ID.
        /// </summary>
        /// <param name="deviceId">The ID of the Device to search for commands.</param>
        /// <param name="attemptNumber">Internal param only. Used when the method becomes recursive.</param>
        /// <returns>List of Command objects or NULL depending on what is most appropriate.</returns>
        public static List<Command> GetCommandsForDevice(int deviceId, int attemptNumber = 0)
        {
            if (_deviceDictionary == null)
            {
                UpdateLocalDictionary();
            }

            if (_deviceDictionary[deviceId].Count > 0)
            {
                return _deviceDictionary[deviceId];
            }

            DownloadCommandsForDevice(deviceId);

            attemptNumber++;
            List<Command> tempList = GetCommandsForDevice(deviceId, attemptNumber);

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
        /// Generic Accessor for the _allCommands Command object List to reduce the 'if null' code.
        /// </summary>
        /// <returns>A list of Command objects.</returns>
        private static List<Command> AllCommands()
        {
            bool nulled = (_allCommands == null ? true : false);
            bool empty = (!nulled && (_allCommands.Count < 1) ? true : false);

            if (nulled || empty)
            {
                DownloadAllCommands();
            }

            return _allCommands;
        }

        /// <summary>
        /// Connects to the RDB and downloads all of the relevant data as per the controllers requirements.
        /// </summary>
        /// <param name="enabledOnly">Optional boolean to determine whether or not to ignore the disabled objects.</param>
        /// <returns>Success/Fail boolean.</returns>
        private static bool DownloadAllCommands(bool enabledOnly = false)
        {
            //Connect to database using default connection
            DatabaseHandler dbHandler = new DatabaseHandler();

            //Command list
            List<Command> tempCommandList = new List<Command>();

            //Get the select statement
            string query = SelectStatement();

            //If only downloading alarms that are listed as 'enabled', append this string to the query.
            if (enabledOnly)
            {
                query += " WHERE [enabled] = 1";
            }

            //Use the handler to execute the query.
            if (dbHandler.Execute(query))
            {
                //For each record returned, copy the data into a list of Command objects.
                foreach (DataRow row in dbHandler.GetDataTableFromDataSet(0).Rows)
                {
                    Service.DebugPrint(string.Format("Now reading Commands {0} of {1} from the database for device {2}...", tempCommandList.Count + 1, dbHandler.GetDataTableFromDataSet(0).Rows.Count, row[0].ToString()));

                    //Create new Alarm object.
                    tempCommandList.Add(DataRowToDevice(row));
                }
            }

            Service.DebugPrint(string.Format("There were {0} Commands read from the database.", tempCommandList.Count));

            //If at least one command is returned, store the command(s) and return true.
            if (tempCommandList.Count > 0)
            {
                _allCommands = tempCommandList;
                return true;
            }
            else
            {
                //Indicates that no commands have been downloaded.
                return false;
            }
        }

        /// <summary>
        /// Connect to the RDB and download all commands for a given device, including disabled commands.
        /// </summary>
        /// <param name="deviceId">The ID of the device to search for commands for.</param>
        /// <returns>A success/fail boolean.</returns>
        private static bool DownloadCommandsForDevice(int deviceId)
        {
            //Connect to database using default connection
            DatabaseHandler dbHandler = new DatabaseHandler();

            //Command list
            List<Command> tempList = new List<Command>();

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
                    Service.DebugPrint(string.Format("Now reading Alarm {0} of {1} from the database for device {2}...", tempList.Count + 1, dbHandler.GetDataTableFromDataSet(0).Rows.Count, row[0].ToString()));

                    //Create new object.
                    tempList.Add(DataRowToDevice(row));
                }
            }

            Service.DebugPrint(string.Format("There were {0} {1} read from the database.", tempList.Count, tempList.GetType().ToString()));

            //If at least one alarm is returned, store the objects and return true by deleting all known objects for device and re-adding.
            if (tempList.Count > 0)
            {
                _allCommands.RemoveAll(d => d.DeviceId.Equals(deviceId));
                _allCommands.AddRange(tempList);

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
        /// Converts a single data row to a Command object.
        /// </summary>
        /// <param name="record">Single data row instance.</param>
        /// <returns>New Command object.</returns>
        private static Command DataRowToDevice(DataRow record)
        {
            Command _temp = new Command
               (
                   record[0].ToString(), record[1].ToString(), record[2].ToString(),
                   record[3].ToString(), record[4].ToString(),record[5].ToString(),record[6].ToString()
               );

            return _temp;
        }

        /// <summary>
        /// Updates the local dictionary to store a Device's ID and all associated commands.
        /// </summary>
        private static void UpdateLocalDictionary()
        {
            if (AllCommands() != null)
            {
                foreach (Command obj in AllCommands())
                {
                    if (_deviceDictionary.ContainsKey(obj.DeviceId))
                    {
                        _deviceDictionary[obj.DeviceId].Add(obj);
                    }
                    else
                    {
                        _deviceDictionary.Add(obj.DeviceId, new List<Command>());
                        _deviceDictionary[obj.DeviceId].Add(obj);
                    }
                }
            }
        }

        #endregion Private Methods
    }
}
