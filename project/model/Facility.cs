using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project.model {
    [Table(("FACILITIES"))]
    public class Facility {
        [Column("FACILITY_ID", TypeName = "INT")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Column("FACILITY_CODE", TypeName = "VARCHAR(7)")]
        [Required]
        public string FacilityCode { get; set; }
        
        [Column("FACILITY_TITLE", TypeName = "VARCHAR(100)")]
        [Required]
        public string FacilityTitle { get; set; }
        
        [Column("DESCRIPTION", TypeName = "VARCHAR(255)")]
        public string Description { get; set; }
    }
}