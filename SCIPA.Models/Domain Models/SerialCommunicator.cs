namespace SCIPA.Models
{
    public partial class SerialCommunicator : Communicator, IDomainModel
    {
        public int Id { get; set; }

        public string comPort { get; set; }

        public int baudRate { get; set; }

        public byte dataBits { get; set; }

        public bool? isRTS { get; set; }

        public bool? isDTR { get; set; }
    }
}
