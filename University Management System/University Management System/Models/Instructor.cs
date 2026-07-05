using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System.Models
{
    
        public class Instructor
        {
            [Key]//Primary Key
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int InstructorId { get; set; } // System Generated

            [Required]
            [MaxLength(100)]
            public string FullName { get; set; } // User Input

            [Required]
            [MaxLength(150)]
            public string Email { get; set; } // User Input

            [MaxLength(20)]
            public string ? OfficeNumber { get; set; } // User Input

            [Required]
            public DateTime HireDate { get; set; } // User Input

            [Required]
            [Column(TypeName = "decimal(10,2)")] // Decimal Data Type
            [Range(0.01, double.MaxValue)]
            public decimal Salary { get; set; } // User Input

            [Required]
            [MaxLength(50)]
            public string AcademicTitle { get; set; } // User Input

            // Navigation Properties====(Course M to Instructor 1)

            public List<Course> Courses { get; set; }
       


    }
    
}

