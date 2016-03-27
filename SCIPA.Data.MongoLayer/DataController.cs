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
            try
            {
                _db.GetCollection<Value>("Values").InsertOne(value);

                PushProcessData(value);
            }
            catch (Exception e)
            {
                DebugOutput.Print($"Could not store Value {value.ValueId}'s value ({value.StringValue}) in MongoDb. ",e.Message);
            }
        }

        private Process ConvertDeviceToProcess(Device device)
        {
            var _id = device.ObjectId == null ?  ObjectId.GenerateNewId() :  device.ObjectId;

            return new Process()
            {
                ObjectId = _id,
                DeviceId = device.Id,
                Custodian = device.Custodian,
                Enabled = device.Enabled,
                Location = device.Location,
                Name = device.Name,
                Values = new List<Value>()
            };
        }


        /// <summary>
        /// Repalces the current Device in the database with the parametised Device's ID
        /// with the parametised Device.
        /// </summary>
        /// <param name="device"></param>
        public void UpdateDevice(Device device)
        {
            var collection = _db.GetCollection<Process>("ProcessData");
            var filter = Builders<Process>.Filter.Eq("DeviceId", device.Id);
            var result = collection.Find(filter).ToList();

            if (result.Count > 0)
            {
                var entity = result[0];
                device.ObjectId = entity.ObjectId;
            }

            var process = ConvertDeviceToProcess(device);

            var update = collection.ReplaceOne
                    (
                        item => item.DeviceId == device.Id,
                        process,
                        new UpdateOptions { IsUpsert = true }
                    );
        }

        /// <summary>
        /// Posts the parametised Device object directly into the database.
        /// </summary>
        /// <param name="device"></param>
        public void AddNewDevice(Device device)
        {
            var processObj = new Process()
            {
                ObjectId = ObjectId.GenerateNewId(),
                DeviceId = device.Id,
                Custodian = device.Custodian,
                Enabled = device.Enabled,
                Location = device.Location,
                Name = device.Name,
                Values = new List<Value>()
            };

            _db.GetCollection<Process>("ProcessData").InsertOne(processObj);
        }

        private void PushProcessData(Value data)
        {
            //Merges all values then replaces the entire document.
            var collection = _db.GetCollection<Process>("ProcessData");
            var filter = Builders<Process>.Filter.Eq("DeviceId", data.DeviceId);
            var result = collection.Find(filter).ToList();

            if (result.Count > 0)
            {
                //Submit the returned Device and the new Value for commital.
                PushProcessData(result[0],data);
            }
        }

        private void PushProcessData(Process data, Value newValue = null)
        {
            //Merges all values then replaces the entire document.
            var collection = _db.GetCollection<Process>("ProcessData");
            var filter = Builders<Process>.Filter.Eq("DeviceId", data.DeviceId);
            var result = collection.Find(filter).ToList();

            if (result.Count > 0)
            {
                var entity = result[0];
                data.ObjectId = entity.ObjectId;
                var currentVals = result[0].Values;
                var allValues = new List<Value>();

                //If not null, add the new value to the device's collection.
                if (newValue != null) allValues.Add(newValue);

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
        }
    }
}
