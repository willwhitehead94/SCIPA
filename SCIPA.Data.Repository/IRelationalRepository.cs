using System.Collections.Generic;
using DAL = SCIPA.Data.AccessLayer; //Data Access Layer Models
using DOM = SCIPA.Models; //Domain Layer Models

namespace SCIPA.Data.Repository
{
    public interface IRelationalRepository
    {
        void CreateDevice(DOM.Device device);

        DOM.Device RetrieveDevice(int id);

        IEnumerable<DOM.Device> RetrieveAllDevices();

        void UpdateDevice(DOM.Device device);

        void DeleteDevice(DOM.Device device);

        void CreateOrUpdateDevice(Models.Device device);

        void CreateAction(DOM.Action action);

        DOM.Action RetrieveAction(int id);

        IEnumerable<DOM.Action> RetrieveActionsForDevice(int deviceId);

        IEnumerable<DOM.Action> RetrieveAllActions();

        void UpdateAction(DOM.Action action);

        void DeleteAction(DOM.Action action);

        //void CreateDatabaseCommunicator(DOM.DatabaseCommunicator databaseCommunicator);

        //DOM.DatabaseCommunicator RetrieveDatabaseCommunicator(int id);

        //IEnumerable<DOM.DatabaseCommunicator> RetrieveDatabaseCommunicatorsForDevice(int deviceId);

        //IEnumerable<DOM.DatabaseCommunicator> RetrieveAllDatabaseCommunicators();

        //void UpdateDatabaseCommunicator(DOM.DatabaseCommunicator databaseCommunicator);

        //void DeleteDatabaseCommunicator(DOM.DatabaseCommunicator databaseCommunicator);

        int? CreateCommunicator(DOM.Communicator communicator);

        //DOM.FileCommunicator RetrieveFileCommunicator(int id);

        //IEnumerable<DOM.FileCommunicator> RetrieveFileCommunicatorsForDevice(int deviceId);

        //IEnumerable<DOM.FileCommunicator> RetrieveAllFileCommunicators();

        void UpdateCommunicator(DOM.Communicator communicator);

        //void DeleteFileCommunicator(DOM.FileCommunicator fileCommunicator);

        //void CreateSerialCommunicator(DOM.SerialCommunicator serialCommunicator);

        //DOM.SerialCommunicator RetrieveSerialCommunicator(int id);

        //IEnumerable<DOM.SerialCommunicator> RetrieveSerialCommunicatorsForDevice(int deviceId);

        //IEnumerable<DOM.SerialCommunicator> RetrieveAllSerialCommunicators();

        DOM.Communicator RetrieveCommunicator(int id);

        IEnumerable<DOM.Communicator> RetrieveCommunicatorsForDevice(int deviceId);

        IEnumerable<DOM.Communicator> RetrieveAllCommunicators();  

        //void UpdateSerialCommunicator(DOM.SerialCommunicator serialCommunicator);

        //void DeleteSerialCommunicator(DOM.SerialCommunicator serialCommunicator);

        void CreateRule(DOM.Rule rule);

        DOM.Rule RetrieveRule(int id);

        IEnumerable<DOM.Rule> RetrieveRulesForDevice(int deviceId);

        IEnumerable<DOM.Rule> RetrieveAllRules();

        void UpdateRule(DOM.Rule rule);

        void DeleteRule(DOM.Rule rule);

        void CreateValue(DOM.Value value);

        DOM.Value RetrieveValue(int id);

        IEnumerable<DOM.Value> RetrieveValuesForDevice(int deviceId);

        IEnumerable<DOM.Value> RetrieveAllValues();

        void UpdateValue(DOM.Value value);

        void DeleteValue(DOM.Value value);

        DOM.AppData GetApplicationInformation();

        void SetApplicationInformation(DOM.AppData ai);
    }
}