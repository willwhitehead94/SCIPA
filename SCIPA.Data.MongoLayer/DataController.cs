using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using SCIPA.Domain.Generic;

namespace SCIPA.Data.MongoLayer
{
    public class DataController
    {
        /// <summary>
        /// Local instantiation of the MongoDB client.
        /// </summary>
        private static MongoClient _client = null;

        /// <summary>
        /// Local representation of the desired database to use
        /// within MongoDB.
        /// </summary>
        private static IMongoDatabase _db = null;

        /// <summary>
        /// Constructor automatically attempts to connect to the local
        /// MongoDb instance and sets the local variables to that effect.
        /// </summary>
        public DataController()
        {
            //Connect to the local MongoDB instance.
            if (_client == null) _client =new MongoClient();

            //Access the SCIPA database on the server.
            if (_db == null) _db = _client.GetDatabase("SCIPA");
        }

        /// <summary>
        /// Posts the parametised Value object directly into the database.
        /// </summary>
        /// <param name="value"></param>
        public void AddNewValue(Value value)
        {
            try
            {
                _db.GetCollection<Value>("Values").InsertOne(value);
            }
            catch (Exception e)
            {
                DebugOutput.Print($"Could not store Value {value.Id}'s value ({value.StringValue}) in MongoDb. ",e.Message);
            }
        }

        /// <summary>
        /// Posts the parametised Device object directly into the database.
        /// </summary>
        /// <param name="device"></param>
        public void AddNewDevice(Device device)
        {
            _db.GetCollection<Device>("Devices").InsertOne(device);
        }

        /// <summary>
        /// Repalces the current Device in the database with the parametised Device's ID
        /// with the parametised Device.
        /// </summary>
        /// <param name="device"></param>
        public void UpdateDevice(Device device)
        {
            _db.GetCollection<Device>("Devices").FindOneAndReplace(dev => dev.Id == device.Id, device);
        }
    }
}
