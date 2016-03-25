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
        private readonly IRepository _repo = new Repository();

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

        public IEnumerable<Communicator> GetAllCommunicators()
        {
            return _repo.RetrieveAllCommunicators();
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

            if (typeof(T).BaseType != typeof(Communicator)&&typeof(T).Name != typeof(Communicator).Name)
            {
                throw new Exception("Method only handles Communicator objects.");
            }

            switch (typeof(T).Name)
            {
                case "DatabaseCommunicator":
                    var allDbComms = GetAllDatabaseCommunicators();
                    dbValue = allDbComms.Count() == 0 ? allDbComms.Count() : allDbComms.Max(c => c.Id);
                    break;
                case "SerialCommunicator":
                    var allSComms = GetAllSerialCommunicators();
                    dbValue = allSComms.Count() == 0 ? allSComms.Count() : allSComms.Max(c => c.Id);
                    break;
                case "FileCommunicator":
                    var allFfComms = GetAllFileCommunicators();
                    dbValue = allFfComms.Count() == 0 ? allFfComms.Count() : allFfComms.Max(c => c.Id);
                    break;
                case "Communicator":
                    dbValue = _repo.RetrieveAllCommunicators().Count();
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

        public int? SaveCommunicator(FileCommunicator ffComm)
        {
            if (ffComm.Id == 0)
            {
                return _repo.CreateCommunicator(ffComm);
            }
            else
            {
                _repo.UpdateCommunicator(ffComm);
                return ffComm.Id;
            }
        }

        public int? SaveCommunicator(Communicator generalComm)
        {
            if (generalComm.Id == 0)
            {
                return _repo.CreateCommunicator(generalComm);
            }
            else
            {
                _repo.UpdateCommunicator(generalComm);
                return generalComm.Id;
            }


            //switch (generalComm.GetType().Name)
            //{
            //    case "DatabaseCommunicator":
            //        var allDbComms = GetAllDatabaseCommunicators();
            //        break;
            //    case "SerialCommunicator":
            //        return SaveCommunicator((SerialCommunicator) generalComm);
            //        break;
            //    case "FileCommunicator":
            //        return SaveCommunicator((FileCommunicator)generalComm);
            //        break;
            //    default:
            //        break;
            //}

            return -1;



        }
    }
}