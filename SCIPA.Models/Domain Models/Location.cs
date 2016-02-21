namespace SCIPA.Models
{
    using System.Collections.Generic;


    public partial class Location : IDomainModel
    {
        public Location()
        {
            Devices = new HashSet<Device>();
        }

        public int id { get; set; }

        public string name { get; set; }

        public float? _long { get; set; }

        public float? lat { get; set; }

        public string notes { get; set; }

        public virtual ICollection<Device> Devices { get; set; }
    }
}
