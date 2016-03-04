using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCIPA.Data.AccessLayer.Models;

namespace SCIPA.Data.AccessLayer
{
    public class DataController : IDataController
    {
        private DataModel _db = new DataModel();

        public void CreateNewDevice(Device device)
        {
            _db.Devices.Add(device);
            _db.SaveChanges();
        }

        public void DeleteDevice(Device device)
        {
            var temp = _db.Devices.FirstOrDefault(dev => dev.id == device.id);

            if (temp != null)
            {
                temp.enabled = false;
                _db.SaveChanges();
            }
        }

        public Device RetrieveDevice(int deviceId)
        {
            return _db.Devices.FirstOrDefault(dev => dev.id == deviceId);
        }

        public ICollection<Device> RetrieveDevices()
        {
            return _db.Devices.ToArray();
        }

        public void UpdateDevice(Device device)
        {
            var temp = _db.Devices.FirstOrDefault(dev => dev.id == device.id);
            
            if (temp != null)
            {
                temp = device;
                _db.SaveChanges();
            }
        }

        public void CreateNewAction(Action action)
        {
            _db.Actions.Add(action)
        }
    }
}
