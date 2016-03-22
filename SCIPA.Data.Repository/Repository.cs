using System.Collections.Generic;
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
        //readonly DAL.DataController _db = new AccessLayer.DataController();
        readonly DAL.SCIPAEntities _db = new DAL.SCIPAEntities();


        /// <summary>
        /// Automapper object to map between DAL and DOM models.
        /// </summary>
        private readonly IMapper _mapper;

        public Repository()
        {
            // Configure AutoMapper for update operations.
            _mapper = new MapperConfiguration(cfg =>
            {
                // Leave out navigation properties.
                cfg.CreateMap<DAL.Action, DOM.Action>()
                    .ForMember(m => m.Id, opt => opt.Ignore())
                    .ForMember(m => m.Device, opt => opt.Ignore());

                // Leave out navigation property.
                cfg.CreateMap<DAL.AppData, DOM.AppData>();

                // Leave out navigation property.
                cfg.CreateMap<DAL.Communicator, DOM.Communicator>()
                    .ForMember(m => m.Id, opt => opt.Ignore())
                    .ForMember(m => m.Device, opt => opt.Ignore());

                // Leave out navigation property.
                cfg.CreateMap<DAL.CommunicatorType, DOM.CommunicatorType>();

                // Leave out navigation properties.
                cfg.CreateMap<DAL.DatabaseCommunicator, DOM.DatabaseCommunicator>();

                // Leave out navigation properties.
                cfg.CreateMap<DAL.SerialCommunicator, DOM.SerialCommunicator>();

                // Leave out navigation properties.
                cfg.CreateMap<DAL.FileCommunicator, DOM.FileCommunicator>();

                // Leave out navigation properties.
                cfg.CreateMap<DAL.Device, DOM.Device>()
                .ForMember(m=>m.Id,opt=>opt.Ignore())
                .ForMember(m=>m.Actions, opt=>opt.Ignore())
                .ForMember(m=>m.Writer, opt=>opt.Ignore())
                .ForMember(m=>m.Reader, opt=>opt.Ignore())
                .ForMember(m=>m.Rules,opt=>opt.Ignore())
                .ForMember(m=>m.InboundValues, opt=>opt.Ignore())
                .ForMember(m=>m.OutboundValues, opt=>opt.Ignore());

                // Leave out navigation properties.
                cfg.CreateMap<DAL.Rule, DOM.Rule>()
                    .ForMember(m => m.Id, opt => opt.Ignore())
                    .ForMember(m=>m.Device,opt=>opt.Ignore());

                // Leave out navigation properties.
                cfg.CreateMap<DAL.RuleType, DOM.RuleType>();

                // Leave out navigation properties.
                cfg.CreateMap<DAL.Value, DOM.Value>()
                    .ForMember(m => m.Id, opt => opt.Ignore())
                    .ForMember(m=>m.Device,opt=>opt.Ignore());

                // Leave out navigation properties.
                cfg.CreateMap<DOM.ValueType, DOM.ValueType>();
            }).CreateMapper();
        }

        public void CreateDevice(DOM.Device device)
        {
            using (var db = new DAL.SCIPAEntities())
            {
                _db.Devices.Add(_mapper.Map(device, new DAL.Device()));
                db.SaveChanges();
            }
        }

        public DOM.Device RetrieveDevice(int id)
        {
            return _mapper.Map(_db.Devices.FirstOrDefault(dev => dev.Id == id), new DOM.Device());
        }

        public ICollection<DOM.Device> RetrieveAllDevices()
        {
            return _db.Devices.Select(device => _mapper.Map(device, new DOM.Device())).ToList();
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
        }

        public DOM.Action RetrieveAction(int id)
        {
            return _mapper.Map(_db.Actions.FirstOrDefault(act => act.Id == id), new DOM.Action());
        }

        public ICollection<DOM.Action> RetrieveActionsForDevice(int deviceId)
        {
            return _db.Actions.Where(act => act.DeviceId == deviceId).Select(act => _mapper.Map(act, new DOM.Action())).ToList();
        }

        public ICollection<DOM.Action> RetrieveAllActions()
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
        }

        public void CreateDatabaseCommunicator(DOM.DatabaseCommunicator databaseCommunicator)
        {
            _db.Communicators.Add(_mapper.Map(databaseCommunicator, new DAL.DatabaseCommunicator()));
        }

        public void UpdateDatabaseCommunicator(DOM.DatabaseCommunicator databaseCommunicator)
        {
            var dbValue = _db.Communicators.FirstOrDefault(comm => comm.Id == databaseCommunicator.Id);

        }

        public void DeleteDatabaseCommunicator(DOM.DatabaseCommunicator databaseCommunicator)
        {
            throw new System.NotImplementedException();
        }

        public void CreateFileCommunicator(DOM.FileCommunicator fileCommunicator)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateFileCommunicator(DOM.FileCommunicator fileCommunicator)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteFileCommunicator(DOM.FileCommunicator fileCommunicator)
        {
            throw new System.NotImplementedException();
        }

        public void CreateSerialCommunicator(DOM.SerialCommunicator serialCommunicator)
        {
            throw new System.NotImplementedException();
        }

        public DOM.Communicator RetrieveCommunicator(int id)
        {
            var dbValue = _db.Communicators.FirstOrDefault(comm => comm.Id == id);
            if (dbValue == null) return null;
            return ConvertDALCommunicatorsToDOM(dbValue);
        }

        public ICollection<DOM.Communicator> RetrieveCommunicatorsForDevice(int deviceId)
        {
            return ConvertDALCommunicatorsToDOM(_db.Communicators.Where(comm => comm.Device.Id == deviceId)).ToList();
        }

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
                    DebugOutput.Print("Unable to convert/understand Communicator...",communicator.Id.ToString());
                    return null;
            }
        }

        public ICollection<DOM.Communicator> RetrieveAllCommunicators()
        {
            return ConvertDALCommunicatorsToDOM(_db.Communicators).ToList();
        }

        public void UpdateSerialCommunicator(DOM.SerialCommunicator serialCommunicator)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteSerialCommunicator(DOM.SerialCommunicator serialCommunicator)
        {
            throw new System.NotImplementedException();
        }

        public void CreateRule(DOM.Rule rule)
        {
            throw new System.NotImplementedException();
        }

        public DOM.Rule RetrieveRule(int id)
        {
            throw new System.NotImplementedException();
        }

        public ICollection<DOM.Rule> RetrieveRulesForDevice(int deviceId)
        {
            throw new System.NotImplementedException();
        }

        public ICollection<DOM.Rule> RetrieveAllRules()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateRule(DOM.Rule rule)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteRule(DOM.Rule rule)
        {
            throw new System.NotImplementedException();
        }

        public void CreateValue(DOM.Value value)
        {
            throw new System.NotImplementedException();
        }

        public DOM.Value RetrieveValue(int id)
        {
            throw new System.NotImplementedException();
        }

        public ICollection<DOM.Value> RetrieveValuesForDevice(int deviceId)
        {
            throw new System.NotImplementedException();
        }

        public ICollection<DOM.Value> RetrieveAllValues()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateValue(DOM.Value value)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteValue(DOM.Value value)
        {
            throw new System.NotImplementedException();
        }

        public DOM.AppData GetApplicationInformation()
        {
            throw new System.NotImplementedException();
        }

        public void SetApplicationInformation(DOM.AppData ai)
        {
            throw new System.NotImplementedException();
        }
    }
}