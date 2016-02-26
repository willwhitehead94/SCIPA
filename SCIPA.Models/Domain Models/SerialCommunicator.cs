namespace SCIPA.Models
{
    using System.Collections.Generic;

    public partial class SerialCommunicator : Communicator, IDomainModel
    {
        public SerialCommunicator()
        {
            Communicators = new HashSet<CommunicatorModel>();
        }

        public int id { get; set; }

        public string comPort { get; set; }

        public int baudRate { get; set; }

        public byte dataBits { get; set; }

        public bool? isRTS { get; set; }

        public bool? isDTR { get; set; }

        //public eType ValueEType { get; set; } = eType.String;

        //public int StartChar { get; set; } = 0;

        //public int EndChar { get; set; } = 0;

        public virtual ICollection<CommunicatorModel> Communicators { get; set; }
    }
}
