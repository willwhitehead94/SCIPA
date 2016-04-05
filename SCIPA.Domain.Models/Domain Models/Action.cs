namespace SCIPA.Models
{
    using System;
    using System.Collections.Generic;

    public partial class Action
    {
        public int Id { get; set; }
        public string OutputValue { get; set; }
        public int RuleId { get; set; }
        public int CommunicatorId { get; set; }
        public bool Enabled { get; set; }

        public virtual Rule Rule { get; set; }
        public virtual Communicator Communicator { get; set; }
    }
}
