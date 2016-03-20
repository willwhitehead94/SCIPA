using System.ComponentModel.DataAnnotations.Schema;

namespace SCIPA.Data.AccessLayer.Models
{
    public partial class FileCommunicator : Communicator, IDomainModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string FilePath { get; set; }

        [ForeignKey("Id")]
        public virtual Device Device { get; set; }
    }
}
