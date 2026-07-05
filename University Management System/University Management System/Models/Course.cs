using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System.Models
{
        public class Course
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int CourseId { get; set; } // System Generated

            [Required]
            [MaxLength(10)]
            public string CourseCode { get; set; } // User Input

            [Required]
            [MaxLength(150)]
            public string CourseTitle { get; set; } // User Input

            [Required]
            [Range(1, 6)]
            public int CreditHours { get; set; } // User Input

            [ForeignKey("Department")]
            public int DepartmentId { get; set; } // Foreign Key

            [ForeignKey("Instructor")]
            public int? InstructorId { get; set; } // Foreign Key

            [Required]
            [MaxLength(20)]
            public string SemesterOffered { get; set; } // User Input

            // Navigation Property (Many-to-One)====(Course to Department)
            public Department Department { get; set; }

            // Navigation Property (Many-to-One)====(Course to Instructor)
            public Instructor Instructor { get; set; }

            // Navigation Property (One-to-Many)=====(Course to Enrollment)
            public List<Enrollment> Enrollments { get; set; }
                
        }
}
