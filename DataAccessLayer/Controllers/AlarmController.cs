using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;
using System.Data;

namespace DataAccessLayer.Controllers
{
    public class AlarmController : Controller
    {
        #region Static Variables
        /// <summary>
        /// Static variable to hold all the current Alarm objects internally to the application.
        /// </summary>
        private static List<Alarm> _allAlarms = null;

        /// <summary>
        /// Static dictionary storing a list of Alarm objects for each device ID.
        /// </summary>
        private static Dictionary<int, List<Alarm>> _deviceAlarmDictionary = null;

        #endregion Static Variables


        #region Public Methods

        /// <summary>
        /// Retrieves a list of all alarms for all devices as stored on the RDB.
        /// </summary>
        /// <returns>List of Alarm objects.</returns>
        public static List<Alarm> GetAllAlarms()
        {
            try
            {
                return AllAlarms();
            }
            catch (NullReferenceException nulled)
            {
                Service.DebugPrint("The list of Alarm objects being used/called is null...");
                return null;
            }
            catch(Exception e)
            {
                Service.DebugPrint("The list of Alarm objects being used/called wasn't null, but posed a further exception... Failed!");
                return null;
            }
        }

        /// <summary>
        /// Retrieves a list of all alarms for a given device via the device's ID.
        /// </summary>
        /// <param name="deviceId">The ID of the Device to search for alarms.</param>
        /// <param name="attemptNumber">Internal param only. Used when the method becomes recursive.</param>
        /// <returns>List of Alarm objects or NULL depending on what is most appropriate.</returns>
        public static List<Alarm> GetAlarmsForDevice(int deviceId, int attemptNumber =0)
        {
            if (_deviceAlarmDictionary == null)
            {
                UpdateLocalDictionary();
            }

            if (_deviceAlarmDictionary[deviceId].Count>0)
            {
                return _deviceAlarmDictionary[deviceId];
            }

            DownloadAlarmsForDevice(deviceId);

            attemptNumber++;
            List<Alarm> tempAlarmList = GetAlarmsForDevice(deviceId, attemptNumber);

            if (attemptNumber > 1 || tempAlarmList.Count == 0)
            {
                return null;
            }
            else
            {
                return tempAlarmList;
            }
        }

        /// <summary>
        /// Retrieves a list of all the alarms that are currently in a state of alarm (i.e. less than normal state).
        /// </summary>
        /// <returns>List of Alarm objects.</returns>
        public static List<Alarm> GetAllAlarming()
        {
            if (GetAllAlarms() != null)
            {
                return GetAllAlarms().Where(alarm => alarm.IsAlarming == true).ToList();
            }
            else
            {
                return null;
            }
        }

        #endregion Public Methods


        #region Private Methods

        /// <summary>
        /// Generic Accessor for the _allAlarms Alarm object List to reduce the 'if null' code.
        /// </summary>
        /// <returns>A list of Alarm objects.</returns>
        public static List<Alarm> AllAlarms()
        {
            bool nulled = (_allAlarms == null ? true : false);
            bool empty = (!nulled && (_allAlarms.Count < 1) ? true : false);

            if (nulled || empty)
            {
                DownloadAllAlarms(false);
            }

            return _allAlarms;
        }

        /// <summary>
        /// Connect to the RDB and download all alarms for all devices.
        /// </summary>
        /// <param name="enabledOnly">Only download the alarms where the 'enabled' property is true.</param>
        /// <returns>A success/fail boolean.</returns>
        private static bool DownloadAllAlarms(bool enabledOnly)
        {
            //Connect to database using default connection
            DatabaseHandler dbHandler = new DatabaseHandler();

            //Alarm list
            List<Alarm> tempAlarmList = new List<Alarm>();

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
                //For each record returned, copy the data into a list of Alarm objects.
                foreach (DataRow row in dbHandler.GetDataTableFromDataSet(0).Rows)
                {
                    Service.DebugPrint(string.Format("Now reading Alarm {0} of {1} from the database for device {2}...", tempAlarmList.Count + 1, dbHandler.GetDataTableFromDataSet(0).Rows.Count, row[0].ToString()));

                    //Create new Alarm object.
                    tempAlarmList.Add(DataRowToDevice(row));
                }
            }

