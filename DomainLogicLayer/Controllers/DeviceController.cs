using DomainLogicLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL = DataAccessLayer;

namespace DomainLogicLayer.Controllers
{
    /// <summary>
    /// This is the domain controller. It acts upon the respective data controller in the Data Access Layer.
    /// </summary>
    class DeviceController : DefaultController, IController
    {
        public List<object> _allObjects = new List<object>();

        public List<object> DownloadAll()
        {
            List<object> _allDeviceObjects = new List<object>();
            _allDeviceObjects = GetModels();

            if (!_allObjects.Count.Equals(_allDeviceObjects.Count()))
            {
                _allObjects = GetModels();
            }

            return _allObjects;
        }

        public object DownloadById(int id, int counter =0)
        {
            if (counter > 1)
            {
                //The object does not exist in the database or is corrupt.
                return default(DeviceVM);
            }

            //if the ID is available, the index will be set here.
            int index = ConvertToModel<DeviceVM>(_allObjects).FindIndex(alarm => alarm.Id == id);

            //if the index is set, return that object.
            if (index >= 0)
            {
                return (DeviceVM)_allObjects[index];
            }

            //if no index found
            DeviceVM tempAlarm = new DeviceVM(DAL.Controllers.DeviceController.GetDeviceById(id));

            List<DeviceVM> _allDeviceObjects = ConvertToModel<DeviceVM>(_allObjects);

            index = _allDeviceObjects.FindIndex(device => device.Id == id);
            if (index >= 0)
            {
                string test = "";
            }

            return DownloadById(id, counter++);



            //Downloads the data model for the requested device.
            DAL.Models.Device tempDevice = DataAccessLayer.Controllers.DeviceController.GetDeviceById(id);

            //Casts from DAL Model to DLL View Model (very little, if no change)
            DeviceVM newDevice = new DeviceVM(tempDevice);

            //Discard unrequired DAL object
            tempDevice = null;

            return newDevice;
        }

        public List<object> GetModels(int count = int.MinValue)
        {
            List<DAL.Models.Device> allDevices = null;
            allDevices = DAL.Controllers.DeviceController.GetAllDevices();

            //Allows us to only investigate the first X objects.
            if (!count.Equals(int.MinValue) && count > 0)
            {
                allDevices = DAL.Controllers.DeviceController.GetAllDevices().OrderBy(i => i.Id).Take(count).ToList();
            }

            List<object> allDeviceVMs = new List<object>();
            foreach (DAL.Models.Device dbDevice in allDevices)
            {
                allDeviceVMs.Add(new DeviceVM(dbDevice));

                //allDeviceVMs.Add(new DeviceVM
                //        (
                //            dbDevice.Id,
                //            dbDevice.Name,
                //            dbDevice.IsReadOnly,
                //            dbDevice.LocationId,
                //            dbDevice.FaultTolerance,
                //            dbDevice.ValueTypeId,
                //            dbDevice.LowestValue,
                //            dbDevice.HighestValue,
                //            dbDevice.IsEnabled
                //        )
                //    );
            }

            return allDeviceVMs;
        }
    }
}
