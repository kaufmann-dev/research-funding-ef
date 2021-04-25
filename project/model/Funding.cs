using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project.model
{
    [Table("FUNDING")]
    public class Funding
    {
        [Column("PROJECT_ID")]
        public int ProjectId { get; set; }

        [Column("DEBITOR_ID")]
        public int DebitorId { get; set; }

        public project.model.Project Project { get; set; }

        public project.model.Debitor Debitor { get; set; }

        [Column("FUNDING_AMOUNT", TypeName = "DECIMAL(8,2)")]
        [Required]
        public float Amount { get; set; }
    }
}