﻿using System;
using System.Collections.Generic;
using System.Linq;
using SCIPA.Data.Repository;
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

        public bool SaveNewDevice(int id, string name, string location, string custodian, bool enabled)
        {
            var newDevice = new Device()
            {
                Id=id,
                Custodian = custodian,
                Enabled = enabled,
                Location = location,
                Name = name
            };

            try { _repo.CreateDevice(newDevice); return true; }
            catch (Exception e) { DebugOutput.Print("Device creation failed.",e.Message); return false; }
        }
    }
}