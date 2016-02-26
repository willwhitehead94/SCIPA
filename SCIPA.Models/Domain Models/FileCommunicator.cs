namespace SCIPA.Models
{
    using System;
    using System.Collections.Generic;
    public partial class FileCommunicator : Communicator, IDomainModel
    {
        public FileCommunicator()
        {
            Communicators = new HashSet<CommunicatorModel>();
        }

        public int Id { get; set; }

        public string FilePath { get; set; }

        //public int StartChar { get; set; }

        //public int EndChar { get; set; }

        //public DateTime LastReadTime { get; set; }

        //public eType ValueEType { get; set; }

        //public int OpenModeId { get; set; }

        public virtual ICollection<CommunicatorModel> Communicators { get; set; }

        //public virtual FileOpenMode FileOpenMode { get; set; }
    }
}
