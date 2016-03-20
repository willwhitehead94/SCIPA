using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SCIPA.Data.AccessLayer.Models
{
    public class Device
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public string Custodian { get; set; }

        public bool Enabled { get; set; } = true;

        [ForeignKey("Id")]
        public virtual FileCommunicator InboundFile { get; set; }

        [ForeignKey("Id")]
        public virtual SerialCommunicator InboundSerial { get; set; }

        [ForeignKey("Id")]
        public virtual DatabaseCommunicator InboundDatabase { get; set; }

        public object OutboundWriter { get; set; }

        public ICollection<Value> InboundValues { get; set; }

        public ICollection<Value> OutboundValues { get; set; }

        public ICollection<Rule> Rules { get; set; } 
    }
}