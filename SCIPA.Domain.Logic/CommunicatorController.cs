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
        public IEnumerable<Communicator> GetAllFileCommunicators()
        {
            return _repo.RetrieveAllCommunicators().Where(comm => comm.Type == CommunicatorType.FlatFile).ToList();
        }

        /// <summary>
        /// Returns collection of all Database Communicators in the database.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Communicator> GetAllDatabaseCommunicators()
        {
            return _repo.RetrieveAllCommunicators().Where(comm => comm.Type == CommunicatorType.Database).ToList();
        }

        /// <summary>
        /// Returns collection of all Serial Communicators in the database.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Communicator> GetAllSerialCommunicators()
        {
            return _repo.RetrieveAllCommunicators().Where(comm => comm.Type == CommunicatorType.Serial).ToList();
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

            if (typeof(T).BaseType != typeof(Communicator))
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

        public void SaveCommunicator(FileCommunicator ffComm, Device parentDevice)
        {
            ffComm.Device = parentDevice;
            _repo.CreateFileCommunicator(ffComm);
            var deviceController = new DeviceController();
            var x = deviceController.SaveDevice(ffComm.Device);
        }

        public void SaveCommunicator(Communicator generalComm, Device parentDevice)
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
                    SaveCommunicator((FileCommunicator)generalComm, parentDevice);
                    break;
                default:
                    return;
            }

        }
    }
}