namespace SCIPA.Models
{
    using System.Collections.Generic;

    public partial class FileOpenMode : IDomainModel
    {
        public FileOpenMode()
        {
            FileCommunicators = new HashSet<FileCommunicator>();
        }

        public int id { get; set; }

        public string openMode { get; set; }

        public virtual ICollection<FileCommunicator> FileCommunicators { get; set; }
    }
}
