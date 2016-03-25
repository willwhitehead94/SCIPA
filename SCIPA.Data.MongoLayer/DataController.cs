using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace SCIPA.Data.MongoLayer
{
    class DataController
    {
        private MongoClient _client = null;

        public DataController()
        {
            //Connect to the local MongoDB instance.
            _client=new MongoClient("127.0.0.1");
        }

        public void AddNewValue(Value value)
        {

        }

        public void SaveNewDevice(Device device)
        {
            throw new NotImplementedException();
        }

        public void UpdateDevice(Device device)
        {
            throw new NotImplementedException();
        }
    }
}
