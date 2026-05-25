using Microsoft.EntityFrameworkCore;
namespace Lab05_Bai1.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Information> Informations { get; set; }
    }
}
