using Microsoft.EntityFrameworkCore;

namespace Visual_Programming_Semester_Project.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Models.User> User { get; set; } = default!;
    }
}
