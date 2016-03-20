﻿using System;
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

        private readonly DataRepository _repo = new DataRepository();

        public ICollection<Device> GetAllDevices(bool refresh=false)
        {
            if (refresh)
            {
                AllDevices = _repo.RetrieveAllDevices().ToList();
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
            catch (Exception)
            {
                DebugOutput.Print("There are no devices existing in the datbase.");
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
            device = PrepareCommunicatorInfo(device);

            try
            {
                if (devExists)
                {
                    _repo.UpdateDevice(device);
                    AllDevices[AllDevices.FindIndex(d => device.Id == d.Id)] = device;
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

        public Device PrepareCommunicatorInfo(Device device)
        {
            device.InboundReader = (Communicator) device.InboundReader;
            return device;
        }

        public Device RetrieveDevice(int id, bool secondPass=false)
        {
            var dev = AllDevices.First(d => d.Id == id);

            if (dev == null && !secondPass)
            {
                GetAllDevices(true);
                return RetrieveDevice(id,true);
            }
            else
            {
                return null;
            }
        }
    }
}