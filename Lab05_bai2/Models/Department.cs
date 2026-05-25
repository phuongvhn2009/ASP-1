namespace Lab05_bai2.Models
{
    public class Department
    {
        // EF Core tự hiểu thuộc tính tên 'Id' hoặc 'DepartmentId' sẽ là Khóa chính (Primary Key)
        public int Id { get; set; }
        public string Name { get; set; }

        // Navigation Property: Một phòng ban có danh sách nhiều nhân viên
        public virtual ICollection<Employee> Employees { get; set; }
    }

}
