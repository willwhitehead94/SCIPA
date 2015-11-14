using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace DataAccessLayer.Controllers
{
    static class Devices
    {
    #region Static Variables

        private static List<Device> allDevices = null; 

    #endregion Static Variables


    #region Public Methods
        public static List<Device> GetAllDevices()
        {
            if (allDevices == null)
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
            DatabaseHandler dbHandlerOld = new DatabaseHandler();

            //Download devices
            List<Device> tempDeviceList = new List<Device>();

            return false;
            //Save to allDevices variable
        }
    #endregion Private Methods
    }
}
