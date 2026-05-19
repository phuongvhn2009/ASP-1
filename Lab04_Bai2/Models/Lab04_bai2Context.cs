namespace Lab04_Bai2.Models
{
    using Microsoft.EntityFrameworkCore;

    public class Lab04_bai2Context : DbContext
    {
        public Lab04_bai2Context(DbContextOptions<Lab04_bai2Context> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
