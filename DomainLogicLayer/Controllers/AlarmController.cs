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
    public class AlarmController : DefaultController, IController
    {
        public List<object> _allObjects = new List<object>();

        /// <summary>
        /// If the offline list of objects does contains a different number of objects to the database, all objects are downloaded and stored locally.
        /// </summary>
        /// <typeparam name="T">Model type to return as.</typeparam>
        /// <returns></returns>
        public List<object> DownloadAll()
        {
            if (!_allObjects.Count.Equals(GetModels().Count))
            {
                _allObjects = GetModels();
            }
            
            return _allObjects;
        }

        public object DownloadById(int id, int counter = 0)
        {
            if (counter > 1)
            {
                //The object does not exist in the database or is corrupt.
                return default(AlarmVM);
            }

            //if the ID is available, the index will be set here.
            int index = ConvertToModel<AlarmVM>(_allObjects).FindIndex(alarm => alarm.Id == id);

            //if the index is set, return that object.
            if (index >= 0)
            {
                return (AlarmVM)_allObjects[index];
            }

            //if no index found
            List<object> tempList = new List<object>();
            foreach (DAL.Models.Alarm dalAlarm in DAL.Controllers.AlarmController.GetAllAlarms(id))
            {
                AlarmVM tempAlarm = new AlarmVM(dalAlarm);
                tempList.Add(tempAlarm);
            }

            _allObjects = tempList;
            
            return DownloadById(id, ++counter);
        }

        /// <summary>
        /// Used to return a list of object view models..
        /// </summary>
        /// <param name="count">Select TOP x values from the object list, ordered by the ID.</param>
        /// <returns>List of ViewModel Objects.</returns>
        public List<object> GetModels(int count = int.MinValue)
        {
            List<DAL.Models.Alarm> allAlarms = null;
            allAlarms = DAL.Controllers.AlarmController.GetAllAlarms();

            //Allows us to only investigate the first X objects.
            if (!count.Equals(int.MinValue) && count>0)
            {
                allAlarms = DAL.Controllers.AlarmController.GetAllAlarms().OrderBy(i=> i.Id).Take(count).ToList();
            }            

            List<object> allAlarmVMs = new List<object>();
            foreach (DAL.Models.Alarm dbAlarm in allAlarms)
            {
                allAlarmVMs.Add(new AlarmVM
                        (
                            dbAlarm.Id,
                            dbAlarm.DeviceId,
                            dbAlarm.AlarmTypeId,
                            dbAlarm.Value,
                            dbAlarm.IsEnabled
                        )
                    );
            }

            return (allAlarmVMs);
        }

        public int GetMaxId()
        {
            return DAL.Controllers.AlarmController.GetMaxAlarmId();
        }

        
    }
}
