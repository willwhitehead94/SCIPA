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
        public List<T> DownloadAll<T>()
        {
            if (!_allObjects.Count.Equals(GetModels().Count))
            {
                _allObjects = GetModels();
            }
            
            return ConvertToModel<T>(_allObjects);
        }

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

            return allAlarmVMs;
        }

        public object GetFromId(int id)
        {
            return new AlarmVM(id);
        }

        
    }
}
