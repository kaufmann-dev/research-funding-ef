using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project.model
{
    [Table("SUBPROJECT")]
    public class Subproject
    {
        [Key]
        [Column("SUBPROJECT_ID")]
        [DatabaseGenerated((DatabaseGeneratedOption.Identity))]
        public int Id { get; set; }

        [Column("DESCRIPTION", TypeName = "VARCHAR(255)")]
        public string Description { get; set; }
        
        [Required]
        [Column("FOCUS_RESEARCH")]
        public int FocusResearch { get; set; }

        [Required]
        [Column("APPLIED_RESEARCH")]
        public int AppliedResearch { get; set; }

        [Required]
        [Column("THEORETICAL_RESEARCH")]
        public int TheoreticalResearcb { get; set; }

        [ForeignKey("PROJECT_ID")]
        public project.model.Project Project { get; set; }

        public Institute Institute { get; set; }
    }
}