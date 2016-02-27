using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SCIPA.Data.AccessLayer.Models
{
    [Table("DatabaseCommunicator")]
    public partial class DatabaseCommunicator
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DatabaseCommunicator()
        {
            Communicators = new HashSet<Communicator>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(400)]
        public string connectionString { get; set; }

        public int databaseTypeId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Communicator> Communicators { get; set; }

        public virtual DatabaseType DatabaseType { get; set; }
    }
}
