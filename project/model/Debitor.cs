using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project.model
{
    [Table("DEBITORS")]
    public class Debitor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("DEBITOR_ID")]
        public int Id { get; set; }
        
        [Column("NAMER", TypeName = "VARCHAR(50)")]
        [Required]
        public string Name { get; set; }
    }
}