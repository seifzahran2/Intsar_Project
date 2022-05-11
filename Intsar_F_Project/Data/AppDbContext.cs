using Intsar_F_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Intsar_F_Project.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
                : base(options)
        {

        }
        public DbSet<CompReg> compRegs { get; set; }
        public DbSet<_Project> projects { get; set; }
        public DbSet<Contact> contacts { get; set; }

    }
}
