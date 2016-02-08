using DomainLogicLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLogicLayer.Controllers
{
    public class FlatFileController : DefaultController, IController
    {
        Models.FileCommunicatorVM comm = new FileCommunicatorVM();

        public FlatFileController(string deviceName)
        {
            //if device name is known, get the ID and store locally
        }

        public FlatFileController(int deviceId)
        {
            //if the device id is known, download the object and store locally
        }

        public List<object> DownloadAll()
        {
            throw new NotImplementedException();
        }

        public object DownloadById(int id, int counter = 0)
        {
            throw new NotImplementedException();
        }

        public FileCommunicatorVM Communicator()
        {
            return comm;
        }

        public List<object> GetModels(int count = int.MinValue)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Saves the 'comm' object (FileCommunicatorVM) to the RDBMS.
        /// </summary>
        public void SaveNewDevice()
        {

        }



        /// <summary>
        /// Returns an object array of all available value types as defined within the DAL.
        /// </summary>
        /// <returns></returns>
        public object[] GetValueTypes()
        {
            var values = Enum.GetValues(typeof(DataAccessLayer.FlatFileHandler.ValueType));
            object[] tempList = new object[values.Length];

            int x = 0;
            foreach (var val in values)
            {
                if (val != null)
                {
                    tempList[x++] = val;
                }
            }


            return tempList;
        }
    }
}
