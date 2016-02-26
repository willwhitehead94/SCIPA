using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SCIPA.DataAccessLayer.Models
{
    [Table("FileCommunicator")]
    public partial class FileCommunicator
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FileCommunicator()
        {
            Communicators = new HashSet<Communicator>();
        }

        public int id { get; set; }

        [Required]
        public string filePath { get; set; }

        public int startChar { get; set; }

        public int endChar { get; set; }

        public int openModeId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Communicator> Communicators { get; set; }

        public virtual FileOpenMode FileOpenMode { get; set; }
    }
}
