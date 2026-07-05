using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System.Models
{
        public class Department
        {
            [Key] // Primary Key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int DepartmentId { get; set; } // System Generated

            [Required]
            [MaxLength(100)]
            public string DepartmentName { get; set; } // User Input

            [MaxLength(50)]
            public string? Building { get; set; } // User Input

            [Required]
            [Column(TypeName = "decimal(10,2)")] // Decimal Data Type
            [Range(0, double.MaxValue)]
            public decimal Budget { get; set; } // User Input

            [ForeignKey("HeadInstructor")]
            public int? HeadInstructorId { get; set; } // Foreign Key

            // Navigation Property (1 : 1)===(Department to Instructor)
            public Instructor? HeadInstructor { get; set; }

            // Navigation Property (1 : M)=====(Department to Course)
            public List<Course> Courses { get; set; }
                
        }
    }

