using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ASM_APDP_nhom6.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; } // PK

        [Required]
        [StringLength(100)]
        public string Name { get; set; } 

        [Required]
        [StringLength(500)]
        public string Description { get; set; } 
        [Required]
        [Range(1, 10)]
        public int Credits { get; set; }

        public List<Grade> Grades { get; set; }
    }
}
