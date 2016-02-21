namespace SCIPA.Models
{
    using System.Collections.Generic;
    public partial class AlarmType : IDomainModel
    {
        public AlarmType()
        {
            Alarms = new HashSet<Alarm>();
        }

        public int id { get; set; }

        public string alarmType1 { get; set; }
       
        public virtual ICollection<Alarm> Alarms { get; set; }
    }
}
