using Lab05_Bai3.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Register DbContext with SQL Server
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Automatically create database and seed data on startup
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<AppDbContext>();
        context.Database.EnsureCreated();

        // Seeding programmatically without explicit IDs to let database manage Identity
        if (!context.Products.Any())
        {
            context.Products.AddRange(
                new Product { Name = "iPhone 15 Pro Max", Price = 30000000m, Quantity = 10, Status = true },
                new Product { Name = "Samsung Galaxy S24 Ultra", Price = 28000000m, Quantity = 8, Status = true },
                new Product { Name = "MacBook Pro M3", Price = 45000000m, Quantity = 5, Status = true },
                new Product { Name = "Dell XPS 13", Price = 35000000m, Quantity = 4, Status = false },
                new Product { Name = "iPad Air 5", Price = 15000000m, Quantity = 12, Status = true }
            );
            context.SaveChanges();
        }
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "Đã xảy ra lỗi khi tạo cơ sở dữ liệu.");
    }
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Product}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();
