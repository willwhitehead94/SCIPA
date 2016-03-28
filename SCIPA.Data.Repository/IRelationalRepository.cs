using System;
using System.Collections.Generic;
using DAL = SCIPA.Data.AccessLayer; //Data Access Layer Models
using DOM = SCIPA.Models; //Domain Layer Models

namespace SCIPA.Data.Repository
{
    public interface IRelationalRepository
    {
        DOM.Device CreateDevice(DOM.Device device);

        DOM.Device RetrieveDevice(int id);

        IEnumerable<DOM.Device> RetrieveAllDevices();

        DOM.Device UpdateDevice(DOM.Device device);

        void DeleteDevice(DOM.Device device);

        DOM.Device CreateOrUpdateDevice(Models.Device device);

        DOM.Action CreateAction(DOM.Action action);

        DOM.Action RetrieveAction(int id);

        IEnumerable<DOM.Action> RetrieveActionsForDevice(int deviceId);

        IEnumerable<DOM.Action> RetrieveAllActions();

        DOM.Action UpdateAction(DOM.Action action);

        void DeleteAction(DOM.Action action);

        int? CreateCommunicator(DOM.Communicator communicator);

        void UpdateCommunicator(DOM.Communicator communicator);

        DOM.Communicator RetrieveCommunicator(int id);

        IEnumerable<DOM.Communicator> RetrieveCommunicatorsForDevice(int deviceId);

        IEnumerable<DOM.Communicator> RetrieveAllCommunicators();  

        DOM.Rule CreateRule(DOM.Rule rule);

        DOM.Rule RetrieveRule(int id);

        IEnumerable<DOM.Rule> RetrieveRulesForDevice(int deviceId);

        IEnumerable<DOM.Rule> RetrieveAllRules();

        DOM.Rule UpdateRule(DOM.Rule rule);

        void DeleteRule(DOM.Rule rule);

        DOM.Value CreateValue(DOM.Value value);

        DOM.Value RetrieveValue(int id);

        IEnumerable<DOM.Value> RetrieveValuesForDevice(int deviceId);

        IEnumerable<DOM.Value> RetrieveAllValues();

        void UpdateValue(DOM.Value value);

        void DeleteValue(DOM.Value value);

        DOM.AppData GetApplicationInformation();

        void SetApplicationInformation(DOM.AppData ai);

        DOM.Alarm CreateAlarm(DOM.Alarm alarm);

        IEnumerable<DOM.Alarm> RetrieveAlarms();

        IEnumerable<DOM.Alarm> RetrieveAlarmsForDevice(int deviceId);

        IEnumerable<DOM.Alarm> RetrieveAlarmsForRule(int ruleId);

        DOM.Alarm UpdateAlarm(DOM.Alarm alarm);
    }
}