using System.Collections.Generic;
using DAL = SCIPA.Data.AccessLayer; //Data Access Layer Models
using DOM = SCIPA.Models; //Domain Layer Models

namespace SCIPA.Data.Repository
{
    public interface IRepository
    {
        void CreateDevice(DOM.Device device);

        DOM.Device RetrieveDevice(int id);

        ICollection<DOM.Device> RetrieveAllDevices();

        void UpdateDevice(DOM.Device device);

        void DisableDevice(DOM.Device device);

        void CreateOrUpdateDevice(Models.Device device);

        void CreateAction(DOM.Action action);

        DOM.Action RetrieveAction(int id);

        ICollection<DOM.Action> RetrieveActionsForDevice(int deviceId);

        ICollection<DOM.Action> RetrieveAllActions();

        void UpdateAction(DOM.Action action);

        void DeleteAction(DOM.Action action);

        void CreateDatabaseCommunicator(DOM.DatabaseCommunicator databaseCommunicator);

        //DOM.DatabaseCommunicator RetrieveDatabaseCommunicator(int id);

        //ICollection<DOM.DatabaseCommunicator> RetrieveDatabaseCommunicatorsForDevice(int deviceId);

        //ICollection<DOM.DatabaseCommunicator> RetrieveAllDatabaseCommunicators();

        void UpdateDatabaseCommunicator(DOM.DatabaseCommunicator databaseCommunicator);

        void DeleteDatabaseCommunicator(DOM.DatabaseCommunicator databaseCommunicator);

        void CreateFileCommunicator(DOM.FileCommunicator fileCommunicator);

        //DOM.FileCommunicator RetrieveFileCommunicator(int id);

        //ICollection<DOM.FileCommunicator> RetrieveFileCommunicatorsForDevice(int deviceId);

        //ICollection<DOM.FileCommunicator> RetrieveAllFileCommunicators();

        void UpdateFileCommunicator(DOM.FileCommunicator fileCommunicator);

        void DeleteFileCommunicator(DOM.FileCommunicator fileCommunicator);

        void CreateSerialCommunicator(DOM.SerialCommunicator serialCommunicator);

        //DOM.SerialCommunicator RetrieveSerialCommunicator(int id);

        //ICollection<DOM.SerialCommunicator> RetrieveSerialCommunicatorsForDevice(int deviceId);

        //ICollection<DOM.SerialCommunicator> RetrieveAllSerialCommunicators();

        void UpdateSerialCommunicator(DOM.SerialCommunicator serialCommunicator);

        void DeleteSerialCommunicator(DOM.SerialCommunicator serialCommunicator);

        void CreateRule(DOM.Rule rule);

        DOM.Rule RetrieveRule(int id);

        ICollection<DOM.Rule> RetrieveRulesForDevice(int deviceId);

        ICollection<DOM.Rule> RetrieveAllRules();

        void UpdateRule(DOM.Rule rule);

        void DeleteRule(DOM.Rule rule);

        void CreateValue(DOM.Value value);

        DOM.Value RetrieveValue(int id);

        ICollection<DOM.Value> RetrieveValuesForDevice(int deviceId);

        ICollection<DOM.Value> RetrieveAllValues();

        void UpdateValue(DOM.Value value);

        void DeleteValue(DOM.Value value);

        DOM.AppData GetApplicationInformation();

        void SetApplicationInformation(DOM.AppData ai);
    }
}