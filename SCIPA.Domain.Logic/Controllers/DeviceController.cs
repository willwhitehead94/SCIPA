using System.Collections.Generic;
using SCIPA.Models;

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