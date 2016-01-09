using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;
using System.Data;

namespace DataAccessLayer.Controllers
{
    public class DeviceController : Controller
    {
    #region Static Variables

        /// <summary>
        /// Static variable to hold all the current Device objects internally to the application.
        /// </summary>
        private static List<Device> _allDevices = null;

    #endregion Static Variables


    #region Public Methods

        /// <summary>
        /// Public method to return a list of Devices as per the configuration in the database.
        /// </summary>
        /// <param name="enabledOnly">If true, only devices currently registered as active/enabled will be returned.</param>
        /// <returns>List of Device objects.</returns>
        public static List<Device> GetAllDevices(bool enabledOnly = false)
        {
            if (_allDevices == null)
            {
                DownloadAllDevices(enabledOnly);
            }
            else if (_allDevices.Count<1)
            {
                DownloadAllDevices(enabledOnly);
            }

            if (_allDevices != null || _allDevices.Count>0)
            { 
                return _allDevices;
            }
            else
            {
                Service.DebugPrint("There was an issue returning all the Devices from the Device Controller.", "It appears that the downloading of device data from the database failed.");
                return null;
            }
        }

        /// <summary>
        /// Public method to retrieve a single and specific Device. Returns a Device object either from memory, or downloads from database if unavailable.
        /// </summary>
        /// <param name="idNumber">The identification number of the required Device.</param>
        /// <returns>Device object from memory or RDB.</returns>
        public static Device GetDeviceById(int idNumber)
        {
            Device toReturn = null;

            if (_allDevices != null && _allDevices.Count>0)
            {
                toReturn = _allDevices.Find(d => d.Id.Equals(idNumber));
            }

            if (toReturn != null && toReturn.Id==idNumber)
            {
                return toReturn;
            }
            else
            {
                DownloadDevice(idNumber);
                return GetDeviceById(idNumber);
            }
        }

        /// <summary>
        /// Calls the private method used to update data on the database with the modified local Device object.
        /// </summary>
        /// <param name="device"></param>
        /// <returns></returns>
        public static bool UpdateDevice(Device device)
        {
            return UpdateDeviceOnDatabase(device);
        }

    #endregion Public Methods


    #region Private Methods

        /// <summary>
        /// Downloads all devices from the database and stores the data as a list of 
        /// Device objects in the private static variable '_allDevices'.
        /// </summary>
        /// <param name="enabledOnly">Whether to also download devices not currently enabled.</param>
        /// <returns>True/False to suggest whether or not the download process was successful.</returns>
        private static bool DownloadAllDevices(bool enabledOnly = false)
        {
            //Connect to database using default connection
            DatabaseHandler dbHandler = new DatabaseHandler();

            //Download devices
            List<Device> tempDeviceList = new List<Device>();

            //Get the select statement
            string query = SelectStatement();

            //If only downloading devices that are listed as 'enabled', append this string to the query.
            if (enabledOnly)
            {
                query += " WHERE [enabled] = 1";
            }

            //Use the handler to execute the query.
            if (dbHandler.Execute(query))
            {
                //For each record returned, copy the data into a list of Device objects.
                foreach (DataRow row in dbHandler.GetDataTableFromDataSet(0).Rows)
                {
                    Service.DebugPrint(string.Format("Now reading Device {0} of {1} from the database...", tempDeviceList.Count + 1, dbHandler.GetDataTableFromDataSet(0).Rows.Count));

                    //Create new Device object.
                    tempDeviceList.Add(DataRowToDevice(row));
                }
            }

            Service.DebugPrint(string.Format("There were {0} Devices read from the database.",tempDeviceList.Count));

            //If at least one device is returned, store the device(s) and return true.
            if (tempDeviceList.Count>0)
            {
                _allDevices = tempDeviceList;
                return true;
            }
            else
            {
                //Indicates that no devices have been downloaded.
                return false;
            }
        }

