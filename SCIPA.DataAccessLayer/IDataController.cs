using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCIPA.DataAccessLayer.Models;

namespace SCIPA.DataAccessLayer
{
    interface IDataController
    {
        void CreateNewDevice(Device device);

        Device RetrieveDevice(int deviceId);

        ICollection<Device> RetrieveDevices();

        void UpdateDevice(Device device);

        void DeleteDevice(Device device);
    }
}
