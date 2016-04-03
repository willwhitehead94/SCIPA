using System;
using System.Collections.Generic;
using System.Linq;
using SCIPA.Data.Repository;
using SCIPA.Models;

namespace SCIPA.Domain.Logic
{
    /// <summary>
    /// Controller class for all Alarm objects within the application.
    /// </summary>
    public class AlarmController
    {
        /// <summary>
        /// Local access to the SQL Database repository.
        /// </summary>
        private readonly IRelationalRepository _repo = new RelationalRepository();

        /// <summary>
        /// The last Alarm object following an update.
        /// </summary>
        public Models.Alarm LastAlarm = null;

        /// <summary>
        /// Creates a new Alarm object on the database.
        /// </summary>
        /// <param name="alarm"></param>
        public void CreateAlarm(Alarm alarm)
        {
            //Ensure the Alarm object is not null.
            if (alarm == null) return;
            _repo.CreateAlarm(alarm);
        }

        public ICollection<Alarm> GetAllAlarms(int hours)
        {
            //Make positive number negative.
            hours = hours - (2*hours);

            //The earliest time to retrieve.
            var earliest = DateTime.Now.AddHours(hours);

            //Alaram List
            IEnumerable<Alarm> alarms = null;

            //Returns all alarms as a list where they fall within the given period.
            try
            {
                alarms = _repo.RetrieveAlarms().Where(al => al.TimeStamp >= earliest);
            }
            catch
            {
                
            }

            return alarms != null && alarms.Any() ? alarms.ToList() : new List<Alarm>();
        }

        public Alarm Acknowledge(Alarm alarm)
        {
            alarm.Accepted = true;
            LastAlarm = _repo.UpdateAlarm(alarm);

            return LastAlarm;
        }

        public int GetActiveAlarmCount()
        {
            try
            {
                var list = _repo.RetrieveAlarms().Count();
                var acceptedList = _repo.RetrieveAlarms().Count(alm => alm.Accepted == false);
                var acceptedGeneral = _repo.RetrieveAlarms().Where(alm => alm.Accepted == false);

                return acceptedList;
            }
            catch
            {
                return 0;
            }
        }
    }
}