using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SCIPA.Data.AccessLayer.Models
{
    [Table("Command")]
    public partial class Command
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Command()
        {
            Rules = new HashSet<Rule>();
        }

        public int id { get; set; }

        public int deviceId { get; set; }

        public int commandTypeId { get; set; }

        public int communicatorId { get; set; }

        [Required]
        [StringLength(1000)]
        public string commandText { get; set; }

        public int returnValueTypeId { get; set; }

        public bool enabled { get; set; }

        public virtual CommandType CommandType { get; set; }

        public virtual Device Device { get; set; }

        public virtual Device Device1 { get; set; }

        public virtual ValueType ValueType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rule> Rules { get; set; }
    }
}
