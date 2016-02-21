namespace SCIPA.Models
{
    public partial class Alarm : IDomainModel
    {
        public int id { get; set; }

        //public int deviceId { get; set; }

        //public int alarmTypeId { get; set; }

        public string value { get; set; }

        public bool enabled { get; set; }

        public bool deleted { get; set; }

        public virtual Device Device { get; set; }

        public virtual AlarmType AlarmType { get; set; }
    }
}