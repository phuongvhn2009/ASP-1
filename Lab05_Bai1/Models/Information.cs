using System.ComponentModel.DataAnnotations;

namespace Lab05_Bai1.Models
{
    public class Information
    {
        [Key] // Đánh dấu là khóa chính
        public int Id { get; set; }
        [Required(ErrorMessage = "Tên công ty không được để trống.")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Tên công ty phải từ 3 đến 200 ký tự.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Giấy phép kinh doanh không được để trống.")]
        // Định dạng ví dụ: chỉ cho phép chữ, số, dấu gạch ngang từ 10 đến 20 ký tự
        [RegularExpression(@"^[0-9A-Za-z-]{10,20}$", ErrorMessage = "Giấy phép không hợp lệ (10-20 ký tự chữ và số).")]
        public string License { get; set; }
        [Required(ErrorMessage = "Ngày thành lập là bắt buộc.")]
        [DataType(DataType.Date)]
        [CustomValidation(typeof(Information), nameof(ValidateEstablishedDate))] // Ràng buộc tùy chỉnh
        public DateTime Established { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = "Doanh thu không được là số âm.")]
        public decimal Revenue { get; set; }
        // Hàm kiểm tra ngày thành lập không được lớn hơn ngày hiện tại
        public static ValidationResult ValidateEstablishedDate(DateTime date, ValidationContext context)
        {
            if (date > DateTime.Now)
            {
                return new ValidationResult("Ngày thành lập không thể ở tương lai.");
            }
            return ValidationResult.Success;
        }
    }
}
