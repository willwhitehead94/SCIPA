namespace SCIPA.Data.AccessLayer.Models
{
    public partial class ApplicationInformation : IDomainModel
    {
        public int Id { get; set; } = 1;

        public string BusinessName { get; set; }

        public bool ApplicationEnabled { get; set; }
    }
}
