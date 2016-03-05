using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SCIPA.Data.Repository;
using SCIPA.Models;
using SCIPA.Models.Resources;

namespace SCIPA.Domain.Logic
{
    public class DeviceController
    {
        public static List<Device> AllDevices = new List<Device>();
        
        public static List<Device> DevicesInAlarm = new List<Device>();

        public DeviceController()
        {
            
        }

        public ICollection<Device> GetAllDevices()
        {
            return AllDevices;
        }
    }
}