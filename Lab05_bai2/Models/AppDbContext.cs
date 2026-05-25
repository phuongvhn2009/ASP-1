using Microsoft.EntityFrameworkCore;

namespace Lab05_bai2.Models
{
    public class AppDbContext : DbContext
    {
        // 1. Hàm khởi tạo (Constructor) nhận vào các cấu hình (options) như Connection String
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // 2. Khai báo các DbSet đại diện cho các bảng trong Cơ sở dữ liệu
        // EF Core Convention: Tên của thuộc tính DbSet (Departments, Employees) sẽ được dùng làm tên BẢNG trong DB
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }

        // 3. Cấu hình Fluent API trong phương thức OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Cấu hình quan hệ: Một Department có nhiều Employee
            // Khóa ngoại là DepartmentId trong bảng Employee
            // Và cấu hình Cascade Delete: Khi xóa Department, toàn bộ Employee liên quan sẽ bị xóa theo
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Department)
                .WithMany(d => d.Employees)
                .HasForeignKey(e => e.DepartmentId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }

}
