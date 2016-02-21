namespace SCIPA.Models
{
    using System;
    using System.Collections.Generic;
    public partial class FileCommunicator : IDomainModel
    {
        public FileCommunicator()
        {
            Communicators = new HashSet<Communicator>();
        }

        public int Id { get; set; }

        public string FilePath { get; set; }

        public int StartChar { get; set; }

        public int EndChar { get; set; }

        public DateTime LastReadTime { get; set; }

        public Type ValueType { get; set; }

        //public int OpenModeId { get; set; }

        public virtual ICollection<Communicator> Communicators { get; set; }

        //public virtual FileOpenMode FileOpenMode { get; set; }
    }
}
