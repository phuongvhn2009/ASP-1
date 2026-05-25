using Lab05_bai2.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

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
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

// Tự động migration và seed dữ liệu mẫu
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<AppDbContext>();
        // Tự động tạo database và chạy các Migration chưa áp dụng
        context.Database.Migrate();

        // Seed dữ liệu mẫu nếu database trống
        if (!context.Departments.Any())
        {
            var itDept = new Department { Name = "IT Department" };
            var hrDept = new Department { Name = "Human Resources" };

            context.Departments.AddRange(itDept, hrDept);
            context.SaveChanges(); // Lưu để sinh Id cho các Department

            context.Employees.AddRange(
                new Employee { Name = "Nguyen Van A", Designation = "Senior Developer", DepartmentId = itDept.Id },
                new Employee { Name = "Tran Thi B", Designation = "QA Engineer", DepartmentId = itDept.Id },
                new Employee { Name = "Le Van C", Designation = "HR Manager", DepartmentId = hrDept.Id }
            );
            context.SaveChanges();
        }
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "Đã xảy ra lỗi khi tạo database hoặc seed dữ liệu mẫu.");
    }
}

app.Run();
