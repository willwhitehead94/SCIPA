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
        /// <summary>
        /// The local Mongo connection string.
        /// </summary>
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

        private static bool _mongoAccessible = false;

        /// <summary>
        /// Constructor automatically attempts to connect to the local
        /// MongoDb instance and sets the local variables to that effect.
        /// </summary>
        public DataController()
        {
            try
            {
                //Connect to the local MongoDB instance.
                if (_client == null) _client = new MongoClient(ConnectionString);

                //Access the SCIPA database on the server.
                if (_db == null) _db = _client.GetDatabase("SCIPA");

                if (_db != null)
                {
                    DebugOutput.Print("Connected to MongoDB.");
                    _mongoAccessible = true;
                    return;
                }

                //If Mongo instance cannot be verified as success, ignore calls to it until next connection.
                _mongoAccessible = false;
                DebugOutput.Print($"Could not connect to MongoDB. Ensure the the Mongo Daemon (Mongod.exe) is running!");
            }
            catch (Exception)
            {
                //Could not access the Mongo instance.
                //Ignore any attempt to use the database.
                _mongoAccessible = false;
            }

        }

        /// <summary>
        /// Posts the parametised Value object directly into the database.
        /// </summary>
        /// <param name="value"></param>
        public void AddNewValue(Value value)
        {
            if (!_mongoAccessible) return;
            try
            {
                _db.GetCollection<Value>("Values").InsertOne(value);

                PushProcessData(value);
            }
            catch (Exception e)
            {
                DebugOutput.Print(
                    $"Could not store Value {value.ValueId}'s value ({value.StringValue}) in MongoDb. ", e.Message);
            }
        }

        /// <summary>
        /// Internal conversion between a basic Device object and the logical-parent
        /// Process.
        /// </summary>
        /// <param name="device">Basic Device object.</param>
        /// <returns>Updated Process object.</returns>
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
            //If Mongo unaccessible, ignore!
            if (!_mongoAccessible) return;

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
            //If Mongo unaccessible, ignore!
            if (!_mongoAccessible) return;

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

        /// <summary>
        /// Pushes a value to it's parent data stream on MongoDB.
        /// </summary>
        /// <param name="data"></param>
        private void PushProcessData(Value data)
        {
            //If Mongo unaccessible, ignore!
            if (!_mongoAccessible) return;

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

        /// <summary>
        /// Push the Process object and the newest value to MongoDB.
        /// Finds the Device header in Mongo's ProcessData and appends
        /// the new value to it.
        /// </summary>
        private void PushProcessData(Process data, Value newValue = null)
        {
            //If Mongo unaccessible, ignore!
            if (!_mongoAccessible) return;

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

        public ICollection<Value> GetAllProcessValuesForDevice(int deviceId)
        {
            if (!_mongoAccessible) return null;

            var collection = _db.GetCollection<Process>("ProcessData");
            var filter = Builders<Process>.Filter.Eq("DeviceId", deviceId);
            var result = collection.Find(filter);

            if (result.Any())
            {
                var list = result.ToList();
                return list[0].Values.ToList();
            }
                

            return null;
        } 
    }
}
