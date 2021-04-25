using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project.model
{
    [Table("REQUEST_FUNDING_PROJECT")]
    public class RequestFundingProject : Project
    {
        [Required]
        [Column("IS_FFW_SPONSORED", TypeName = "TINYINT")]
        public bool IsFFWsponsored { get; set; }

        [Required]
        [Column("IS_FFG_SPONSORED", TypeName = "TINYINT")]
        public bool FFGsponsored { get; set; }

        [Required]
        [Column("IS_EU_SPONSORED", TypeName = "TINYINT")]
        public bool EUsponsored { get; set; }
    }
}