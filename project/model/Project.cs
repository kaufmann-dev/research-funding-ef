using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project.model
{
    [Table("PROJECTS")]
    public class Project
    {
        [Column("PROJECT_ID")]
        [Key]
        [DatabaseGenerated((DatabaseGeneratedOption.Identity))]
        public int Id { get; set; }

        [Column("TITLE", TypeName = "VARCHAR(100)")]
        [Required]
        public string Title { get; set; }
        
        [Column("DESCRIPTION", TypeName = "VARCHAR(255)")]
        [Required]
        public string Description { get; set; }
        
        [Column("LEGAL_FOUNDATION", TypeName = "VARCHAR(4)")]
        [Required]
        public ELegalFoundation LegalFoundation { get; set; }
    }
}