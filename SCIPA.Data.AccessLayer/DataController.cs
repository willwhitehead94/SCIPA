using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace SCIPA.Data.AccessLayer
{
    public class DataController
    {
        private readonly SCIPAEntities _db = new SCIPAEntities();

        public void SetAppData(AppData ai)
        {
            var current = _db.AppData.First();
            current = ai;
            _db.SaveChanges();
        }

        public AppData GetAppData()
        {
            return _db.AppData.First();
        }

        public void CreateDevice(Device device)
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

        public IEnumerable<Device> RetrieveDevices()
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

        public void CreateAction(Action action)
        {
            _db.Actions.Add(action);
        }

        public Action RetrieveAction(int id)
        {
            return _db.Actions.FirstOrDefault(a => a.Id == id);
        }

        public IEnumerable<Action> RetrieveActionsForDevice(int deviceId)
        {
            return _db.Actions.Where(a => a.Device.Id == deviceId).ToList();
        }

        public IEnumerable<Action> RetrieveActions()
        {
            return _db.Actions.ToList();
        }

        public void UpdateAction(Action action)
        {
            var toUpdate = _db.Actions.FirstOrDefault(a => a.Id == action.Id);
            if (toUpdate != null)
            {
                toUpdate = action;
                _db.SaveChanges();
            }
        }

        public void DeleteAction(Action action)
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
            _db.Communicators.Add(dc);
            _db.SaveChanges();
        }

        public DatabaseCommunicator RetrieveDatabaseCommunicator(int id)
        {
            return (DatabaseCommunicator)_db.Communicators.FirstOrDefault(dc => dc.Id == id);
        }

        //public IEnumerable<DatabaseCommunicator> RetrieveDatabaseCommunicatorsForDevice(int deviceId)
        //{
        //    return _db.Communicators.Where(comm => comm.Device.Id == deviceId);
        //}

        //public IEnumerable<DatabaseCommunicator> RetrieveDatabaseCommunicators()
        //{
        //    return _db.DatabaseCommunicators.ToList();
        //}

        public void UpdateDatabaseCommunicator(DatabaseCommunicator dc)
        {
            var toUpdate = RetrieveDatabaseCommunicator(dc.Id);
            if (toUpdate != null)
            {
                toUpdate = dc;
                _db.SaveChanges();
            }
        }

        public void DeleteDatabaseCommunicator(DatabaseCommunicator dc)
        {
            var toDelete = RetrieveDatabaseCommunicator(dc.Id);
            if (toDelete != null)
            {
                _db.Communicators.Remove(toDelete);
                _db.SaveChanges();
            }
        }

        public void CreateFileCommunicator(FileCommunicator fc)
        {
            if (fc == null) return;
            _db.Communicators.Add(fc);

            _db.SaveChanges();
        }

        public FileCommunicator RetrieveFileCommunicator(int id)
        {
            return (FileCommunicator)_db.Communicators.FirstOrDefault(fc => fc.Id == id);
        }

        //public IEnumerable<FileCommunicator> RetrieveFileCommunicatorsForDevice(int deviceId)
        //{
        //    return null;
        //    //return _db.FileCommunicators.Where(fc => fc.Device.Id == deviceId).ToList();
        //}

        //public IEnumerable<FileCommunicator> RetrieveFileCommunicators()
        //{
        //    return _db.FileCommunicators.ToList();
        //}

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
                _db.Communicators.Remove(toDelete);
                _db.SaveChanges();
            }
        }

        public void CreateSerialCommunicator(SerialCommunicator sc)
        {
            if (sc == null) return;
            _db.Communicators.Add(sc);
            _db.SaveChanges();
        }

        public SerialCommunicator RetrieveSerialCommunicator(int id)
        {
            return (SerialCommunicator)_db.Communicators.FirstOrDefault(sc => sc.Id == id);
        }

        //public IEnumerable<SerialCommunicator> RetrieveSerialCommunicatorsForDevice(int deviceId)
        //{
        //    return null;
        //    //return _db.SerialCommunicators.Where(sc => sc.Device.Id == deviceId).ToList();
        //}

        //public IEnumerable<SerialCommunicator> RetrieveSerialCommunicators()
        //{
        //    return _db.SerialCommunicators.ToList();
        //}

        public void UpdateSerialCommunicator(SerialCommunicator sc)
        {
            var toUpdate = RetrieveSerialCommunicator(sc.Id);
            if (toUpdate != null)
            {
                toUpdate = sc;
                _db.SaveChanges();
            }
        }

        public void DeleteSerialCommunicator(SerialCommunicator sc)
        {
            var toDelete = RetrieveSerialCommunicator(sc.Id);
            if (toDelete != null)
            {
                _db.Communicators.Remove(toDelete);
                _db.SaveChanges();
            }
        }


        public void CreateCommunicator(Communicator comm)
        {
            _db.Communicators.Add(comm);
            _db.SaveChanges();
        }

        public IEnumerable<Communicator> RetrieveAllCommunicators()
        {
            return _db.Communicators.ToList();
        }

        public IEnumerable<Communicator> RetrieveCommunicatorsByDeviceId(int id)
        {
            return _db.Communicators.Where(comm => comm.Devices.Any(dev=>dev.Id == id)).ToList();
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

        public IEnumerable<Rule> RetrieveRulesForDevice(int deviceId)
        {
            return _db.Rules.Where(rule => rule.Device.Id == deviceId).ToList();
        }

        public IEnumerable<Rule> RetrieveRules()
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

        public IEnumerable<Value> RetrieveValuesForDevice(int deviceId)
        {
            return _db.Values.Where(value => value.Device.Id == deviceId).ToList();
        }

        public IEnumerable<Value> RetrieveValues()
        {
            return _db.Values.ToList();
        }

        public void UpdateValue(Value value)
        {
            var toUpdate = RetrieveValue(value.Id);
            if (toUpdate != null)
            {
                toUpdate = value;
                _db.SaveChanges();
            }
        }

        public void DeleteValue(Value value)
        {
            var toDelete = RetrieveValue(value.Id);
            if (toDelete != null)
            {
                _db.Values.Remove(toDelete);
                _db.SaveChanges();
            }
        }
    }
}