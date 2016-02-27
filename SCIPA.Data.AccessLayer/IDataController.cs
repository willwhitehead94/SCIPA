using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCIPA.Data.AccessLayer.Models;

namespace SCIPA.Data.AccessLayer
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
