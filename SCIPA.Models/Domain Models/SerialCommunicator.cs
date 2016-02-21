namespace SCIPA.Models
{
    using System.Collections.Generic;

    public partial class SerialCommunicator : IDomainModel
    {
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

        public virtual ICollection<Communicator> Communicators { get; set; }
    }
}
