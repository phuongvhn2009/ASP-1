using Microsoft.EntityFrameworkCore;

namespace Lab05_Bai3.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Seed initial data
        modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, Name = "iPhone 15 Pro Max", Price = 30000000m, Quantity = 10, Status = true },
            new Product { Id = 2, Name = "Samsung Galaxy S24 Ultra", Price = 28000000m, Quantity = 8, Status = true },
            new Product { Id = 3, Name = "MacBook Pro M3", Price = 45000000m, Quantity = 5, Status = true },
            new Product { Id = 4, Name = "Dell XPS 13", Price = 35000000m, Quantity = 4, Status = false },
            new Product { Id = 5, Name = "iPad Air 5", Price = 15000000m, Quantity = 12, Status = true }
        );
    }
}
