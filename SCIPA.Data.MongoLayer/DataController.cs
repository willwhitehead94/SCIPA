using System;
using System.Collections;
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
        private static string ConnectionString = "mongodb://localhost:27017";

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
            if (_client == null) _client =new MongoClient(ConnectionString);

            //Access the SCIPA database on the server.
            if (_db == null) _db = _client.GetDatabase("SCIPA");
        }

        /// <summary>
        /// Posts the parametised Value object directly into the database.
        /// </summary>
        /// <param name="value"></param>
        public void AddNewValue(Value value)
        {
            List<Value> vals = new List<Value>();
            value.ObjectId = ObjectId.GenerateNewId();
            vals.Add(value);
            value.ValueId++;
            value.ObjectId = ObjectId.GenerateNewId();
            vals.Add(value);
            value.ValueId++;
            value.ObjectId = ObjectId.GenerateNewId();
            vals.Add(value);
            IEnumerable<Value> allValues = vals;

            var processData = new Process()
            {
                DeviceId = value.DeviceId,
                Custodian = "Whitehead",
                Enabled = true,
                Location = "Home",
                Name = "Boiler",
                ObjectId = ObjectId.GenerateNewId(),
                Values = vals
            };
            PushProcessData(processData);

            try
            {
                _db.GetCollection<Value>("Values").InsertOne(value);
            }
            catch (Exception e)
            {
                DebugOutput.Print($"Could not store Value {value.ValueId}'s value ({value.StringValue}) in MongoDb. ",e.Message);
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

        public void PushProcessData(Process data)
        {
            ////Replaces the entire Device document
            //var collection = _db.GetCollection<Process>("ProcessData");
            //var filter = Builders<Process>.Filter.Eq("DeviceId", data.DeviceId);
            //var result = collection.Find(filter).ToList();

            //if (result.Count > 0)
            //{
            //    var entity = result[0];
            //    data.ObjectId = entity.ObjectId;
            //}

            //var update = collection.ReplaceOne
            //        (
            //            item => item.DeviceId == data.DeviceId,
            //            data,
            //            new UpdateOptions { IsUpsert = true }
            //        );
            //// END OF DOCUMENT REPLACEMENT


            //Merges all values then replaces the entire document.
            var collection = _db.GetCollection<Process>("ProcessData");
            var filter = Builders<Process>.Filter.Eq("DeviceId", data.DeviceId);
            var result = collection.Find(filter).ToList();

            if (result.Count > 0)
            {
                var entity = result[0];
                data.ObjectId = entity.ObjectId;
                var currentVals = result[0].Values;
                List<Value> allValues = new List<Value>();
                allValues.AddRange(currentVals);
                allValues.AddRange(data.Values);
                data.Values = allValues;
            }

            var update = collection.ReplaceOne
                    (
                        item => item.DeviceId == data.DeviceId,
                        data,
                        new UpdateOptions { IsUpsert = true }
                    );
            // END OF DOCUMENT REPLACEMENT


            //Merges all values then replaces the entire document.
            //var collection = _db.GetCollection<Process>("ProcessData");
            //var filter = Builders<Process>.Filter.Eq("DeviceId", data.DeviceId);
            //var result = collection.Find(filter).ToList();


            //var valueCollection = _db.GetCollection<Value>("ProcessData.Values");
            //var valueFilter = Builders<Value>.Filter.Eq("DeviceId", data.DeviceId);
            //var valueResult = valueCollection.Find(valueFilter).ToList();
            //foreach (Value val in data.Values)
            //{
            //    var valueUpdate = valueCollection.ReplaceOne
            //        (
            //            item => item.ValueId == val.ValueId,
            //            val,
            //            new UpdateOptions { IsUpsert = true }
            //        );
            //}


            // END OF DOCUMENT REPLACEMENT
        }
    }
}
