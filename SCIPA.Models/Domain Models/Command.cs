namespace SCIPA.Models
{
    using System;
    using System.Collections.Generic;


    public partial class Command : IDomainModel
    {
        public int id { get; set; }

        public int deviceId { get; set; }

        public int commandTypeId { get; set; }

        public int communicatorId { get; set; }

        public string commandText { get; set; }

        public int returnValueTypeId { get; set; }

        public bool enabled { get; set; }

        public virtual CommandType CommandType { get; set; }

        public virtual Device Device { get; set; }

        public virtual Device Device1 { get; set; }

        public virtual ValueType ValueType { get; set; }

        public virtual ICollection<Rule> Rules { get; set; }
    }
}
