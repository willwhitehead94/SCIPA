using System;
using System.Collections.Generic;
using System.Linq;
using SCIPA.Domain.Generic;
using DOM = SCIPA.Models;
using DAL = SCIPA.Data.AccessLayer;
using Action = SCIPA.Models.Action;

namespace SCIPA.Data.Repository
{
    public class DataRepository : IRepository
    {
        /// <summary>
        /// Data Controller object from the DAL. Acts as the intermediary between the repository and 
        /// the database.
        /// </summary>
        readonly AccessLayer.DataController _dbController = new AccessLayer.DataController();

        /// <summary>
        /// Converter tool to convert models from Domain to Data and vice versa.
        /// </summary>
        readonly Converter _converter = new Converter();


        public void CreateDevice(DOM.Device device)
        {
            throw new NotImplementedException();
        }

        public DOM.Device RetrieveDevice(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<DOM.Device> RetrieveAllDevices()
        {
            throw new NotImplementedException();
        }

        public void UpdateDevice(DOM.Device device)
        {
            throw new NotImplementedException();
        }

        public void DisableDevice(DOM.Device device)
        {
            throw new NotImplementedException();
        }

        public void CreateOrUpdateDevice(DOM.Device device)
        {
            throw new NotImplementedException();
        }

        public void CreateAction(Action action)
        {
            throw new NotImplementedException();
        }

        public Action RetrieveAction(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Action> RetrieveActionsForDevice(int deviceId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Action> RetrieveAllActions()
        {
            throw new NotImplementedException();
        }

        public void UpdateAction(Action action)
        {
            throw new NotImplementedException();
        }

        public void DeleteAction(Action action)
        {
            throw new NotImplementedException();
        }

        public void CreateDatabaseCommunicator(DOM.DatabaseCommunicator databaseCommunicator)
        {
            throw new NotImplementedException();
        }

        public DOM.DatabaseCommunicator RetrieveDatabaseCommunicator(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<DOM.DatabaseCommunicator> RetrieveDatabaseCommunicatorsForDevice(int deviceId)
        {
            throw new NotImplementedException();
        }

        public ICollection<DOM.DatabaseCommunicator> RetrieveAllDatabaseCommunicators()
        {
            throw new NotImplementedException();
        }

        public void UpdateDatabaseCommunicator(DOM.DatabaseCommunicator databaseCommunicator)
        {
            throw new NotImplementedException();
        }

        public void DeleteDatabaseCommunicator(DOM.DatabaseCommunicator databaseCommunicator)
        {
            throw new NotImplementedException();
        }

        public void CreateFileCommunicator(DOM.FileCommunicator fileCommunicator)
        {
            throw new NotImplementedException();
        }

        public DOM.FileCommunicator RetrieveFileCommunicator(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<DOM.FileCommunicator> RetrieveFileCommunicatorsForDevice(int deviceId)
        {
            throw new NotImplementedException();
        }

        public ICollection<DOM.FileCommunicator> RetrieveAllFileCommunicators()
        {
            throw new NotImplementedException();
        }

        public void UpdateFileCommunicator(DOM.FileCommunicator fileCommunicator)
        {
            throw new NotImplementedException();
        }

        public void DeleteFileCommunicator(DOM.FileCommunicator fileCommunicator)
        {
            throw new NotImplementedException();
        }

        public void CreateSerialCommunicator(DOM.SerialCommunicator serialCommunicator)
        {
            throw new NotImplementedException();
        }

        public DOM.SerialCommunicator RetrieveSerialCommunicator(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<DOM.SerialCommunicator> RetrieveSerialCommunicatorsForDevice(int deviceId)
        {
            throw new NotImplementedException();
        }

        public ICollection<DOM.SerialCommunicator> RetrieveAllSerialCommunicators()
        {
            throw new NotImplementedException();
        }

        public void UpdateSerialCommunicator(DOM.SerialCommunicator serialCommunicator)
        {
            throw new NotImplementedException();
        }

        public void DeleteSerialCommunicator(DOM.SerialCommunicator serialCommunicator)
        {
            throw new NotImplementedException();
        }

        public void CreateRule(DOM.Rule rule)
        {
            throw new NotImplementedException();
        }

        public DOM.Rule RetrieveRule(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<DOM.Rule> RetrieveRulesForDevice(int deviceId)
        {
            throw new NotImplementedException();
        }

        public ICollection<DOM.Rule> RetrieveAllRules()
        {
            throw new NotImplementedException();
        }

        public void UpdateRule(DOM.Rule rule)
        {
            throw new NotImplementedException();
        }

        public void DeleteRule(DOM.Rule rule)
        {
            throw new NotImplementedException();
        }

        public void CreateValue(DOM.Value value)
        {
            throw new NotImplementedException();
        }

        public DOM.Value RetrieveValue(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<DOM.Value> RetrieveValuesForDevice(int deviceId)
        {
            throw new NotImplementedException();
        }

        public ICollection<DOM.Value> RetrieveAllValues()
        {
            throw new NotImplementedException();
        }

        public void UpdateValue(DOM.Value value)
        {
            throw new NotImplementedException();
        }

        public void DeleteValue(DOM.Value value)
        {
            throw new NotImplementedException();
        }

        public DOM.AppData GetApplicationInformation()
        {
            throw new NotImplementedException();
        }

        public void SetApplicationInformation(DOM.AppData ai)
        {
            throw new NotImplementedException();
        }
    }
}
