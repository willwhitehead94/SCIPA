using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCIPA.DataRepository
{
    interface IRepository
    {
        void CreateNewDevice(Models.Device device);

        Models.Device RetrieveDevice(int deviceId);

        ICollection<Models.Device> RetrieveAllDevices();

        void UpdateDevice(Models.Device device);

        void DisableDevice(Models.Device device);

        void CreateOrUpdateDevice(Models.Device device);


    }
}
