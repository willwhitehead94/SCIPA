using System.Collections.Generic;

namespace SCIPA.Data.Repository
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
