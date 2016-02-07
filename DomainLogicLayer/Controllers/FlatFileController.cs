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

        public FileCommunicatorVM GetCommunicator()
        {
            return comm;
        }

        public List<object> GetModels(int count = int.MinValue)
        {
            throw new NotImplementedException();
        }






        public object[] GetValueTypes()
        {
            object[] tempList = new object[4];

            tempList[0] = "String";
            tempList[1] = "Integer";
            tempList[2] = "Double";
            tempList[3] = "Boolean";


            return tempList;
        }

        
    }
}
