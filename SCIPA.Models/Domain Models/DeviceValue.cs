namespace SCIPA.Models
{
    using System;

    public partial class DeviceValue : IDomainModel
    {
        public int id { get; set; }

        public int deviceId { get; set; }

        public DateTime date { get; set; }

        public TimeSpan? time { get; set; }

        public string value { get; set; }

        public bool withinTolerance { get; set; }

        public virtual Device Device { get; set; }
    }
}
