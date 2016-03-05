using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCIPA.Data.AccessLayer.Models;

namespace SCIPA.Data.AccessLayer
{
    public class DataController : IDataController
    {
        private readonly DataModel _db = new DataModel();

        public string xxxx()
        {
            return _db.Database.Connection.ConnectionString;
        }

        public void SetApplicationInformation(ApplicationInformation ai)
        {
            var current = _db.ApplicationInformation.First();
            current = ai;
            _db.SaveChanges();
        }

        public ApplicationInformation GetApplicationInformation()
        {
            return _db.ApplicationInformation.First();
        }

        public void CreateNewDevice(Device device)
        {
            _db.Devices.Add(device);
            _db.SaveChanges();
        }

        public void DeleteDevice(Device device)
        {
            var temp = _db.Devices.FirstOrDefault(dev => dev.Id == device.Id);
            if (temp == null) return;
            temp.Enabled = false;
            _db.SaveChanges();
        }

        public Device RetrieveDevice(int deviceId)
        {
            return _db.Devices.FirstOrDefault(dev => dev.Id == deviceId);
        }

        public ICollection<Device> RetrieveDevices()
        {
            return _db.Devices.ToList();
        }

        public void UpdateDevice(Device device)
        {
            var temp = _db.Devices.FirstOrDefault(dev => dev.Id == device.Id);
            
            if (temp != null)
            {
                temp = device;
                _db.Devices.AddOrUpdate(temp);
                _db.SaveChanges();
            }
        }

        public void CreateNewAction(Models.Action action)
        {
            _db.Actions.Add(action);
        }

        public Models.Action RetrieveAction(int id)
        {
            return _db.Actions.FirstOrDefault(a => a.Id == id);
        }

        public ICollection<Models.Action> RetrieveActionsForDevice(int deviceId)
        {
            return _db.Actions.Where(a => a.Device.Id == deviceId).ToList();
        }

        public ICollection<Models.Action> RetrieveActions()
        {
            return _db.Actions.ToList();
        }

        public void UpdateAction(Models.Action action)
        {
            var toUpdate = _db.Actions.FirstOrDefault(a => a.Id == action.Id);
            if (toUpdate != null)
            {
                toUpdate = action;
                _db.SaveChanges();
            }
        }

        public void DeleteAction(Models.Action action)
        {
            var toDelete = _db.Actions.FirstOrDefault(a => a.Id == action.Id);
            if (toDelete != null)
            {
                _db.Actions.Remove(toDelete);
                _db.SaveChanges();
            }
        }

        public void CreateDatabaseCommunicator(DatabaseCommunicator dc)
        {
            if (dc == null) return;
            _db.DatabaseCommunicators.Add(dc);
            _db.SaveChanges();
        }

        public DatabaseCommunicator RetrieveDatabaseCommunicator(int id)
        {
            return _db.DatabaseCommunicators.FirstOrDefault(dc => dc.id == id);
        }

        public ICollection<DatabaseCommunicator> RetrieveDatabaseCommunicatorsForDevice(int deviceId)
        {
            return _db.DatabaseCommunicators.Where(dc => dc.Device.Id == deviceId).ToList();
        } 

        public ICollection<DatabaseCommunicator> RetrieveDatabaseCommunicators()
        {
            return _db.DatabaseCommunicators.ToList();
        }

        public void UpdateDatabaseCommunicator(DatabaseCommunicator dc)
        {
            var toUpdate = RetrieveDatabaseCommunicator(dc.id);
            if (toUpdate != null)
            {
                toUpdate = dc;
                _db.SaveChanges();
            }
        }

        public void DeleteDatabaseCommunicator(DatabaseCommunicator dc)
        {
            var toDelete = RetrieveDatabaseCommunicator(dc.id);
            if (toDelete != null)
            {
                _db.DatabaseCommunicators.Remove(toDelete);
                _db.SaveChanges();
            }
        }

        public void CreateFileCommunicator(FileCommunicator fc)
        {
            if (fc == null) return;
            _db.FileCommunicators.Add(fc);
            _db.SaveChanges();
        }

        public FileCommunicator RetrieveFileCommunicator(int id)
        {
            return _db.FileCommunicators.FirstOrDefault(fc => fc.Id == id);
        }

