using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SCIPA.Data.AccessLayer.Models
{
    [Table("CommunicatorType")]
    public partial class CommunicatorType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CommunicatorType()
        {
            Communicators = new HashSet<Communicator>();
        }

        public int id { get; set; }

        [Column("communicatorType")]
        [Required]
        [StringLength(25)]
        public string communicatorType1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Communicator> Communicators { get; set; }
    }
}
