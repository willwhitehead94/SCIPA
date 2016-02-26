using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SCIPA.DataAccessLayer.Models
{
    [Table("CommandType")]
    public partial class CommandType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CommandType()
        {
            Commands = new HashSet<Command>();
        }

        public int id { get; set; }

        [Column("commandType")]
        [Required]
        [StringLength(25)]
        public string commandType1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Command> Commands { get; set; }
    }
}
