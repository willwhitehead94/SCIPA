using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SCIPA.DataAccessLayer.Models
{
    [Table("ApplicationInformation")]
    public partial class ApplicationInformation
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string BusinessName { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool ApplicationEnabled { get; set; }
    }
}
