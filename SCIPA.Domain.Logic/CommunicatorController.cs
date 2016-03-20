using System;
using System.Collections.Generic;
using System.Linq;
using SCIPA.Data.Repository;
using SCIPA.Domain.Generic;
using SCIPA.Models;

namespace SCIPA.Domain.Logic
{
    public class CommunicatorController
    { 
        private readonly DataRepository _repo = new DataRepository();

        /// <summary>
        /// Returns collection of all File Communicators in the database.
        /// </summary>
        /// <returns></returns>
        public ICollection<FileCommunicator> GetAllFileCommunicators()
        {
            return _repo.RetrieveAllFileCommunicators();
        }

        /// <summary>
        /// Returns collection of all Database Communicators in the database.
        /// </summary>
        /// <returns></returns>
        public ICollection<DatabaseCommunicator> GetAllDatabaseCommunicators()
        {
            return _repo.RetrieveAllDatabaseCommunicators();
        }

        /// <summary>
        /// Returns collection of all Serial Communicators in the database.
        /// </summary>
        /// <returns></returns>
        public ICollection<SerialCommunicator> GetAllSerialCommunicators()
        {
            return _repo.RetrieveAllSerialCommunicators();
        }

        /// <summary>
        /// Collects the maximum ID number for the desired communicator type 
        /// from the controller. Returns int.MinValue upon error.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public int GetMaxId<T>()
        {
            var dbValue = int.MinValue;

            if (typeof (T).BaseType != typeof (Communicator))
            {
                throw new Exception("Method only handles Communicator objects.");
            }

            switch (typeof(T).Name)
            {
                case "DatabaseCommunicator":
                    var allDbComms = GetAllDatabaseCommunicators();
                    dbValue = allDbComms.Count == 0 ? allDbComms.Count : allDbComms.Max(c => c.Id);
                    break;
                case "SerialCommunicator":
                    var allSComms = GetAllSerialCommunicators();
                    dbValue = allSComms.Count == 0 ? allSComms.Count : allSComms.Max(c => c.Id);
                    break;
                case "FileCommunicator":
                    var allFfComms = GetAllFileCommunicators();
                    dbValue = allFfComms.Count == 0 ? allFfComms.Count : allFfComms.Max(c => c.Id);
                    break;
                default:
                    return int.MinValue;
            }

            return dbValue;
        }

        public void SaveCommunicator(DatabaseCommunicator dbComm)
        {
            
        }

        public void SaveCommunicator(SerialCommunicator sComm)
        {

        }

        public void SaveCommunicator(FileCommunicator ffComm)
        {
            _repo.CreateFileCommunicator(ffComm);
            var deviceController = new DeviceController();
            var x = deviceController.SaveDevice(ffComm.Device);
        }

        public void SaveCommunicator(Communicator generalComm)
        {
            var dbValue = 0;

            switch (generalComm.GetType().Name)
            {
                case "DatabaseCommunicator":
                    var allDbComms = GetAllDatabaseCommunicators();
                    dbValue = allDbComms.Count == 0 ? allDbComms.Count : allDbComms.Max(c => c.Id);
                    break;
                case "SerialCommunicator":
                    var allSComms = GetAllSerialCommunicators();
                    dbValue = allSComms.Count == 0 ? allSComms.Count : allSComms.Max(c => c.Id);
                    break;
                case "FileCommunicator":
                    SaveCommunicator((FileCommunicator)generalComm);
                    break;
                default:
                    return;
            }

        }



        //public int CurrentMaxId()
        //{
        //    try
        //    {
        //        GetAllDevices(true);
        //        return AllCommunicators.Max(dev => dev.Id);
        //    }
        //    catch (Exception)
        //    {
        //        DebugOutput.Print("There are no devices existing in the datbase.");
        //        return 0;
        //    }

        //}

        //public Communicator GetDeviceObject(int Id, string name, string location, string custodian, bool enabled)
        //{
        //    return new Device()
        //    {
        //        Id = Id,
        //        Custodian = custodian,
        //        Enabled = enabled,
        //        Location = location,
        //        Name = name
        //    };
        //}

        //public bool SaveDevice(Device device)
        //{
        //    bool devExists = _repo.RetrieveDevice(device.Id) != null;

        //    try
        //    {
        //        if (devExists)
        //        {
        //            _repo.UpdateDevice(device);
        //            AllCommunicators[AllCommunicators.FindIndex(d => device.Id == d.Id)] = device;
        //        }
        //        else
        //        {
        //            _repo.CreateDevice(device);
        //            AllCommunicators.Add(device);
        //        }
        //        return true;
        //    }
        //    catch (Exception e) { DebugOutput.Print("Device creation failed.", e.Message); return false; }
        //}

        //public Communicator RetrieveDevice(int Id, bool secondPass = false)
        //{
        //    var dev = AllCommunicators.First(d => d. == Id);

        //    if (dev == null && !secondPass)
        //    {
        //        GetAllDevices(true);
        //        return RetrieveDevice(Id, true);
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}
    }
}