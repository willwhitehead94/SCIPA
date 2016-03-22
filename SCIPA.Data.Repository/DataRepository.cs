using System;
using System.Collections.Generic;
using System.Linq;
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
        readonly DAL.DataController _dbController = new AccessLayer.DataController();

        /// <summary>
        /// Converter tool to convert models from Domain to Data and vice versa.
        /// </summary>
        readonly Converter _converter = new Converter();


        public void CreateDevice(DOM.Device device)
        {
            _dbController.CreateDevice(_converter.ConvertToData(device));
        }

        public DOM.Device RetrieveDevice(int id)
        {
            return _converter.ConvertToDomain(_dbController.RetrieveDevice(id));
        }

        public ICollection<DOM.Device> RetrieveAllDevices()
        {
            return _dbController.RetrieveDevices().Select(dev => _converter.ConvertToDomain(dev)).ToList();
        }

        public void UpdateDevice(DOM.Device device)
        {
            _dbController.UpdateDevice(_converter.ConvertToData(device));
        }

        public void DisableDevice(DOM.Device device)
        {
            _dbController.DeleteDevice(_converter.ConvertToData(device));
        }

        public void CreateOrUpdateDevice(DOM.Device device)
        {
            //Ensure the passed device is valid.
            if (device.Id > 0)
            {
                var retrievedDevice = RetrieveDevice(device.Id);

                if (retrievedDevice != null)
                {
                    //If a device was retrieved then the update method is called.
                    _dbController.UpdateDevice(_converter.ConvertToData(retrievedDevice));
                    return;
                }
            }

            //If not found/not retrieved - create new.
            _dbController.CreateDevice(_converter.ConvertToData(device));
        }

        public void CreateAction(Action action)
        {
            _dbController.CreateAction(_converter.ConvertToData(action));
        }

        public Action RetrieveAction(int id)
        {
            return _converter.ConvertToDomain(_dbController.RetrieveAction(id));
        }

        public ICollection<Action> RetrieveActionsForDevice(int deviceId)
        {
            return _dbController.RetrieveActionsForDevice(deviceId).Select(action => _converter.ConvertToDomain(action)).ToList();
        }

        public ICollection<Action> RetrieveAllActions()
        {
            return _dbController.RetrieveActions().Select(action => _converter.ConvertToDomain(action)).ToList();
        }

        public void UpdateAction(Action action)
        {
            _dbController.UpdateAction(_converter.ConvertToData(action));
        }

        public void DeleteAction(Action action)
        {
            _dbController.DeleteAction(_converter.ConvertToData(action));
        }

        public void CreateDatabaseCommunicator(DOM.DatabaseCommunicator databaseCommunicator)
        {
            _dbController.CreateDatabaseCommunicator(_converter.ConvertToData(databaseCommunicator));
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

        public void UpdateSerialCommunicator(DOM.SerialCommunicator serialCommunicator)
        {
            throw new NotImplementedException();
        }

        public void DeleteSerialCommunicator(DOM.SerialCommunicator serialCommunicator)
        {
            throw new NotImplementedException();
        }

        public ICollection<DOM.Communicator> RetrieveAllCommunicators()
        {
            return _dbController.RetrieveAllCommunicators().Select(comm => _converter.ConvertToDomain(comm)).ToList();
        }

        public ICollection<DOM.Communicator> RetrieveCommunicatorsForDevice(int deviceId)
        {
            return _dbController.RetrieveCommunicatorsByDeviceId(deviceId).Select(comm => _converter.ConvertToDomain(comm)).ToList();
        }

        public DOM.Communicator RetrieveCommunicator(int id)
        {
            return _converter.ConvertToDomain(_dbController.RetrieveAllCommunicators().FirstOrDefault(comm => comm.Id == id));
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