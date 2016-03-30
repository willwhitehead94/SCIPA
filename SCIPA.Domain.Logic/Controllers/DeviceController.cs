using System;
using System.Collections.Generic;
using System.Linq;
using SCIPA.Data.Repository;
using SCIPA.Domain.Generic;
using SCIPA.Models;

namespace SCIPA.Domain.Logic
{
    /// <summary>
    /// Controller class for all Device objects within the application.
    /// </summary>
    public class DeviceController
    {
        /// <summary>
        /// Static list available application wide of all known Device objects.
        /// </summary>
        public static List<Device> AllDevices = new List<Device>();

        private static List<Device> ActiveDevices = new List<Device>(); 

        /// <summary>
        /// Local access to the SQL Database repository.
        /// </summary>
        private readonly IRelationalRepository _repo = new RelationalRepository();

        /// <summary>
        /// Returns a list of all Devices to the caller.
        /// </summary>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public IEnumerable<Device> GetAllDevices(bool refresh=false)
        {
            if (AllDevices == null || AllDevices.Count == 0) refresh = true;

            if (refresh)
            {
                AllDevices=new List<Device>();
                foreach (var device in _repo.RetrieveAllDevices())
                {
                    AllDevices.Add(device);   
                }
            }

            return AllDevices;
        }

        public static ICollection<Device> GetActiveDevices()
        {
            return ActiveDevices;
        }

        public static void AddActiveDevice(Device device)
        {
            ActiveDevices.Add(device);
        }

        public static void StartDeviceProcess(Device device)
        {
            //TODO break here and add dthe start logic!
            ActiveDevices.Add(device);
        }

        /// <summary>
        /// Returns the current highest ID number on the database.
        /// </summary>
        /// <returns></returns>
        public int CurrentMaxId()
        {
            try
            {
                GetAllDevices(true);
                return AllDevices.Max(dev => dev.Id);
            }
            catch (Exception e)
            {
                DebugOutput.Print("There are no devices existing in the datbase.",e.Message);
                return 0;
            }
            
        }

        /// <summary>
        /// Basic converter for each param into a single Device object.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="location"></param>
        /// <param name="custodian"></param>
        /// <param name="enabled"></param>
        /// <returns></returns>
        public Device GetDeviceObject(int id, string name, string location, string custodian, bool enabled)
        {
            return new Device()
            {
                Id = id,
                Custodian = custodian,
                Enabled = enabled,
                Location = location,
                Name = name
            };
        }

        /// <summary>
        /// Takes a Device object and posts it to the SQL Server database.
        /// This, in turn, casuses the next avaliable Mongo instance to be updated also.
        /// </summary>
        /// <param name="device"></param>
        /// <returns></returns>
        public Device SaveDevice(Device device)
        {
            bool devExists = _repo.RetrieveDevice(device.Id) != null;

            try
            {
                if (devExists)
                {
                    AllDevices[AllDevices.FindIndex(d => d.Id == device.Id)] = device;
                    return _repo.UpdateDevice(device);
                }
                else
                {
                    AllDevices.Add(device);
                    return _repo.CreateDevice(device);
                }
            }
            catch (Exception e) { DebugOutput.Print("Device creation failed.", e.Message); return null; }
        }

        /// <summary>
        /// Returns a single device via the parametised ID number.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Device RetrieveDevice(int id)
        {
            var dev = _repo.RetrieveDevice(id);

            return dev;
        }

        /// <summary>
        /// Returns a list of Communicator objects for the given Device via the
        /// parametised Device ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IEnumerable<Communicator> GetCommunicatorsForDevice(int id)
        {
            CommunicatorController commCont = new CommunicatorController();

            return commCont.GetAllCommunicators().Where(comm=>comm.Id==id);
        }
    }
}