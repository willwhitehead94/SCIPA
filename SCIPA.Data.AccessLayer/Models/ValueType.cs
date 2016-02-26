using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SCIPA.DataAccessLayer.Models
{
    [Table("ValueType")]
    public partial class ValueType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ValueType()
        {
            Commands = new HashSet<Command>();
            Communicators = new HashSet<Communicator>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(15)]
        public string type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Command> Commands { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Communicator> Communicators { get; set; }
    }
}
