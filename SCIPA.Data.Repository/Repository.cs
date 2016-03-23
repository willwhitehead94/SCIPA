using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using AutoMapper;
using SCIPA.Domain.Generic;
using DAL = SCIPA.Data.AccessLayer;
using DOM = SCIPA.Models;

namespace SCIPA.Data.Repository
{
    public class Repository : IRepository
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

        public Repository()
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
                    .ForMember(m => m.Id, opt => opt.Ignore())
                    .ForMember(m => m.Device, opt => opt.Ignore());

                cfg.CreateMap<DOM.AppData, DAL.AppData>();

                cfg.CreateMap<DOM.Communicator, DAL.Communicator>()
                    .ForMember(m => m.Id, opt => opt.Ignore())
                    .ForMember(m => m.Devices, opt => opt.Ignore());

                cfg.CreateMap<DOM.CommunicatorType, DAL.CommunicatorType>();

                cfg.CreateMap<DOM.DatabaseCommunicator, DAL.DatabaseCommunicator>();

                cfg.CreateMap<DOM.SerialCommunicator, DAL.SerialCommunicator>();

                cfg.CreateMap<DOM.FileCommunicator, DAL.FileCommunicator>();

                cfg.CreateMap<DOM.Device, DAL.Device>()
                .ForMember(m => m.Id, opt => opt.Ignore())
                .ForMember(m => m.Actions, opt => opt.Ignore())
                .ForMember(m => m.Writer, opt => opt.Ignore())
                .ForMember(m => m.Reader, opt => opt.Ignore())
                .ForMember(m => m.Rules, opt => opt.Ignore())
                .ForMember(m => m.InboundValues, opt => opt.Ignore())
                .ForMember(m => m.OutboundValues, opt => opt.Ignore());

                cfg.CreateMap<DOM.Rule, DAL.Rule>()
                    .ForMember(m => m.Id, opt => opt.Ignore())
                    .ForMember(m=>m.Device,opt=>opt.Ignore());

                cfg.CreateMap<DOM.RuleType, DAL.RuleType>();

                cfg.CreateMap<DOM.Value, DAL.Value>()
                    .ForMember(m => m.Id, opt => opt.Ignore())
                    .ForMember(m=>m.Device,opt=>opt.Ignore());

                cfg.CreateMap<DAL.ValueType, DAL.ValueType>();








                // Domain to Data Converstions
                cfg.CreateMap<DAL.Action, DOM.Action>()
                    .ForMember(m => m.Device, opt => opt.Ignore());

                cfg.CreateMap<DAL.AppData, DOM.AppData>();

                cfg.CreateMap<DAL.Communicator, DOM.Communicator>()
                    .ForMember(m => m.Device, opt => opt.Ignore());

                cfg.CreateMap<DAL.CommunicatorType, DOM.CommunicatorType>();

                cfg.CreateMap<DAL.DatabaseCommunicator, DOM.DatabaseCommunicator>();

                cfg.CreateMap<DAL.SerialCommunicator, DOM.SerialCommunicator>();

                cfg.CreateMap<DAL.FileCommunicator, DOM.FileCommunicator>();

                cfg.CreateMap<DAL.Device, DOM.Device>()
                .ForMember(m => m.Actions, opt => opt.Ignore())
                .ForMember(m => m.Writer, opt => opt.Ignore())
                .ForMember(m => m.Reader, opt => opt.Ignore())
                .ForMember(m => m.Rules, opt => opt.Ignore())
                .ForMember(m => m.InboundValues, opt => opt.Ignore())
                .ForMember(m => m.OutboundValues, opt => opt.Ignore());

                cfg.CreateMap<DAL.Rule, DOM.Rule>()
                    .ForMember(m => m.Device, opt => opt.Ignore());

                cfg.CreateMap<DAL.RuleType, DOM.RuleType>();

                cfg.CreateMap<DAL.Value, DOM.Value>()
                    .ForMember(m => m.Device, opt => opt.Ignore());

