using System.Collections.Generic;
using SCIPA.Models.Resources;

namespace SCIPA.Models
{
    public class Device
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public string Custodian { get; set; }

        public bool Enabled { get; set; } = true;

        public object InboundReader { get; set; }

        public object OutboundWriter { get; set; }

        public ICollection<Value> InboundValues { get; set; }

        public ICollection<Value> OutboundValues { get; set; }

        public ICollection<Rule> Rules { get; set; }
    }
}