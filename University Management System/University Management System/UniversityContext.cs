using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University_Management_System.Models;
using Microsoft.EntityFrameworkCore;


namespace University_Management_System
{
    public class UniversityContext : DbContext

    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments{ get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Student> Students { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=ALMAZIDI;Database=UniversityDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }

    }
}
