using System.Data.Entity;

namespace EfCodeFirstStudentApp
{
    public class SchoolContext : DbContext
    {
        // Uses the "SchoolContext" connection string from App.config
        public SchoolContext() : base("SchoolContext") { }

        public DbSet<Student> Students { get; set; } = null!;
    }
}
