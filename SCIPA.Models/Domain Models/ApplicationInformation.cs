namespace SCIPA.Models
{
    public partial class ApplicationInformation : IDomainModel
    {
        public string BusinessName { get; set; }

        public bool ApplicationEnabled { get; set; }
    }
}
