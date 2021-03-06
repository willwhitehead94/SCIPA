﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using AutoMapper;
using SCIPA.Data.Repository.Properties;
using SCIPA.Domain.Generic;
using DAL = SCIPA.Data.AccessLayer;
using DOM = SCIPA.Models;

namespace SCIPA.Data.Repository
{
    /// <summary>
    /// Application facing class for the relational database. Allows the application to interact
    /// with the SQL database without any requirement of repeated knowledge as to the 
    /// collection, the documents or the entities used within it.
    /// </summary>
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

                cfg.CreateMap<DOM.Alarm, DAL.Alarm>()
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
                    .ForMember(m => m.Device, opt => opt.Ignore());

                cfg.CreateMap<DOM.RuleType, DAL.RuleType>();

                cfg.CreateMap<DOM.Value, DAL.Value>()
                    .ForMember(m => m.Id, opt => opt.Ignore());

                cfg.CreateMap<DAL.ValueType, DAL.ValueType>();








                // Data to Domain Converstions
                cfg.CreateMap<DAL.Action, DOM.Action>();

                cfg.CreateMap<DAL.Alarm, DOM.Alarm>();

                cfg.CreateMap<DAL.AppData, DOM.AppData>();

                cfg.CreateMap<DAL.Communicator, DOM.Communicator>()
                    .ForMember(m => m.Id, opt => opt.Ignore())
                    .ForMember(m => m.Device, opt => opt.Ignore())
                    .ForMember(m => m.Action, opt => opt.Ignore());

                cfg.CreateMap<DAL.CommunicatorType, DOM.CommunicatorType>();

                cfg.CreateMap<DAL.DatabaseCommunicator, DOM.DatabaseCommunicator>();

                cfg.CreateMap<DAL.SerialCommunicator, DOM.SerialCommunicator>();

                cfg.CreateMap<DAL.FileCommunicator, DOM.FileCommunicator>();

                cfg.CreateMap<DAL.Device, DOM.Device>()
                    .ForMember(m => m.Rules, opt => opt.Ignore());

                cfg.CreateMap<DAL.Rule, DOM.Rule>()
                    //.ForMember(m => m.Id, opt => opt.Ignore())
                    .ForMember(m => m.Device, opt => opt.Ignore())
                    .ForMember(m => m.Action, opt => opt.Ignore());

                cfg.CreateMap<DAL.RuleType, DOM.RuleType>();

                cfg.CreateMap<DAL.Value, DOM.Value>();

