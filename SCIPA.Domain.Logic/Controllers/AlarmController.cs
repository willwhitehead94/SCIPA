using System;
using SCIPA.Data.Repository;
using SCIPA.Models;

namespace SCIPA.Domain.Logic
{
    public class AlarmController
    {
        private readonly IRelationalRepository _repo = new RelationalRepository();

        public AlarmController()
        {
            
        }

        public void CreateAlarm(Alarm alarm)
        {
            //Ensure the Alarm object is not null.
            if (alarm == null) return;
            _repo.CreateAlarm(alarm);
        }
    }
}