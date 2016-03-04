using System;
using System.Collections.Generic;
using SCIPA.Models;
using Action = SCIPA.Models.Action;

namespace SCIPA.Data.Repository
{
    public class DataRepository : IRepository
    {
        /// <summary>
        /// Data Controller object from the DAL. Acts as the intermediary between the repository and 
        /// the database.
        /// </summary>
        readonly AccessLayer.DataController _dbController = new AccessLayer.DataController();

        /// <summary>
        /// Converter tool to convert models from Domain to Data and vice versa.
        /// </summary>
        Converter _converter = new Converter();



        /// <summary>
        /// Passes a new Device to the database for insertion.
        /// </summary>
        /// <param name="device">New Device.</param>
        public void CreateDevice(Device device)
        {
            if (device == null) return;

            //check the device has not already been assigned an ID
            if (device.Id == int.MinValue) 
            {
                //do the checks to make sure nothing is null
            }

            //Pass the device object through the converter and onto the dbController.
            _dbController.CreateNewDevice(_converter.ConvertToData(device));
        }

        /// <summary>
        /// Retrieve a specific Device from the database.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Device RetrieveDevice(int id)
        {
            return _converter.ConvertToDomain(_dbController.RetrieveDevice(id));
        }

        /// <summary>
        /// Get all Devices stored on the database.
        /// </summary>
        /// <returns></returns>
        public ICollection<Device> RetrieveAllDevices()
        {
            List<Device> devList = new List<Device>();

            foreach (var device in _dbController.RetrieveDevices())
            {
                _converter.ConvertToDomain(device);
            }

            return devList;
        }

        /// <summary>
        /// Passes an existing Device object back to the database to update it.
        /// </summary>
        /// <param name="device">Updated Device object.</param>
        public void UpdateDevice(Device device)
        {
            if (device == null) return;

            _dbController.UpdateDevice(_converter.ConvertToData(device));
        }

        /// <summary>
        /// Delete an existing Device object from the database.
        /// </summary>
        /// <param name="device"></param>
        public void DisableDevice(Device device)
        {
            if (device == null) return;

            _dbController.DeleteDevice(_converter.ConvertToData(device));
        }

        /// <summary>
        /// If an objects existance is unknown, check the database.
        /// If found, update, otherwise create new.
        /// </summary>
        /// <param name="device">Unknown Device object.</param>
        public void CreateOrUpdateDevice(Models.Device device)
        {
            if (device == null) return;

            if (RetrieveDevice(device.Id) == null)
            {
                device.Id = int.MinValue;
                CreateDevice(device);
            }
            else
            {
                UpdateDevice(device);
            }
        }



        public void CreateAction(Models.Action action)
        {
            if (action == null) return;

            //check the object has not already been assigned an ID
            if (action.Id == int.MinValue)
            {
                //do the checks to make sure nothing is null
            }

            //Pass the object through the converter and onto the dbController.
            _dbController.CreateAction(_converter.ConvertToData(action));
        }

        public Action RetrieveAction(int id);

        public ICollection<Action> RetrieveActionsForDevice(int deviceId);

        public ICollection<Action> RetrieveAllActions();

        public void UpdateAction(Action action);

        public void DeleteAction(Action action);
    }
}
