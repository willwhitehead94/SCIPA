using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SCIPA.Data.AccessLayer.Models
{
    [Table("Device")]
    public partial class Device
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Device()
        {
            Communicators = new HashSet<Communicator>();
            DeviceValues = new HashSet<DeviceValue>();
            Rules = new HashSet<Rule>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(20)]
        public string name { get; set; }

        public bool readOnly { get; set; }

        public int? locationId { get; set; }

        [StringLength(50)]
        public string custodian { get; set; }

        public float? faultTolerance { get; set; }

        public int valueTypeId { get; set; }

        public int? lowestValue { get; set; }

        public int? highestValue { get; set; }

        public bool enabled { get; set; }

        public virtual Alarm Alarm { get; set; }

        public virtual Command Command { get; set; }

        //public virtual Command Command1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Communicator> Communicators { get; set; }

        public virtual Location Location { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeviceValue> DeviceValues { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rule> Rules { get; set; }
    }
}
