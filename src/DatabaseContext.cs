using Microsoft.EntityFrameworkCore;
using BrekkeDanceCenter.Classes.Entities;

namespace BrekkeDanceCenter.Classes
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options) {}

        public DbSet<Class> Classes { get; set; }

        public DbSet<Course> Courses { get; set; }
    }
}