using Microsoft.EntityFrameworkCore;

namespace CourseEnrollmentApp2.Domain
{
    class CourseEnrollmentAppContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=CourseEnrollmentDB10;Trusted_Connection=True;");
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=CourseEnrollmentDB10;Trusted_Connection=True;");
        }
    }
}