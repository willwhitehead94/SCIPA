using System;
using System.Collections.Generic;
using SCIPA.Models;

namespace SCIPA.Data.Repository
{
    public class DataRepository : IRepository
    {
        DataAccessLayer.DataController _dbController = new DataAccessLayer.DataController();
        public void CreateNewDevice(Device domainModel)
        {
            DataAccessLayer.Models.Device dataModel = new DataAccessLayer.Models.Device();
            dataModel.name = domainModel.name;
            dataModel.readOnly = domainModel.readOnly;
            dataModel.locationId = domainModel.Location.id;
            dataModel.custodian = domainModel.custodian;
            dataModel.faultTolerance = domainModel.faultTolerance;
            dataModel.valueTypeId = domainModel.ValueType.id;
            dataModel.lowestValue = domainModel.lowestValue;
            dataModel.highestValue = domainModel.highestValue;
            dataModel.enabled = domainModel.enabled;

            _dbController.CreateNewDevice(dataModel);
        }

        public void CreateOrUpdateDevice(Device device)
        {
            throw new NotImplementedException();
        }

        public void DisableDevice(Device device)
        {
            throw new NotImplementedException();
        }

        public ICollection<Device> RetrieveAllDevices()
        {
            ICollection<DataAccessLayer.Models.Device> devList = _dbController.RetrieveDevices();
            ICollection<Device> domainDevList = null;

            foreach (DataAccessLayer.Models.Device dataDev in devList)
            {
                domainDevList.Add(new Device()
                {
                    name = dataDev.name,
                    readOnly = dataDev.readOnly,
                    locationId = dataDev.locationId,
                    custodian = dataDev.custodian,
                    faultTolerance = dataDev.faultTolerance,
                    valueTypeId = dataDev.valueTypeId,
                    lowestValue = dataDev.lowestValue,
                    highestValue = dataDev.highestValue,
                    enabled = dataDev.enabled
                });
            }

            return domainDevList;
        }

        public Device RetrieveDevice(int deviceId)
        {
            throw new NotImplementedException();
        }

        public void UpdateDevice(Device device)
        {
            throw new NotImplementedException();
        }
    }
}
