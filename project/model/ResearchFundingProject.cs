using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project.model
{
    [Table("RESEARCH_FUNDING_PROJECT")]
    public class ResearchFundingProject : Project
    {
        [Required]
        [Column("IS_SMALL_PROJECT", TypeName = "TINYINT")]
        public bool IsSmallProject { get; set; }
    }
}