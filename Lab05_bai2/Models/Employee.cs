namespace Lab05_bai2.Models
{
    public class Employee
    {
        public int Id { get; set; } // Khóa chính (Primary Key)
        public string Name { get; set; }
        public string Designation { get; set; }

        // Foreign Key Convention: Tên kết hợp [Tên_Class_Cha] + [Tên_Khóa_Chính_Cha] 
        // EF Core sẽ tự động nhận diện 'DepartmentId' là Khóa ngoại (Foreign Key) liên kết tới Department
        public int DepartmentId { get; set; }

        // Navigation Property: Một nhân viên chỉ thuộc về một phòng ban duy nhất
        public virtual Department Department { get; set; }
    }

}
