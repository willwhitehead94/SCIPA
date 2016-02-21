namespace SCIPA.DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FileOpenMode")]
    public partial class FileOpenMode
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FileOpenMode()
        {
            FileCommunicators = new HashSet<FileCommunicator>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(10)]
        public string openMode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FileCommunicator> FileCommunicators { get; set; }
    }
}