                cfg.CreateMap<DOM.ValueType, DOM.ValueType>();

            }).CreateMapper();
        }

        /// <summary>
        /// Creates a new Device object within the database.
        /// </summary>
        /// <param name="device"></param>
        public DOM.Device CreateDevice(DOM.Device device)
        {
            var dbVal = _mapper.Map(device, new DAL.Device());
            _db.Devices.Add(dbVal);
            _db.SaveChanges();

            //Update MongoDB accordingly
            var mongorepo = new MongoRepository();
            mongorepo.AddNewDevice(device);
            //MongoDB Updated!

            return _mapper.Map(dbVal, new DOM.Device());
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
            return _db.Devices.ToList().Select(device => _mapper.Map(device, new DOM.Device()));
        }

        /// <summary>
        /// Updates the database copy of the parametised domain model.
        /// </summary>
        /// <param name="device"></param>
        public DOM.Device UpdateDevice(DOM.Device device)
        {
            var dbCurrent = _db.Devices.FirstOrDefault(dev => dev.Id == device.Id);
            _mapper.Map(device, dbCurrent);

            _db.Entry(dbCurrent).State=EntityState.Modified;
            _db.SaveChanges();

            return _mapper.Map(dbCurrent, new DOM.Device());
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
        public DOM.Device CreateOrUpdateDevice(DOM.Device device)
        {
            var dbValue = RetrieveDevice(device.Id);
            if (dbValue == null)
            {
                return CreateDevice(device);
            }
            else
            {
                return UpdateDevice(device);
            }
        }

        /// <summary>
        /// Creates a new Action object within the database.
        /// </summary>
        /// <param name="action"></param>
        public DOM.Action CreateAction(DOM.Action action)
        {
            var dbVal = (_mapper.Map(action, new DAL.Action()));

            _db.Actions.Add(dbVal);
            _db.SaveChanges();

            return _mapper.Map(dbVal, new DOM.Action());
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
        /// Returns all/any rules associated with a given Rule.
        /// </summary>
        /// <param name="ruleId"></param>
        /// <returns></returns>
        public IEnumerable<DOM.Action> RetrieveActionsForRule(int ruleId)
        { 
            var temp = _db.Actions.Where(a => a.RuleId == ruleId);
            List<DOM.Action> returnList = new List<DOM.Action>();
            foreach (var act in temp)
            {
                returnList.Add(_mapper.Map(act, new DOM.Action()));
            }

            return returnList;
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
        public DOM.Action UpdateAction(DOM.Action action)
        {
            var dbAction = _db.Actions.FirstOrDefault(act => act.Id == action.Id);

            if (dbAction == null) return null;

            var newAction = _mapper.Map(action, new DAL.Action());

            _mapper.Map(newAction, dbAction);
            dbAction.OutputValue = newAction.OutputValue;

            _db.SaveChanges();
            return _mapper.Map(dbAction, new DOM.Action());
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

        /// <summary>
        /// Updates the Communicator as housed on the database.
        /// </summary>
        /// <param name="communicator"></param>
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

        /// <summary>
        /// Retrieves a single Communicator object as per the Communicator's ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DOM.Communicator RetrieveCommunicator(int id)
        {
            var dbValue = _db.Communicators.FirstOrDefault(comm => comm.Id == id);
            if (dbValue == null) return null;
            return ConvertDALCommunicatorToDOM(dbValue);
        }

        /// <summary>
        /// Returns all Communicator objects for the given Device via the Device Id.
        /// </summary>
        /// <param name="deviceId"></param>
        /// <returns></returns>
        public IEnumerable<DOM.Communicator> RetrieveCommunicatorsForDevice(int deviceId)
        {
            return ConvertDALCommunicatorsToDOM(_db.Communicators.Where(comm => comm.Device.Id == deviceId)).ToList();
        }

        /// <summary>
        /// Returns all Communicator objects from the database.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<DOM.Communicator> RetrieveAllCommunicators()
        {
            return ConvertDALCommunicatorsToDOM(_db.Communicators).ToList();
        }

        /// <summary>
        /// Creates a new instance of a Rule object. The returned
        /// object includes all created Identity information.
        /// </summary>
        /// <param name="rule"></param>
        /// <returns></returns>
        public DOM.Rule CreateRule(DOM.Rule rule)
        {
            //Map to DAL object.
            var dbVal = _mapper.Map(rule, new DAL.Rule());

            //The Device does not need individual mapping for Rules.

            try
            {
                //Save to Database.
                _db.Rules.Add(dbVal);

                //Save the changes made to the database.
                _db.SaveChanges();

                //Return the updated Domain object.
                return _mapper.Map(dbVal, new DOM.Rule());
            }
            catch (Exception e)
            {
                //Report fault back up the chain.
                DebugOutput.Print("Rule insertion to database failed. ", e.Message);
            }

            //Return null on failure.
            return null;
        }

        /// <summary>
        /// Retrieves a single Rule object based on the ID of the Rule.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DOM.Rule RetrieveRule(int id)
        {
            return _mapper.Map(_db.Rules.FirstOrDefault(rule => rule.Id == id), new DOM.Rule());
        }

        /// <summary>
        /// Returns all Rules associated to a Device via the given Device
        /// Id.
        /// </summary>
        /// <param name="deviceId"></param>
        /// <returns></returns>
        public IEnumerable<DOM.Rule> RetrieveRulesForDevice(int deviceId)
        {
            return _db.Rules.Where(rule => rule.DeviceId == deviceId).Select(rule => _mapper.Map(rule, new DOM.Rule())).ToList();
        }

        /// <summary>
        /// Returns all Rules on the database.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<DOM.Rule> RetrieveAllRules()
        {
            return _db.Rules.ToList().Select(rule => _mapper.Map(rule, new DOM.Rule()));
        }

        /// <summary>
        /// Updates the Rule object on the database, the returned
        /// object includes all created Identity information.
        /// </summary>
        /// <param name="rule"></param>
        /// <returns></returns>
        public DOM.Rule UpdateRule(DOM.Rule rule)
        {
            var dbVal = _db.Rules.FirstOrDefault(r => r.Id == rule.Id);
            if (dbVal == null) return null;
            _mapper.Map(rule, dbVal);
            _db.Entry(dbVal).State = EntityState.Modified;
            _db.SaveChanges();

            //Return the updated Domain object.
            return _mapper.Map(dbVal, new DOM.Rule());
        }

        /// <summary>
        /// Removes the Rule from the database.
        /// </summary>
        /// <param name="rule"></param>
        public void DeleteRule(DOM.Rule rule)
        {
            var dbValue = _db.Rules.FirstOrDefault(r => r.Id == rule.Id);
            if (dbValue == null) return;
            _db.Rules.Remove(dbValue);
            _db.SaveChanges();
        }

        /// <summary>
        /// Creates a new Value object on the database. The returned
        /// object includes all created Identity information.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public DOM.Value CreateValue(DOM.Value value)
        {
            var dbVal = _mapper.Map(value, new DAL.Value());
            dbVal.DeviceId = value.Device.Id;

            try
            {
                _db.Values.Add(dbVal);
                _db.SaveChanges();

                DebugOutput.Print($"Communicator #{dbVal.DeviceId}'s new value, '{dbVal.StringValue}', was captured!");

                return _mapper.Map(dbVal, new DOM.Value());
            }
            catch (Exception)
            {
                var msg = $"Communicator #{value.Device.Id}'s new value, '{value.StringValue}', could not be captured!";
                DebugOutput.Print("Could not store the new value!", msg);
            }

            //Return null on fail.
            return null;
        }

        /// <summary>
        /// Returns a single Value object from the database
        /// based upon the ID for that Value.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DOM.Value RetrieveValue(int id)
        {
            return _mapper.Map(_db.Values.FirstOrDefault(v => v.Id == id), new DOM.Value());
        }

        /// <summary>
        /// Returns all Values on the database for the given Device
        /// via the Device's Id.
        /// </summary>
        /// <param name="deviceId"></param>
        /// <returns></returns>
        public IEnumerable<DOM.Value> RetrieveValuesForDevice(int deviceId)
        {
            return _db.Values.Where(v => v.DeviceId == deviceId).Select(v => _mapper.Map(v, new DOM.Value())).ToList();
        }

        /// <summary>
        /// Returns all Values on the database for all Devices.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<DOM.Value> RetrieveAllValues()
        {
            return _db.Values.Select(v => _mapper.Map(v, new DOM.Value())).ToList();
        }

        /// <summary>
        /// Updates the Value object on the database.
        /// </summary>
        /// <param name="value"></param>
        public void UpdateValue(DOM.Value value)
        {
            var dbValue = _db.Values.FirstOrDefault(v => v.Id == value.Id);
            if (dbValue == null) return;
            _mapper.Map(value, dbValue);
            _db.Entry(dbValue).State = EntityState.Modified;
            _db.SaveChanges();
        }

        /// <summary>
        /// Removes the single Value from the database, if it exists.
        /// </summary>
        /// <param name="value"></param>
        public void DeleteValue(DOM.Value value)
        {
            var dbValue = _db.Values.FirstOrDefault(v => v.Id == value.Id);
            if (dbValue == null) return;
            _db.Values.Remove(dbValue);
            _db.SaveChanges();
        }

        /// <summary>
        /// Get's the App Data as stored on the database.
        /// </summary>
        /// <returns></returns>
        public DOM.AppData GetApplicationInformation()
        {
            return _mapper.Map(_db.AppData.First(), new DOM.AppData());
        }

        /// <summary>
        /// Set the App Data for future use.
        /// </summary>
        /// <param name="ai"></param>
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

        /// <summary>
        /// Creates a new Alarm object on the database. The returned
        /// object includes all created Identity information.
        /// </summary>
        /// <param name="alarm"></param>
        /// <returns></returns>
        public DOM.Alarm CreateAlarm(DOM.Alarm alarm)
        {
            //Convert the main Alarm object.
            var dbVal = _mapper.Map(alarm, new DAL.Alarm());

            //Create a new Globally Unique Identifier.
            //dbVal.Id = Guid.NewGuid();

            //Add the Alarm object to the Entity Context and Save changes to the Online Store.
            _db.Alarms.Add(dbVal);
            _db.SaveChanges();

            //Return the new Alarm.
            return _mapper.Map(dbVal, new DOM.Alarm());
        }

        /// <summary>
        /// Returns all Alarms on the database.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<DOM.Alarm> RetrieveAlarms()
        {
            try
            {
                //Use unique context as always required live data.
                using (var context = new DAL.SCIPAEntities())
                {
                    var alarms = context.Alarms.ToList();
                    return alarms.Select(alarm => _mapper.Map(alarm, new DOM.Alarm())).ToList();
                }
            }
            catch
            {
                DebugOutput.Print("Failed to update alarm data.");
                return null;
            }
        }

        /// <summary>
        /// Returns all the Alarm objects on the database
        /// for the given Device via the Device's Id.
        /// </summary>
        /// <param name="deviceId"></param>
        /// <returns></returns>
        public IEnumerable<DOM.Alarm> RetrieveAlarmsForDevice(int deviceId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns all the Alarm objects on the database for the 
        /// given Rule via the Rule's Id.
        /// </summary>
        /// <param name="ruleId"></param>
        /// <returns></returns>
        public IEnumerable<DOM.Alarm> RetrieveAlarmsForRule(int ruleId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates the Alarm object on the database.
        /// </summary>
        /// <param name="alarm"></param>
        /// <returns></returns>
        public DOM.Alarm UpdateAlarm(DOM.Alarm alarm)
        {
            var dbCurrent = _db.Alarms.FirstOrDefault(alm => alm.Id == alarm.Id);
            _mapper.Map(alarm, dbCurrent);

            _db.Entry(dbCurrent).State = EntityState.Modified;
            _db.SaveChanges();

            return _mapper.Map(dbCurrent, new DOM.Alarm());
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


        /// <summary>
        /// Converts a single DOM Communicator to DAL.
        /// </summary>
        /// <param name="communicator">DOM Communicator.</param>
        /// <returns>DAL Communicator.</returns>
        private DAL.Communicator ConvertDOMCommunicatorToDAL(DOM.Communicator communicator)
        {
            switch (communicator.Type)
            {
                case DOM.CommunicatorType.Database:
                    return (_mapper.Map(communicator, new DAL.DatabaseCommunicator()));
                case DOM.CommunicatorType.Serial:
                    return (_mapper.Map(communicator, new DAL.SerialCommunicator()));
                case DOM.CommunicatorType.FlatFile:
                    return (_mapper.Map(communicator, new DAL.FileCommunicator()));
                default:
                    DebugOutput.Print("Unable to convert/understand Communicator...", communicator.Id.ToString());
                    return null;
            }
        }

        /// <summary>
        /// Executes the ResetDatabaseScript - deleting all data from the database!
        /// </summary>
        public static void ClearSql()
        {
            //Use unique context as always required live data.
            using (var context = new DAL.SCIPAEntities())
            {
                context.Database.Delete();
                context.Database.Create();
               // context.Database.ExecuteSqlCommand(@Resources.ResetDatabaseScript);
            }
        }
    }
}