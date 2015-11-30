using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;
using System.Data;

namespace DataAccessLayer.Controllers
{
    class AlarmController
    {
        #region Static Variables
        /// <summary>
        /// Static variable to hold all the current Alarm objects internally to the application.
        /// </summary>
        private static List<Alarm> _allAlarms = null;

        /// <summary>
        /// Static dictionary storing a list of Alarm objects for each device ID.
        /// </summary>
        private static Dictionary<int, List<Alarm)>> _deviceAlarmDictionary = null;

        #endregion Static Variables


        #region Public Methods

        public static List<Alarm> GetAllAlarms(bool enabledOnly)
        {
            if (_allAlarms == null)
            {
                DownloadAllAlarms(enabledOnly);
            }
            else if (_allAlarms.Count<1)
            {
                DownloadAllAlarms(enabledOnly);
            }

            if (_allAlarms != null && _allAlarms.Count>0)
            {
                return _allAlarms;
            }
            else
            {
                Service.DebugPrint("There was an issue returning all the Alarms from the Alarm Controller.", "It appears that the downloading of alarm data from the database failed.");
                return null;
            }
        }

        #endregion Public Methods


        #region Private Methods

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
                    Service.DebugPrint(string.Format("Now reading Alarm {0} of {1} from the database...", tempAlarmList.Count + 1, dbHandler.GetDataTableFromDataSet(0).Rows.Count));

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

        private static void UpdateLocalDictionary()
        {
            if (_allAlarms != null)
            {
                foreach (Alarm alarm in _allAlarms)
                {
                    if (_deviceAlarmDictionary.ContainsKey(alarm.GetDeviceId()))
                    {
                        //_deviceAlarmDictionary[alarm.GetDeviceId()].Add(alarm.GetId());
                        _deviceAlarmDictionary[alarm.GetDeviceId()].Add(alarm);
                    }
                    else
                    {
                        //_deviceAlarmDictionary.Add(alarm.GetDeviceId(), new List<int>());
                        _deviceAlarmDictionary.Add(alarm.GetDeviceId(), new List<Alarm>());
                        _deviceAlarmDictionary[alarm.GetDeviceId()].Add(alarm);
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
