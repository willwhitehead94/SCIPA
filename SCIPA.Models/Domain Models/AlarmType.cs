namespace SCIPA.Models
{
    using System.Collections.Generic;
    public partial class AlarmType : IDomainModel
    {
        public int id { get; set; }

        public string alarmType { get; set; }
    }
}
