﻿using System.Collections.Generic;
using SCIPA.Models;

namespace SCIPA.Data.Repository
{
    interface IRepository
    {
        void CreateDevice(Models.Device device);

        Models.Device RetrieveDevice(int deviceId);

        ICollection<Models.Device> RetrieveAllDevices();

        void UpdateDevice(Models.Device device);

        void DisableDevice(Models.Device device);

        void CreateOrUpdateDevice(Models.Device device);


        void CreateAction(Models.Action action);

        Action RetrieveAction(int id);

        ICollection<Action> RetrieveActionsForDevice(int deviceId);

        ICollection<Action> RetrieveAllActions();

        void UpdateAction(Action action);

        void DeleteAction(Action action);


        void SetApplicationInformation(ApplicationInformation ai);

        ApplicationInformation GetApplicationInformation();


        void CreateDatabaseCommunicator(DatabaseCommunicator dc);

        DatabaseCommunicator RetrieveDatabaseCommunicator(int id);

        ICollection<DatabaseCommunicator> RetrieveDatabaseCommunicatorsForDevice(int deviceId);

        ICollection<DatabaseCommunicator> RetrieveAllDatabaseCommunicators();

        void UpdateDatabaseCommunicator(DatabaseCommunicator dc);

        void DeleteDatabaseCommunicator(DatabaseCommunicator dc);


        void CreateSerialCommunicator(SerialCommunicator serialCommunicator);

        SerialCommunicator RetrieveSerialCommunicator(int id);

        ICollection<SerialCommunicator> RetrieveSerialCommunicatorsForDevice(int deviceId);

        ICollection<SerialCommunicator> RetrieveAllSerialCommunicators();

        void UpdateSerialCommunicator(SerialCommunicator serialCommunicator);

        void DeleteSerialCommunicator(SerialCommunicator serialCommunicator);


        void CreateFileCommunicator(FileCommunicator dc);

        FileCommunicator RetrieveFileCommunicator(int id);

        ICollection<FileCommunicator> RetrieveFileCommunicatorsForDevice(int deviceId);

        ICollection<FileCommunicator> RetrieveAllFileCommunicators();

        void UpdateFileCommunicator(FileCommunicator fileCommunicator);

        void DeleteFileCommunicator(FileCommunicator fileCommunicator);


        void CreateRule(Rule rule);

        Rule RetrieveRule(int id);

        ICollection<Rule> RetrieveRulesForDevice(int deviceId);

        ICollection<Rule> RetrieveAllRules();

        void UpdateRule(Rule rule);

        void DeleteRule(Rule rule);
    }
}
