using System;
using System.Collections.Generic;
using System.Linq;
using SCIPA.Domain.Generic;
using DOM = SCIPA.Models;
using DOMR = SCIPA.Models.Resources;
using DAL = SCIPA.Data.AccessLayer.Models;
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


        /// <summary>
        /// Passes a new Device to the database for insertion.
        /// </summary>
        /// <param name="device">New Device.</param>
        public void CreateDevice(DOM.Device device)
        {
            if (device == null) return;

            //check the device has not already been assigned an ID
            if (device.Id == int.MinValue) 
            {
                //do the checks to make sure nothing is null
            }

            //Pass the device object through the converter and onto the dbController.
            _dbController.CreateNewDevice(_converter.ConvertToData(device));
            DebugOutput.Print("New device created: ", device.Id.ToString());
        }

        /// <summary>
        /// Retrieve a specific Device from the database.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DOM.Device RetrieveDevice(int id)
        {
            return _converter.ConvertToDomain(_dbController.RetrieveDevice(id));
        }

        /// <summary>
        /// Get all Devices stored on the database.
        /// </summary>
        /// <returns></returns>
        public ICollection<DOM.Device> RetrieveAllDevices()
        {
            List<DOM.Device> devList = new List<DOM.Device>();

            foreach (var device in _dbController.RetrieveDevices())
            {
                devList.Add(_converter.ConvertToDomain(device));
            }

            return devList;
        }

        /// <summary>
        /// Passes an existing Device object back to the database to update it.
        /// </summary>
        /// <param name="device">Updated Device object.</param>
        public void UpdateDevice(DOM.Device device)
        {
            if (device == null) return;

            _dbController.UpdateDevice(_converter.ConvertToData(device));
            DebugOutput.Print("Device has been updated: ",device.Id.ToString());
        }

        /// <summary>
        /// Delete an existing Device object from the database.
        /// </summary>
        /// <param name="device"></param>
        public void DisableDevice(DOM.Device device)
        {
            if (device == null) return;

            _dbController.DeleteDevice(_converter.ConvertToData(device));
        }

        /// <summary>
        /// If an objects existance is unknown, check the database.
        /// If found, update, otherwise create new.
        /// </summary>
        /// <param name="device">Unknown Device object.</param>
        public void CreateOrUpdateDevice(Models.Device device)
        {
            if (device == null) return;

            if (RetrieveDevice(device.Id) == null)
            {
                device.Id = int.MinValue;
                CreateDevice(device);
            }
            else
            {
                UpdateDevice(device);
            }
        }




        public void CreateAction(Action action)
        {
            if (action == null) return;

            //check the object has not already been assigned an ID
            if (action.Id == int.MinValue)
            {
                //do the checks to make sure nothing is null
            }

            //Pass the object through the converter and onto the dbController.
            _dbController.CreateNewAction(_converter.ConvertToData(action));
        }

        public Action RetrieveAction(int id)
        {
            return _converter.ConvertToDomain(_dbController.RetrieveAction(id));
        }

        public ICollection<Action> RetrieveActionsForDevice(int deviceId)
        {
            return _dbController.RetrieveActionsForDevice(deviceId).Select(obj => _converter.ConvertToDomain(obj)).ToList();
        }

        public ICollection<Action> RetrieveAllActions()
        {
            return _dbController.RetrieveActions().Select(obj => _converter.ConvertToDomain(obj)).ToList();
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
            if (databaseCommunicator == null) return;
            _dbController.CreateDatabaseCommunicator(_converter.ConvertToData(databaseCommunicator));
        }

        public DOM.DatabaseCommunicator RetrieveDatabaseCommunicator(int id)
        {
            return _converter.ConvertToDomain(_dbController.RetrieveDatabaseCommunicator(id));
        }

        public ICollection<DOM.DatabaseCommunicator> RetrieveDatabaseCommunicatorsForDevice(int deviceId)
        {
            return _dbController.RetrieveDatabaseCommunicatorsForDevice(deviceId).Select(obj => _converter.ConvertToDomain(obj)).ToList();
        }

        public ICollection<DOM.DatabaseCommunicator> RetrieveAllDatabaseCommunicators()
        {
            return _dbController.RetrieveDatabaseCommunicators().Select(obj => _converter.ConvertToDomain(obj)).ToList();
        }

        public void UpdateDatabaseCommunicator(DOM.DatabaseCommunicator databaseCommunicator)
        {
            _dbController.UpdateDatabaseCommunicator(_converter.ConvertToData(databaseCommunicator));
        }

        public void DeleteDatabaseCommunicator(DOM.DatabaseCommunicator databaseCommunicator)
        {
            _dbController.DeleteDatabaseCommunicator(_converter.ConvertToData(databaseCommunicator));
        }




        public void CreateFileCommunicator(DOM.FileCommunicator fileCommunicator)
        {
            if (fileCommunicator == null) return;
            _dbController.CreateFileCommunicator(_converter.ConvertToData(fileCommunicator));
        }

        public DOM.FileCommunicator RetrieveFileCommunicator(int id)
        {
            return _converter.ConvertToDomain(_dbController.RetrieveFileCommunicator(id));
        }

        public ICollection<DOM.FileCommunicator> RetrieveFileCommunicatorsForDevice(int deviceId)
        {
            return _dbController.RetrieveFileCommunicatorsForDevice(deviceId).Select(obj => _converter.ConvertToDomain(obj)).ToList();
        }

        public ICollection<DOM.FileCommunicator> RetrieveAllFileCommunicators()
        {
            return _dbController.RetrieveFileCommunicators().Select(obj => _converter.ConvertToDomain(obj)).ToList();
        }

        public void UpdateFileCommunicator(DOM.FileCommunicator fileCommunicator)
        {
            _dbController.UpdateFileCommunicator(_converter.ConvertToData(fileCommunicator));
        }

        public void DeleteFileCommunicator(DOM.FileCommunicator fileCommunicator)
        {
            _dbController.DeleteFileCommunicator(_converter.ConvertToData(fileCommunicator));
        }




        public void CreateSerialCommunicator(DOM.SerialCommunicator serialCommunicator)
        {
            if (serialCommunicator == null) return;
            _dbController.CreateSerialCommunicator(_converter.ConvertToData(serialCommunicator));
        }

        public DOM.SerialCommunicator RetrieveSerialCommunicator(int id)
        {
            return _converter.ConvertToDomain(_dbController.RetrieveSerialCommunicator(id));
        }

        public ICollection<DOM.SerialCommunicator> RetrieveSerialCommunicatorsForDevice(int deviceId)
        {
            return _dbController.RetrieveSerialCommunicatorsForDevice(deviceId).Select(obj => _converter.ConvertToDomain(obj)).ToList();
        }

        public ICollection<DOM.SerialCommunicator> RetrieveAllSerialCommunicators()
        {
            return _dbController.RetrieveSerialCommunicators().Select(obj => _converter.ConvertToDomain(obj)).ToList();
        }

        public void UpdateSerialCommunicator(DOM.SerialCommunicator serialCommunicator)
        {
            _dbController.UpdateSerialCommunicator(_converter.ConvertToData(serialCommunicator));
        }

        public void DeleteSerialCommunicator(DOM.SerialCommunicator serialCommunicator)
        {
            _dbController.DeleteSerialCommunicator(_converter.ConvertToData(serialCommunicator));
        }




        public void CreateRule(DOM.Rule rule)
        {
            if (rule == null) return;
            _dbController.CreateRule(_converter.ConvertToData(rule));
        }

        public DOM.Rule RetrieveRule(int id)
        {
            return _converter.ConvertToDomain(_dbController.RetrieveRule(id));
        }

        public ICollection<DOM.Rule> RetrieveRulesForDevice(int deviceId)
        {
            return _dbController.RetrieveRulesForDevice(deviceId).Select(obj => _converter.ConvertToDomain(obj)).ToList();
        }

        public ICollection<DOM.Rule> RetrieveAllRules()
        {
            return _dbController.RetrieveRules().Select(obj => _converter.ConvertToDomain(obj)).ToList();
        }

        public void UpdateRule(DOM.Rule rule)
        {
            _dbController.UpdateRule(_converter.ConvertToData(rule));
        }

        public void DeleteRule(DOM.Rule rule)
        {
            _dbController.DeleteRule(_converter.ConvertToData(rule));
        }




        public void CreateValue(DOMR.Value value)
        {
            if (value == null) return;
            _dbController.CreateValue(_converter.ConvertToData(value));
            Console.WriteLine("Outputting data --> " + value.StringValue);
        }

        public DOMR.Value RetrieveValue(int id)
        {
            return _converter.ConvertToDomain(_dbController.RetrieveValue(id));
        }

        public ICollection<DOMR.Value> RetrieveValuesForDevice(int deviceId)
        {
            return _dbController.RetrieveValuesForDevice(deviceId).Select(obj => _converter.ConvertToDomain(obj)).ToList();
        }

        public ICollection<DOMR.Value> RetrieveAllValues()
        {
            return _dbController.RetrieveValues().Select(obj => _converter.ConvertToDomain(obj)).ToList();
        }

        public void UpdateValue(DOMR.Value value)
        {
            _dbController.UpdateValue(_converter.ConvertToData(value));
        }

        public void DeleteValue(DOMR.Value value)
        {
            _dbController.DeleteValue(_converter.ConvertToData(value));
        }


        public DOM.ApplicationInformation GetApplicationInformation()
        {
            return _converter.ConvertToDomain(_dbController.GetApplicationInformation());
        }

        public void SetApplicationInformation(DOM.ApplicationInformation ai)
        {
            _dbController.SetApplicationInformation(_converter.ConvertToData(ai));
        }
    }
}
