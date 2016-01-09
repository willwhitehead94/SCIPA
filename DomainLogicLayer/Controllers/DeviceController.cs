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
    class DeviceController : IController
    {
        public object GetFromId(int id)
        {
            //Downloads the data model for the requested device.
            DAL.Models.Device tempDevice = DataAccessLayer.Controllers.DeviceController.GetDeviceById(id);

            //Casts from DAL Model to DLL View Model (very little, if no change)
            DeviceVM newDevice = new DeviceVM
                (
                    tempDevice.Id,
                    tempDevice.Name,
                    tempDevice.IsReadOnly,
                    tempDevice.LocationId,
                    tempDevice.FaultTolerance,
                    tempDevice.ValueTypeId,
                    tempDevice.LowestValue,
                    tempDevice.HighestValue,
                    tempDevice.IsEnabled
                );

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
                allDeviceVMs.Add(new DeviceVM
                        (
                            dbDevice.Id,
                            dbDevice.Name,
                            dbDevice.IsReadOnly,
                            dbDevice.LocationId,
                            dbDevice.FaultTolerance,
                            dbDevice.ValueTypeId,
                            dbDevice.LowestValue,
                            dbDevice.HighestValue,
                            dbDevice.IsEnabled
                        )
                    );
            }

            return allDeviceVMs;
        }
    }
}
