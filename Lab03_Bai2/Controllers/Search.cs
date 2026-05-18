using System.ComponentModel.DataAnnotations;

namespace Lab03_Bai2.Controllers
{
    public class ProductSearchModel : IValidatableObject
    {
        [Display(Name = "Tên sản phẩm")]
        [MaxLength(100, ErrorMessage = "Tên sản phẩm không được vượt quá 100 ký tự.")]
        public string? Name { get; set; }

        [Display(Name = "Giá từ")]
        [Range(0, int.MaxValue, ErrorMessage = "Giá từ phải lớn hơn hoặc bằng 0.")]
        public int? MinPrice { get; set; }

        [Display(Name = "Giá đến")]
        [Range(0, int.MaxValue, ErrorMessage = "Giá đến phải lớn hơn hoặc bằng 0.")]
        public int? MaxPrice { get; set; }

        // --------------------------------------------------------
        // Ràng buộc logic liên trường bằng IValidatableObject
        // --------------------------------------------------------
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            // Ràng buộc 1: MinPrice không được âm
            if (MinPrice.HasValue && MinPrice < 0)
            {
                yield return new ValidationResult(
                    "Giá từ không được âm.",
                    new[] { nameof(MinPrice) }
                );
            }

            // Ràng buộc 2: MaxPrice không được âm
            if (MaxPrice.HasValue && MaxPrice < 0)
            {
                yield return new ValidationResult(
                    "Giá đến không được âm.",
                    new[] { nameof(MaxPrice) }
                );
            }

            // Ràng buộc 3: Nếu cả hai có giá trị thì MaxPrice >= MinPrice
            if (MinPrice.HasValue && MaxPrice.HasValue)
            {
                if (MaxPrice < MinPrice)
                {
                    yield return new ValidationResult(
                        "Giá đến phải lớn hơn hoặc bằng Giá từ.",
                        new[] { nameof(MaxPrice) }
                    );
                }
            }

            // Ràng buộc 4: MinPrice không vượt quá 1 tỷ
            if (MinPrice.HasValue && MinPrice > 1_000_000_000)
            {
                yield return new ValidationResult(
                    "Giá từ không được vượt quá 1.000.000.000 VNĐ.",
                    new[] { nameof(MinPrice) }
                );
            }

            // Ràng buộc 5: MaxPrice không vượt quá 1 tỷ
            if (MaxPrice.HasValue && MaxPrice > 1_000_000_000)
            {
                yield return new ValidationResult(
                    "Giá đến không được vượt quá 1.000.000.000 VNĐ.",
                    new[] { nameof(MaxPrice) }
                );
            }
        }
    }
}