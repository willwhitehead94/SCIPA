using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;
using AutoMapper;
using SCIPA.Domain.Generic;
using DAL = SCIPA.Data.AccessLayer;
using DOM = SCIPA.Models;

namespace SCIPA.Data.Repository
{
    public class RelationalRepository : IRelationalRepository
    {
        /// <summary>
        /// Data Controller object from the DAL. Acts as the intermediary between the repository and 
        /// the database.
        /// </summary>
        private readonly DAL.SCIPAEntities _db = new DAL.SCIPAEntities();


        /// <summary>
        /// Automapper object to map between DAL and DOM models.
        /// </summary>
        private readonly IMapper _mapper;

        /// <summary>
        /// Initialises the AutoMapper configuration for detailed and complex maps between
        /// Domain and Data models used within the application. 
        /// Important to note is that the mapping of 'virtual' properties should always
        /// be ignored so as to prevent circular mapping, as well as any ID fields
        /// when used as primary keys so as not to override EF's database and entity
        /// understanding incorrectly.
        /// </summary>
        public RelationalRepository()
        {
            // Configure AutoMapper for update operations.
            _mapper = new MapperConfiguration(cfg =>
            {
                /*
                * All Maps will ignore the ID and any form of navigational
                * properties. Reduces any issues AutoMapper may face
                * with regards to Circular dependencies.
                */

                // Domain to Data Converstions
                cfg.CreateMap<DOM.Action, DAL.Action>()
                    .ForMember(m => m.Id, opt => opt.Ignore());

                cfg.CreateMap<DOM.AppData, DAL.AppData>();

                cfg.CreateMap<DOM.Communicator, DAL.Communicator>()
                    .ForMember(m => m.Id, opt => opt.Ignore())
                    .ForMember(m => m.Device, opt => opt.Ignore());

                cfg.CreateMap<DOM.CommunicatorType, DAL.CommunicatorType>();

                cfg.CreateMap<DOM.DatabaseCommunicator, DAL.DatabaseCommunicator>();

                cfg.CreateMap<DOM.SerialCommunicator, DAL.SerialCommunicator>();

                cfg.CreateMap<DOM.FileCommunicator, DAL.FileCommunicator>();

                cfg.CreateMap<DOM.Device, DAL.Device>()
                    .ForMember(m => m.Rules, opt => opt.Ignore());

                cfg.CreateMap<DOM.Rule, DAL.Rule>()
                    .ForMember(m => m.Id, opt => opt.Ignore())
                    .ForMember(m=>m.Device,opt=>opt.Ignore());

                cfg.CreateMap<DOM.RuleType, DAL.RuleType>();

                cfg.CreateMap<DOM.Value, DAL.Value>()
                    .ForMember(m => m.Id, opt => opt.Ignore());

                cfg.CreateMap<DAL.ValueType, DAL.ValueType>();








                // Data to Domain Converstions
                cfg.CreateMap<DAL.Action, DOM.Action>()
                    .ForMember(m => m.Id, opt => opt.Ignore());

                cfg.CreateMap<DAL.AppData, DOM.AppData>();

                cfg.CreateMap<DAL.Communicator, DOM.Communicator>()
                    .ForMember(m => m.Id, opt => opt.Ignore())
                    .ForMember(m => m.Device, opt => opt.Ignore());

                cfg.CreateMap<DAL.CommunicatorType, DOM.CommunicatorType>();

                cfg.CreateMap<DAL.DatabaseCommunicator, DOM.DatabaseCommunicator>();

                cfg.CreateMap<DAL.SerialCommunicator, DOM.SerialCommunicator>();

                cfg.CreateMap<DAL.FileCommunicator, DOM.FileCommunicator>();

                cfg.CreateMap<DAL.Device, DOM.Device>()
                    .ForMember(m => m.Rules, opt => opt.Ignore());

                cfg.CreateMap<DAL.Rule, DOM.Rule>()
                    .ForMember(m => m.Device, opt => opt.Ignore());

                cfg.CreateMap<DAL.RuleType, DOM.RuleType>();

                cfg.CreateMap<DAL.Value, DOM.Value>()
                    .ForMember(m => m.Device, opt => opt.Ignore());

                cfg.CreateMap<DAL.ValueType, DOM.ValueType>();

            }).CreateMapper();
        }

