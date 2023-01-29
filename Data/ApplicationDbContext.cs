using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentInternalEvaluationSystem.Models;

namespace StudentInternalEvaluationSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<StudentInternalEvaluationSystem.Models.Student> Student { get; set; }
        public DbSet<StudentInternalEvaluationSystem.Models.Teacher> Teacher { get; set; }
        public DbSet<StudentInternalEvaluationSystem.Models.Course> Course { get; set; }
        //public DbSet<StudentInternalEvaluationSystem.Models.Enrollment> Enrollment { get; set; }
        //public DbSet<StudentInternalEvaluationSystem.Models.Department> Department { get; set; }
    }
}