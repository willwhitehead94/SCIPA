namespace SCIPA.DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DeviceValue")]
    public partial class DeviceValue
    {
        public int id { get; set; }

        public int deviceId { get; set; }

        [Column(TypeName = "date")]
        public DateTime date { get; set; }

        public TimeSpan? time { get; set; }

        [StringLength(500)]
        public string value { get; set; }

        public bool withinTolerance { get; set; }

        public virtual Device Device { get; set; }
    }
}