        /// <summary>
        /// Creates a new Device object within the database.
        /// </summary>
        /// <param name="device"></param>
        public void CreateDevice(DOM.Device device)
        {
            _db.Devices.Add(_mapper.Map(device, new DAL.Device()));
            _db.SaveChanges();
        }

        /// <summary>
        /// Returns a single Device matching the parametised ID number.
        /// </summary>
        /// <param name="id">ID Number</param>
        /// <returns>Domain model of the database object.</returns>
        public DOM.Device RetrieveDevice(int id)
        {
            return _mapper.Map(_db.Devices.FirstOrDefault(dev => dev.Id == id), new DOM.Device());
        }

        /// <summary>
        /// Returns all of the Devices on the database in Domain models.
        /// </summary>
        /// <returns>Domain models of the database objects.</returns>
        public IEnumerable<DOM.Device> RetrieveAllDevices()
        {
            var dal = _db.Devices.First();
            var dom = new DOM.Device();

            _mapper.Map<DAL.Device, DOM.Device>(dal, dom);
            dom = _mapper.Map<DAL.Device, DOM.Device>(dal, dom);

            return _db.Devices.ToList().Select(device => _mapper.Map(device, new DOM.Device()));
        }

        /// <summary>
        /// Updates the database copy of the parametised domain model.
        /// </summary>
        /// <param name="device"></param>
        public void UpdateDevice(DOM.Device device)
        {
            var dbCurrent = _db.Devices.FirstOrDefault(dev => dev.Id == device.Id);
            _mapper.Map(device, dbCurrent);

            _db.Entry(dbCurrent).State=EntityState.Modified;
            _db.SaveChanges();
        }
        
        /// <summary>
        /// Updates the database to remove the device from the system.
        /// </summary>
        /// <param name="device"></param>
        public void DeleteDevice(DOM.Device device)
        {
            var dbValue = RetrieveDevice(device.Id);
            if (dbValue == null) return;
            _db.Devices.Remove(_mapper.Map(dbValue, new DAL.Device()));
            _db.SaveChanges();
        }

        /// <summary>
        /// Decides on behalf of the user whether to create a new Device 
        /// entity or whether to update an entity that exists in its place.
        /// </summary>
        /// <param name="device"></param>
        public void CreateOrUpdateDevice(DOM.Device device)
        {
            var dbValue = RetrieveDevice(device.Id);
            if (dbValue == null)
            {
                CreateDevice(device);
            }
            else
            {
                UpdateDevice(device);
            }
        }

        /// <summary>
        /// Creates a new Action object within the database.
        /// </summary>
        /// <param name="action"></param>
        public void CreateAction(DOM.Action action)
        {
            _db.Actions.Add(_mapper.Map(action, new DAL.Action()));
            _db.SaveChanges();
        }

        /// <summary>
        /// Returns a single Action object from the parametised ID number.
        /// </summary>
        /// <param name="id">ID Number.</param>
        /// <returns>Domain model of the database object.</returns>
        public DOM.Action RetrieveAction(int id)
        {
            return _mapper.Map(_db.Actions.FirstOrDefault(act => act.Id == id), new DOM.Action());
        }

        /// <summary>
        /// Returns all database actions for a given device via the parametised Id.
        /// </summary>
        /// <param name="deviceId">Device ID Number</param>
        /// <returns>Domain models of the database objects.</returns>
        public IEnumerable<DOM.Action> RetrieveActionsForDevice(int deviceId)
        {
            //TODO fix this!
            return null;// _db.Actions.Where(act => act.DeviceId == deviceId).Select(act => _mapper.Map(act, new DOM.Action())).ToList();
        }

        /// <summary>
        /// Returns all known Actions from the database within Domain models.
        /// </summary>
        /// <returns>Domain models of the database objects.</returns>
        public IEnumerable<DOM.Action> RetrieveAllActions()
        {
            return _db.Actions.Select(act => _mapper.Map(act, new DOM.Action())).ToList();
        }

