using System;
using System.Collections.Generic;
using System.Linq;
using SCIPA.Data.Repository;
using SCIPA.Domain.Generic;
using SCIPA.Models;

namespace SCIPA.Domain.Logic
{
    public class DeviceController
    {
        public static List<Device> AllDevices = new List<Device>();
        
        public static List<Device> DevicesInAlarm = new List<Device>();

        private readonly IRepository _repo = new Repository();

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

        public bool SaveDevice(Device device)
        {
            bool devExists = _repo.RetrieveDevice(device.Id) != null;

            try
            {
                if (devExists)
                {
                    _repo.UpdateDevice(device);
                    //AllDevices[AllDevices.FindIndex(d => device.Id == d.Id)] = device;
                }
                else
                {
                    _repo.CreateDevice(device);
                    AllDevices.Add(device);
                }
                return true;
            }
            catch (Exception e) { DebugOutput.Print("Device creation failed.", e.Message); return false; }
        }

        public Device RetrieveDevice(int id)
        {
            var dev = _repo.RetrieveDevice(id);

            return dev;
        }

        public IEnumerable<Communicator> GetCommunicatorsForDevice(int id)
        {
            CommunicatorController commCont = new CommunicatorController();

            return commCont.GetAllCommunicators();
        }
    }
}