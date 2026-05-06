using System.ComponentModel.DataAnnotations;

namespace Lab01_Bai3_ASP.Models
{
    public class ProductViewModel
    {
        [Display(Name = "Tên sản phẩm")]
        public string Name { get; set; }

        [Display(Name = "Ảnh sản phẩm")]
        public string ImagePath { get; set; }

        [Display(Name = "Mức giảm giá")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:N0}₫")]
        public decimal DiscountBadge { get; set; }

        [Display(Name = "Trả góp mỗi tháng")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:N0}₫")]
        public decimal MonthlyPrice { get; set; }

        [Display(Name = "Giá gốc")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:N0}₫")]
        public decimal OriginalPrice { get; set; }

        [Display(Name = "Số sao")]
        public double StarRating { get; set; }

        [Display(Name = "Lượt đánh giá")]
        public int ReviewCount { get; set; }

        // --- Các thuộc tính cấu hình (Specs) ---

        [Display(Name = "Màn hình")]
        public string Screen { get; set; }

        [Display(Name = "Camera")]
        public string Camera { get; set; }

        [Display(Name = "Pin")]
        public string Battery { get; set; }

        [Display(Name = "RAM")]
        public string Ram { get; set; }

        [Display(Name = "CPU")]
        public string Cpu { get; set; }

        [Display(Name = "HĐH")]
        public string Os { get; set; }
    }
}
