using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System.Models
{
    public class Student
    {
        [Key]// Primary Key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; } // System Generated

        [Required]
        [MaxLength(100)]
        public string FullName { get; set; } // User Input

        [Required]
        [MaxLength(150)]
        public string Email { get; set; } // User Input

        [MaxLength(20)]
        public string? PhoneNumber { get; set; } // User Input

        [Required]
        public DateTime DateOfBirth { get; set; } // User Input

        [Required]
        [Range(2000, 2030)]
        public int EnrollmentYear { get; set; } // User Input

        [Range(0.0, 4.0)]
        [Column(TypeName = "decimal(10,2)")] // Decimal Data Type
        public decimal Gpa { get; set; } = 0.0m; // Default Value

        //Navigation Property===(Enrollments M to Student 1)
        public List<Enrollment> Enrollments { get; set; }
        
    
    }
}
    
