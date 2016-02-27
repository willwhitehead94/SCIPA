using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SCIPA.Data.AccessLayer.Models
{
    [Table("Alarm")]
    public partial class Alarm
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int deviceId { get; set; }

        public int alarmTypeId { get; set; }

        [Required]
        [StringLength(500)]
        public string value { get; set; }

        public bool enabled { get; set; }

        public bool deleted { get; set; }

        public virtual Device Device { get; set; }

        public virtual AlarmType AlarmType { get; set; }
    }
}
