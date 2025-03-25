using ASM_APDP_nhom6.Models;
using Microsoft.EntityFrameworkCore;


namespace ASM_APDP_nhom6.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