        /// <summary>
        /// Downloads a single device from the database  based upon it's identification number. Downloaded devices added the the static, public variable.
        /// </summary>
        /// <param name="idNumber">The ID of the required device.</param>
        /// <returns>A success or fail boolean.</returns>
        private static bool DownloadDevice(int idNumber)
        {
            //Connect to database using default connection
            DatabaseHandler dbHandler = new DatabaseHandler();

            //Get the select statement and add the WHERE clause
            string query = SelectStatement();
            query += "WHERE id=" + idNumber;

            Device downloadedDevice = null;

            //Use the handler to execute the query.
            if (dbHandler.Execute(query))
            {
                //For each record returned, copy the data into a list of Device objects.
                foreach (DataRow row in dbHandler.GetDataTableFromDataSet(0).Rows)
                {
                    Service.DebugPrint(string.Format("Now reading Device {0} of {1} from the database...", dbHandler.GetDataTableFromDataSet(0).Rows.Count, dbHandler.GetDataTableFromDataSet(0).Rows.Count));

                    //Create new Device object.
                    downloadedDevice = DataRowToDevice(row);
                }
            }

            Service.DebugPrint(string.Format("There were {0} Devices read from the database.", dbHandler.GetDataTableFromDataSet(0).Rows.Count));

            //If the devise created is not null, assume success
            if (downloadedDevice != null)
            {
                var temp = new Device();

                if (_allDevices != null)
                {
                    try
                    {
                        int indexOfDevice = _allDevices.FindIndex(d => d.Id.Equals(idNumber));
                        _allDevices[indexOfDevice] = downloadedDevice;
                    }
                    catch
                    {
                        Service.DebugPrint("There was an issue finding the required object inside the _allDevices list.");
                        return false;
                    }
                }
                else
                {
                    _allDevices = new List<Device>();
                    _allDevices.Add(downloadedDevice);
                }


                return true;
            }
            else
            {
                //Indicates that no devices have been downloaded.
                return false;
            }
        }

        /// <summary>
        /// Converts a single data row to a Device object.
        /// </summary>
        /// <param name="record">Single data row instance.</param>
        /// <returns>New Device object.</returns>
        private static Device DataRowToDevice(DataRow record)
        {
             Device _temp = new Device
                (
                    record[0].ToString(), record[1].ToString(), record[2].ToString(),
                    record[3].ToString(), record[4].ToString(), record[5].ToString(),
                    record[6].ToString(), record[7].ToString(), record[8].ToString()
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
            string query = "SELECT [id] ,[name] ,[readOnly] ,[locationId] ,[faultTolerance] ,[valueTypeId] ,[lowestValue] ,[highestValue],[enabled] FROM [SCIPA].[dbo].[Device]";

            return query;
        }

        /// <summary>
        /// Method to update the RDB with locally changed information on the device.
        /// </summary>
        /// <param name="device">The Device object to upload to the database.</param>
        /// <param name="forceUpdate">Ignore whether or not the information in the device has changed and upload everything.</param>
        /// <returns>A success boolean.</returns>
        private static bool UpdateDeviceOnDatabase(Device device, bool forceUpdate = false)
        {
            Service.DebugPrint(string.Format("Commiting the local change on device {0} to the database.", device.Id));

            //Connect to database using default connection
            DatabaseHandler dbHandler = new DatabaseHandler();

            bool databaseReadOnly = false;
            string query = string.Format("SELECT readOnly FROM Device WHERE id = {0}",device.Id);
            dbHandler.Execute(query);
            if (bool.TryParse(dbHandler.GetSingleValueFromFirstTableInSet(),out databaseReadOnly))
            {
                //Arrive here when the reading of a boolean is successful.

                //Check if device is read only
                if (databaseReadOnly)
                {
                    Service.DebugPrint("Modification of this device is not allowed. It is registered as read only!");
                    return false;
                }
            }

            //Unless the force update param has been passed, don't update a device that hasn't changed.
            if (!device.changesMade && !forceUpdate)
            {
                Service.DebugPrint("Update was cancelled as it appears that the local object has not changed.");
                return false;
            }


            //Set the query
            query = "UPDATE Device SET " +
                "name='{0}', " +
                "readOnly='{1}', " +
                "locationId='{2}', " +
                "faultTolerance='{3}', " +
                "valueTypeId='{4}', " +
                "lowestValue='{5}', " +
                "highestValue='{6}', " +
                "enabled='{7}' " +
                "WHERE id={8}";

            query = string.Format(query, device.Name, device.IsReadOnly, device.LocationId, device.FaultTolerance, device.ValueTypeId, device.LowestValue, device.HighestValue, device.IsEnabled, device.Id);

            bool executionSuccess = dbHandler.Execute(query);

            if (executionSuccess)
            {
                device.changesMade = false;
            }

            return executionSuccess;
        }

    #endregion Private Methods
    }
}
