namespace SCIPA.Models
{
    using System;
    using System.Collections.Generic;

    public partial class Device
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Device()
        {
            this.Actions = new HashSet<Action>();
            this.Rules = new HashSet<Rule>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Custodian { get; set; }
        public bool Enabled { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual IEnumerable<Action> Actions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual IEnumerable<Rule> Rules { get; set; }

        public override string ToString()
        {
            return $"{Id.ToString()}: {Name} ({Location}, {Custodian})";
        }
    }
}