            Service.DebugPrint(string.Format("There were {0} Alarms read from the database.", tempAlarmList.Count));

            //If at least one alarm is returned, store the alarm(s) and return true.
            if (tempAlarmList.Count > 0)
            {
                _allAlarms = tempAlarmList;
                return true;
            }
            else
            {
                //Indicates that no alarm have been downloaded.
                return false;
            }
        }

        /// <summary>
        /// Connect to the RDB and download all alarms for a given device, including disabled alarms.
        /// </summary>
        /// <param name="deviceId">The ID of the device to search for alarms for.</param>
        /// <returns>A success/fail boolean.</returns>
        private static bool DownloadAlarmsForDevice(int deviceId)
        {
            //Connect to database using default connection
            DatabaseHandler dbHandler = new DatabaseHandler();

            //Alarm list
            List<Alarm> tempAlarmList = new List<Alarm>();

            //Get the select statement
            string query = SelectStatement();

            //Append the where clause to select only the required device from the database.
            query += string.Format(" WHERE [deviceId] = {0}", deviceId);

            //Use the handler to execute the query.
            if (dbHandler.Execute(query))
            {
                //For each record returned, copy the data into a list of Alarm objects.
                foreach (DataRow row in dbHandler.GetDataTableFromDataSet(0).Rows)
                {
                    Service.DebugPrint(string.Format("Now reading Alarm {0} of {1} from the database for device {2}...", tempAlarmList.Count + 1, dbHandler.GetDataTableFromDataSet(0).Rows.Count,row[0].ToString()));

                    //Create new Alarm object.
                    tempAlarmList.Add(DataRowToDevice(row));
                }
            }

            Service.DebugPrint(string.Format("There were {0} Alarms read from the database.", tempAlarmList.Count));

            //If at least one alarm is returned, store the alarm(s) and return true by deleting all known alarms for device and re-adding.
            if (tempAlarmList.Count > 0)
            {
                _allAlarms.RemoveAll(d => d.Id.Equals(deviceId));
                _allAlarms.AddRange(tempAlarmList);

                return true;
            }
            else
            {
                //Indicates that no alarm have been downloaded.
                return false;
            }
        }

        /// <summary>
        /// Updates the local dictionary to store a Device's ID and all associated alarms.
        /// </summary>
        private static void UpdateLocalDictionary()
        {
            if (AllAlarms() != null)
            {
                foreach (Alarm alarm in AllAlarms())
                {
                    if (_deviceAlarmDictionary.ContainsKey(alarm.DeviceId))
                    {
                        _deviceAlarmDictionary[alarm.DeviceId].Add(alarm);
                    }
                    else
                    {
                        _deviceAlarmDictionary.Add(alarm.DeviceId, new List<Alarm>());
                        _deviceAlarmDictionary[alarm.DeviceId].Add(alarm);
                    }
                }
            }
        }

        /// <summary>
        /// Converts a single data row to a Alarm object.
        /// </summary>
        /// <param name="record">Single data row instance.</param>
        /// <returns>New Alarm object.</returns>
        private static Alarm DataRowToDevice(DataRow record)
        {
            Alarm _temp = new Alarm
               (
                   record[0].ToString(), record[1].ToString(), record[2].ToString(),
                   record[3].ToString(), record[4].ToString()
               );

            return _temp;
        }

        /// <summary>
        /// Single point of select statement creation is done here. Means easier updating of required query should the DB change structure.
        /// </summary>
        /// <returns>SQL Select Statement from the Device table.</returns>
        private static string SelectStatement()
        {
            //Select all the required information
            string query = "SELECT [id] ,[deviceId] ,[alarmTypeId] ,[value] ,[enabled]  FROM [SCIPA].[dbo].[Alarm]";

            return query;
        }


        #endregion Private Methods
    }
}
