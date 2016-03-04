namespace SCIPA.Data.AccessLayer.Models
{
    public partial class FileCommunicator : Communicator, IDomainModel
    {
        public int Id { get; set; }

        public string FilePath { get; set; }

        public virtual Device Device { get; set; }
    }
}
