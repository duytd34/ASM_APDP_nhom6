using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASM_APDP_nhom6.Models
{
    public class Grade
    {
        [Key]
        public int Id { get; set; } 

        [Required]
        public int UserId { get; set; } 

        [ForeignKey("UserId")]
        public User User { get; set; } 

        [Required]
        public int CourseId { get; set; } 

        [ForeignKey("CourseId")]
        public Course Course { get; set; } 

        [Required]
        [Range(0, 100)]
        public double Score { get; set; } 

        public string LetterGrade { get; set; } 

        public void CalculateLetterGrade()
        {
            if (Score >= 90)
                LetterGrade = "A";
            else if (Score >= 80)
                LetterGrade = "B";
            else if (Score >= 70)
                LetterGrade = "C";
            else if (Score >= 60)
                LetterGrade = "D";
            else
                LetterGrade = "F";
        }
    }
}
