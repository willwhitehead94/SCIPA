using System.Collections.Generic;

namespace SCIPA.Data.AccessLayer.Models
{
    public class Device
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public string Custodian { get; set; }

        public bool Enabled { get; set; } = true;

        public FileCommunicator InboundFile { get; set; }

        public SerialCommunicator InboundSerial { get; set; }

        public DatabaseCommunicator InboundDatabase { get; set; }

        public object OutboundWriter { get; set; }

        public ICollection<Value> InboundValues { get; set; }

        public ICollection<Value> OutboundValues { get; set; }

        public ICollection<Rule> Rules { get; set; } 
    }
}