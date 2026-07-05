using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System.Models
{
    public class Enrollment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EnrollmentId { get; set; } // System Generated

        [ForeignKey("Student")]
        public int StudentId { get; set; } // Foreign Key

        [ForeignKey("Course")]
        public int CourseId { get; set; } // Foreign Key

        [Required]
        public DateTime EnrollmentDate { get; set; } // User Input

        [MaxLength(2)]
        public string? FinalGrade { get; set; } // User Input

        [Required]
        [MaxLength(20)]
        public string Status { get; set; } = "In Progress"; // Default Value

        // Navigation Property (Many-to-One)====(Enrollment to Student)
        public Student Student { get; set; }

        // Navigation Property (Many-to-One)====(Enrollment to Course)
        public Course Course { get; set; }
    }
}