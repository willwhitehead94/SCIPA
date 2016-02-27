using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SCIPA.Data.AccessLayer.Models
{
    [Table("DatabaseType")]
    public partial class DatabaseType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DatabaseType()
        {
            DatabaseCommunicators = new HashSet<DatabaseCommunicator>();
        }

        public int id { get; set; }

        [Column("databaseType")]
        [Required]
        [StringLength(7)]
        public string databaseType1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatabaseCommunicator> DatabaseCommunicators { get; set; }
    }
}
