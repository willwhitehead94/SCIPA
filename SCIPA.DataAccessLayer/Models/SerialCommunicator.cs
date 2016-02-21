namespace SCIPA.DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SerialCommunicator")]
    public partial class SerialCommunicator
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SerialCommunicator()
        {
            Communicators = new HashSet<Communicator>();
        }

        public int id { get; set; }

        public int comPort { get; set; }

        public int baudRate { get; set; }

        public byte dataBits { get; set; }

        public bool? isRTS { get; set; }

        public bool? isDTR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Communicator> Communicators { get; set; }
    }
}