        /// <summary>
        /// Updates the database Action entity based on the changes made in
        /// the parammetised Domain model.
        /// </summary>
        /// <param name="action">Domain model to update.</param>
        public void UpdateAction(DOM.Action action)
        {
            var dbValue = RetrieveAction(action.Id);
            if (dbValue == null) return;

            _mapper.Map(action, dbValue);
            _db.Entry(dbValue).State = EntityState.Modified;
            _db.SaveChanges();
        }

        /// <summary>
        /// Removes the action from the database.
        /// </summary>
        /// <param name="action">Action to remove.</param>
        public void DeleteAction(DOM.Action action)
        {
            var dbValue = RetrieveAction(action.Id);
            if (dbValue == null) return;
            _db.Actions.Remove(_mapper.Map(action, new DAL.Action()));
            _db.SaveChanges();
        }

        /// <summary>
        /// Creates a new Communicator object on the database. Automatically
        /// handles each of the subsidary Communicator types internally.
        /// </summary>
        /// <param name="communicator">The domain model to push up to the database.</param>
        /// <returns>The new ID number</returns>
        public int? CreateCommunicator(DOM.Communicator communicator)
        {
            DAL.Communicator dbVal;

            switch (communicator.Type)
            {
                case DOM.CommunicatorType.FlatFile:
                    dbVal = _mapper.Map(communicator, new DAL.FileCommunicator());
                    break;
                case DOM.CommunicatorType.Serial:
                    dbVal= _mapper.Map(communicator, new DAL.SerialCommunicator());
                    break;
                case DOM.CommunicatorType.Database:
                    dbVal = _mapper.Map(communicator, new DAL.DatabaseCommunicator());
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            var dalDevice = _mapper.Map(communicator.Device, dbVal.Device);
            dbVal.Device = dalDevice;

            try
            {
                _db.Entry(dbVal.Device).State = EntityState.Unchanged;
                _db.Communicators.Add(dbVal);

                _db.SaveChanges();
                return _db.Communicators.Find(dbVal.Id).Id;
            }
            catch (Exception e)
            {
                DebugOutput.Print("System was unable to detatch the Device from the new Communicator! ", e.Message);
            }

            return null;
        }

        public void UpdateCommunicator(DOM.Communicator communicator)
        {
            var dbValue = _db.Communicators.FirstOrDefault(comm => comm.Id == communicator.Id);
            if (dbValue == null) return;
            _mapper.Map(communicator, dbValue);

            //Tell EF that the object has been updated.
            _db.Entry(dbValue).State = EntityState.Modified;

            //Ensure that EF is aware this child object has not changed (and thus does not need changing/creating).
            _db.Entry(dbValue.Device).State = EntityState.Unchanged;
            _db.SaveChanges();
        }

        public DOM.Communicator RetrieveCommunicator(int id)
        {
            var dbValue = _db.Communicators.FirstOrDefault(comm => comm.Id == id);
            if (dbValue == null) return null;
            return ConvertDALCommunicatorToDOM(dbValue);
        }

        public IEnumerable<DOM.Communicator> RetrieveCommunicatorsForDevice(int deviceId)
        {
            return ConvertDALCommunicatorsToDOM(_db.Communicators.Where(comm => comm.Device.Id == deviceId)).ToList();
        }

        public IEnumerable<DOM.Communicator> RetrieveAllCommunicators()
        {
            return ConvertDALCommunicatorsToDOM(_db.Communicators).ToList();
        }

        public void CreateRule(DOM.Rule rule)
        {
            _db.Rules.Add(_mapper.Map(rule, new DAL.Rule()));
            _db.SaveChanges();
        }

        public DOM.Rule RetrieveRule(int id)
        {
            return _mapper.Map(_db.Rules.FirstOrDefault(rule => rule.Id == id), new DOM.Rule());
        }

        public IEnumerable<DOM.Rule> RetrieveRulesForDevice(int deviceId)
        {
            return _db.Rules.Where(rule => rule.DeviceId == deviceId).Select(rule => _mapper.Map(rule, new DOM.Rule())).ToList();
        }

        public IEnumerable<DOM.Rule> RetrieveAllRules()
        {
            return _db.Rules.Select(rule => _mapper.Map(rule, new DOM.Rule())).ToList();
        }

        public void UpdateRule(DOM.Rule rule)
        {
            var dbValue = _db.Rules.FirstOrDefault(r => r.Id == rule.Id);
            if (dbValue == null) return;
            _mapper.Map(rule, dbValue);
            _db.Entry(dbValue).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public void DeleteRule(DOM.Rule rule)
        {
            var dbValue = _db.Rules.FirstOrDefault(r => r.Id == rule.Id);
            if (dbValue == null) return;
            _db.Rules.Remove(dbValue);
            _db.SaveChanges();
        }

        public void CreateValue(DOM.Value value)
        {
            var dbVal = _mapper.Map(value, new DAL.Value());
            dbVal.DeviceId = value.Device.Id;


            try
            {
                _db.Values.Add(dbVal);
                _db.SaveChanges();

                DebugOutput.Print($"Communicator #{value.Device.Id}'s new value, '{value.StringValue}', was captured!");
            }
            catch (Exception)
            {
                var msg = $"Communicator #{value.Device.Id}'s new value, '{value.StringValue}', could not be captured!";
                DebugOutput.Print("Could not store the new value!", msg);
            }
        }

        public DOM.Value RetrieveValue(int id)
        {
            return _mapper.Map(_db.Values.FirstOrDefault(v => v.Id == id), new DOM.Value());
        }

        public IEnumerable<DOM.Value> RetrieveValuesForDevice(int deviceId)
        {
            return _db.Values.Where(v => v.DeviceId == deviceId).Select(v => _mapper.Map(v, new DOM.Value())).ToList();
        }

        public IEnumerable<DOM.Value> RetrieveAllValues()
        {
            return _db.Values.Select(v => _mapper.Map(v, new DOM.Value())).ToList();
        }

        public void UpdateValue(DOM.Value value)
        {
            var dbValue = _db.Values.FirstOrDefault(v => v.Id == value.Id);
            if (dbValue == null) return;
            _mapper.Map(value, dbValue);
            _db.Entry(dbValue).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public void DeleteValue(DOM.Value value)
        {
            var dbValue = _db.Values.FirstOrDefault(v => v.Id == value.Id);
            if (dbValue == null) return;
            _db.Values.Remove(dbValue);
            _db.SaveChanges();
        }

        public DOM.AppData GetApplicationInformation()
        {
            return _mapper.Map(_db.AppData.First(), new DOM.AppData());
        }

        public void SetApplicationInformation(DOM.AppData ai)
        {
            var dbValue = _db.AppData.First();
            if (dbValue == null)
            {
                _db.AppData.Add(_mapper.Map(ai, new DAL.AppData()));
            }
            else
            {
                dbValue = _mapper.Map(ai, new DAL.AppData());
            }

            _db.SaveChanges();
        }


        ///
        /// Methods below this point are PRIVATE and are used as 'helper methods'
        /// for this class only. 
        /// 
        /// <summary>
        /// Used to iteratively go through a list of communicator objects and convert them to Domain models.
        /// </summary>
        /// <param name="communicators">DAL Communicators.</param>
        /// <returns>DOM Communicators.</returns>
        private IEnumerable<DOM.Communicator> ConvertDALCommunicatorsToDOM(IEnumerable<DAL.Communicator> communicators)
        {
            return communicators.Select(ConvertDALCommunicatorToDOM).ToList();
        }

        /// <summary>
        /// Converts a single DAL Communicator to DOM.
        /// </summary>
        /// <param name="communicator">DAL Communicator.</param>
        /// <returns>DOM Communicator.</returns>
        private DOM.Communicator ConvertDALCommunicatorToDOM(DAL.Communicator communicator)
        {
            switch (communicator.Type)
            {
                case DAL.CommunicatorType.Database:
                    return (_mapper.Map(communicator, new DOM.DatabaseCommunicator()));
                case DAL.CommunicatorType.Serial:
                    return (_mapper.Map(communicator, new DOM.SerialCommunicator()));
                case DAL.CommunicatorType.FlatFile:
                    return (_mapper.Map(communicator, new DOM.FileCommunicator()));
                default:
                    DebugOutput.Print("Unable to convert/understand Communicator...", communicator.Id.ToString());
                    return null;
            }
        }
    }
}