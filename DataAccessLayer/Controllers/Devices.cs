using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;
using System.Data;

namespace DataAccessLayer.Controllers
{
    public static class Devices
    {
    #region Static Variables

        private static List<Device> _allDevices = null; 

    #endregion Static Variables


    #region Public Methods
        public static List<Device> GetAllDevices()
        {
            if (_allDevices == null)
            {
                DownloadAllDevices();
            }
            else
            {
                
            }

            return new List<Device>();
        }
    #endregion Public Methods


    #region Private Methods

        private static bool DownloadAllDevices()
        {
            //Connect to database using default connection
            DatabaseHandler dbHandler = new DatabaseHandler();

            //Download devices
            List<Device> tempDeviceList = new List<Device>();

            string query = "SELECT [id] ,[name] ,[readOnly] ,[locationId] ,[faultTolerance] ,[valueTypeId] ,[lowestValue] ,[highestValue] FROM[SCIPA].[dbo].[Device]";

            if (dbHandler.Execute(query))
            {
                foreach (DataRow row in dbHandler.GetDataTableFromDataSet(0).Rows)
                {
                    Device _temp = new Device
                        (
                            row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString()
                        );

                    tempDeviceList.Add(_temp);
                }
            }

            return false;
            //Save to allDevices variable
        }
    #endregion Private Methods
    }
}