        public ICollection<FileCommunicator> RetrieveFileCommunicatorsForDevice(int deviceId)
        {
            return _db.FileCommunicators.Where(fc => fc.Device.Id == deviceId).ToList();
        }

        public ICollection<FileCommunicator> RetrieveFileCommunicators()
        {
            return _db.FileCommunicators.ToList();
        }

        public void UpdateFileCommunicator(FileCommunicator fc)
        {
            var toUpdate = RetrieveFileCommunicator(fc.Id);
            if (toUpdate != null)
            {
                toUpdate = fc;
                _db.SaveChanges();
            }
        }

        public void DeleteFileCommunicator(FileCommunicator fc)
        {
            var toDelete = RetrieveFileCommunicator(fc.Id);
            if (toDelete != null)
            {
                _db.FileCommunicators.Remove(toDelete);
                _db.SaveChanges();
            }
        }

        public void CreateSerialCommunicator(SerialCommunicator sc)
        {
            if (sc == null) return;
            _db.SerialCommunicators.Add(sc);
            _db.SaveChanges();
        }

        public SerialCommunicator RetrieveSerialCommunicator(int id)
        {
            return _db.SerialCommunicators.FirstOrDefault(sc => sc.id == id);
        }

        public ICollection<SerialCommunicator> RetrieveSerialCommunicatorsForDevice(int deviceId)
        {
            return _db.SerialCommunicators.Where(sc => sc.Device.Id == deviceId).ToList();
        }

        public ICollection<SerialCommunicator> RetrieveSerialCommunicators()
        {
            return _db.SerialCommunicators.ToList();
        }

        public void UpdateSerialCommunicator(SerialCommunicator sc)
        {
            var toUpdate = RetrieveSerialCommunicator(sc.id);
            if (toUpdate != null)
            {
                toUpdate = sc;
                _db.SaveChanges();
            }
        }

        public void DeleteSerialCommunicator(SerialCommunicator sc)
        {
            var toDelete = RetrieveSerialCommunicator(sc.id);
            if (toDelete != null)
            {
                _db.SerialCommunicators.Remove(toDelete);
                _db.SaveChanges();
            }
        }

        public void CreateRule(Rule rule)
        {
            if (rule == null) return;
            _db.Rules.Add(rule);
            _db.SaveChanges();
        }

        public Rule RetrieveRule(int id)
        {
            return _db.Rules.FirstOrDefault(rule => rule.Id == id);
        }

        public ICollection<Rule> RetrieveRulesForDevice(int deviceId)
        {
            return _db.Rules.Where(rule => rule.Device.Id == deviceId).ToList();
        }

        public ICollection<Rule> RetrieveRules()
        {
            return _db.Rules.ToList();
        }

        public void UpdateRule(Rule rule)
        {
            var toUpdate = RetrieveRule(rule.Id);
            if (toUpdate != null)
            {
                toUpdate = rule;
                _db.SaveChanges();
            }
        }

        public void DeleteRule(Rule rule)
        {
            var toDelete = RetrieveRule(rule.Id);
            if (toDelete != null)
            {
                _db.Rules.Remove(toDelete);
                _db.SaveChanges();
            }
        }

        public void CreateValue(Value Value)
        {
            if (Value == null) return;
            _db.Values.Add(Value);
            _db.SaveChanges();
        }

        public Value RetrieveValue(int id)
        {
            return _db.Values.FirstOrDefault(Value => Value.Id == id);
        }

        public ICollection<Value> RetrieveValuesForDevice(int deviceId)
        {
            return _db.Values.Where(Value => Value.Device.Id == deviceId).ToList();
        }

        public ICollection<Value> RetrieveValues()
        {
            return _db.Values.ToList();
        }

        public void UpdateValue(Value Value)
        {
            var toUpdate = RetrieveValue(Value.Id);
            if (toUpdate != null)
            {
                toUpdate = Value;
                _db.SaveChanges();
            }
        }

        public void DeleteValue(Value Value)
        {
            var toDelete = RetrieveValue(Value.Id);
            if (toDelete != null)
            {
                _db.Values.Remove(toDelete);
                _db.SaveChanges();
            }
        }
    }
}