                cfg.CreateMap<DAL.ValueType, DOM.ValueType>();

            }).CreateMapper();
        }

        public void CreateDevice(DOM.Device device)
        {
            _db.Devices.Add(_mapper.Map(device, new DAL.Device()));
            _db.SaveChanges();
        }

        public DOM.Device RetrieveDevice(int id)
        {
            return _mapper.Map(_db.Devices.FirstOrDefault(dev => dev.Id == id), new DOM.Device());
        }

        public IEnumerable<DOM.Device> RetrieveAllDevices()
        {
            DAL.Device dal = _db.Devices.First();
            DOM.Device dom = new DOM.Device();

            _mapper.Map<DAL.Device, DOM.Device>(dal, dom);
            dom = _mapper.Map<DAL.Device, DOM.Device>(dal, dom);

            return _db.Devices.ToList().Select(device => _mapper.Map(device, new DOM.Device()));
        }

        public void UpdateDevice(DOM.Device device)
        {
            var dbValue = RetrieveDevice(device.Id);
            if (dbValue == null) return;
            dbValue = device;
            _db.SaveChanges();
        }

        public void DisableDevice(DOM.Device device)
        {
            var dbValue = RetrieveDevice(device.Id);
            if (dbValue == null) return;
            _db.Devices.Remove(_mapper.Map(dbValue,new DAL.Device()));
            _db.SaveChanges();
        }

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

        public void CreateAction(DOM.Action action)
        {
            _db.Actions.Add(_mapper.Map(action, new DAL.Action()));
            _db.SaveChanges();
        }

        public DOM.Action RetrieveAction(int id)
        {
            return _mapper.Map(_db.Actions.FirstOrDefault(act => act.Id == id), new DOM.Action());
        }

        public IEnumerable<DOM.Action> RetrieveActionsForDevice(int deviceId)
        {
            return _db.Actions.Where(act => act.DeviceId == deviceId).Select(act => _mapper.Map(act, new DOM.Action())).ToList();
        }

        public IEnumerable<DOM.Action> RetrieveAllActions()
        {
            return _db.Actions.Select(act => _mapper.Map(act, new DOM.Action())).ToList();
        }

        public void UpdateAction(DOM.Action action)
        {
            var dbValue = RetrieveAction(action.Id);
            if (dbValue == null) return;
            dbValue = _mapper.Map(action, new DOM.Action());
            _db.SaveChanges();
        }

        public void DeleteAction(DOM.Action action)
        {
            var dbValue = RetrieveAction(action.Id);
            if (dbValue == null) return;
            _db.Actions.Remove(_mapper.Map(action, new DAL.Action()));
            _db.SaveChanges();
        }

        public void CreateDatabaseCommunicator(DOM.DatabaseCommunicator databaseCommunicator)
        {
            _db.Communicators.Add(_mapper.Map(databaseCommunicator, new DAL.DatabaseCommunicator()));
        }

        public void UpdateDatabaseCommunicator(DOM.DatabaseCommunicator databaseCommunicator)
        {
            var dbValue = _db.Communicators.FirstOrDefault(comm => comm.Id == databaseCommunicator.Id);
            if (dbValue == null) return;
            dbValue = _mapper.Map(databaseCommunicator, new DAL.DatabaseCommunicator());
            _db.SaveChanges();
        }

        public void DeleteDatabaseCommunicator(DOM.DatabaseCommunicator databaseCommunicator)
        {
            var dbValue = RetrieveCommunicator(databaseCommunicator.Id);
            if (dbValue == null) return;
            _db.Communicators.Remove(_mapper.Map(databaseCommunicator, new DAL.DatabaseCommunicator()));
            _db.SaveChanges();
        }

        public void CreateFileCommunicator(DOM.FileCommunicator fileCommunicator)
        {
            var model = _mapper.Map(fileCommunicator, new DAL.FileCommunicator());

            //model.Device.Writer = model;

            _db.Communicators.Add(model);
            _db.SaveChanges();
        }

        public void UpdateFileCommunicator(DOM.FileCommunicator fileCommunicator)
        {
            var dbValue = _db.Communicators.FirstOrDefault(comm => comm.Id == fileCommunicator.Id);
            if (dbValue == null) return;
            dbValue = _mapper.Map(fileCommunicator, new DAL.FileCommunicator());
            _db.SaveChanges();
        }

        public void DeleteFileCommunicator(DOM.FileCommunicator fileCommunicator)
        {
            var dbValue = RetrieveCommunicator(fileCommunicator.Id);
            if (dbValue == null) return;
            _db.Communicators.Remove(_mapper.Map(fileCommunicator, new DAL.FileCommunicator()));
            _db.SaveChanges();
        }

        public void CreateSerialCommunicator(DOM.SerialCommunicator serialCommunicator)
        {
            _db.Communicators.Add(_mapper.Map(serialCommunicator, new DAL.SerialCommunicator()));
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
            return ConvertDALCommunicatorsToDOM(_db.Communicators.Where(comm => comm.Devices.Any(dev=>dev.Id==deviceId))).ToList();
        }

        public IEnumerable<DOM.Communicator> RetrieveAllCommunicators()
        {
            return ConvertDALCommunicatorsToDOM(_db.Communicators).ToList();
        }

        public void UpdateSerialCommunicator(DOM.SerialCommunicator serialCommunicator)
        {
            var dbValue = _db.Communicators.FirstOrDefault(comm => comm.Id == serialCommunicator.Id);
            if (dbValue == null) return;
            dbValue = _mapper.Map(serialCommunicator, new DAL.SerialCommunicator());
            _db.SaveChanges();
        }

        public void DeleteSerialCommunicator(DOM.SerialCommunicator serialCommunicator)
        {
            var dbValue = RetrieveCommunicator(serialCommunicator.Id);
            if (dbValue == null) return;
            _db.Communicators.Remove(_mapper.Map(serialCommunicator, new DAL.SerialCommunicator()));
            _db.SaveChanges();
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
            var dbValue = _db.Rules.FirstOrDefault(r=> r.Id==rule.Id);
            if (dbValue == null) return;
            dbValue = _mapper.Map(rule, new DAL.Rule());
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
            _db.Values.Add(_mapper.Map(value, new DAL.Value()));
            _db.SaveChanges();
        }

        public DOM.Value RetrieveValue(int id)
        {
            return _mapper.Map(_db.Values.FirstOrDefault(v => v.Id == id), new DOM.Value());
        }

        public IEnumerable<DOM.Value> RetrieveValuesForDevice(int deviceId)
        {
            return _db.Values.Where(v => v.Device.Id == deviceId).Select(v => _mapper.Map(v, new DOM.Value())).ToList();
        }

        public IEnumerable<DOM.Value> RetrieveAllValues()
        {
            return _db.Values.Select(v => _mapper.Map(v, new DOM.Value())).ToList();
        }

        public void UpdateValue(DOM.Value value)
        {
            var dbValue = _db.Values.FirstOrDefault(v => v.Id == value.Id);
            if (dbValue == null) return;
            dbValue = _mapper.Map(value, new DAL.Value());
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
            return communicators.Select(comm => ConvertDALCommunicatorToDOM(comm)).ToList();
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