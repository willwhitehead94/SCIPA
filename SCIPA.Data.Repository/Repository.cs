using System.Collections.Generic;
using AutoMapper;
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
        readonly DAL.DataController _db = new AccessLayer.DataController();
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
            throw new System.NotImplementedException();
        }

        public DOM.Device RetrieveDevice(int id)
        {
            _db.
        }

        public ICollection<DOM.Device> RetrieveAllDevices()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateDevice(DOM.Device device)
        {
            throw new System.NotImplementedException();
        }

        public void DisableDevice(DOM.Device device)
        {
            throw new System.NotImplementedException();
        }

        public void CreateOrUpdateDevice(DOM.Device device)
        {
            throw new System.NotImplementedException();
        }

        public void CreateAction(DOM.Action action)
        {
            throw new System.NotImplementedException();
        }

        public DOM.Action RetrieveAction(int id)
        {
            throw new System.NotImplementedException();
        }

        public ICollection<DOM.Action> RetrieveActionsForDevice(int deviceId)
        {
            throw new System.NotImplementedException();
        }

        public ICollection<DOM.Action> RetrieveAllActions()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateAction(DOM.Action action)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteAction(DOM.Action action)
        {
            throw new System.NotImplementedException();
        }

        public void CreateDatabaseCommunicator(DOM.DatabaseCommunicator databaseCommunicator)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateDatabaseCommunicator(DOM.DatabaseCommunicator databaseCommunicator)
        {
            throw new System.NotImplementedException();
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
            throw new System.NotImplementedException();
        }

        public ICollection<DOM.Communicator> RetrieveCommunicatorsForDevice(int deviceId)
        {
            throw new System.NotImplementedException();
        }

        public ICollection<DOM.Communicator> RetrieveAllCommunicators()
        {
            throw new System.NotImplementedException();
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