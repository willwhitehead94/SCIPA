using System;
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
        /// Creates a new Alarm object on the database.
        /// </summary>
        /// <param name="alarm"></param>
        public void CreateAlarm(Alarm alarm)
        {
            //Ensure the Alarm object is not null.
            if (alarm == null) return;
            _repo.CreateAlarm(alarm);
        }
    }
}