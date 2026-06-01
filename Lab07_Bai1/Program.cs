using Lab07_Bai1.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore; // 1. BẮT BUỘC phải thêm thư viện này để dùng .UseSqlServer

var builder = WebApplication.CreateBuilder(args);

// 2. LẤY CHUỖI KẾT NỐI từ appsettings.json
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// 3. ĐĂNG KÝ AppDbContext vào hệ thống (Đây là đoạn bạn đang thiếu)
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionString)); // Hoặc .UseSqlite nếu bạn dùng SQLite

// Add services to the container.
builder.Services.AddControllersWithViews();

// Cấu hình Identity kết nối với AppDbContext
builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
{
    options.Password.RequiredLength = 8;
    options.SignIn.RequireConfirmedAccount = false;
})
    .AddEntityFrameworkStores<AppDbContext>(); // Đoạn này sẽ hết lỗi vì AppDbContext đã được đăng ký ở trên
builder.Services.AddRazorPages();

var app = builder.Build();
app.MapRazorPages();
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

app.Run();