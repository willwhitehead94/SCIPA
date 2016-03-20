using System.ComponentModel.DataAnnotations.Schema;

namespace SCIPA.Data.AccessLayer.Models
{
    public partial class SerialCommunicator : Communicator, IDomainModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string comPort { get; set; }

        public int baudRate { get; set; }

        public byte dataBits { get; set; }

        public bool? isRTS { get; set; }

        public bool? isDTR { get; set; }

        //public virtual  Device Device { get; set; }
    }
}
