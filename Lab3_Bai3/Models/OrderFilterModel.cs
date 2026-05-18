using System.ComponentModel.DataAnnotations;

namespace Lab3_Bai3.Models
{
    public class OrderFilterModel : IValidatableObject
    {
        [Display(Name = "Từ ngày")]
        public DateTime? StartDate { get; set; }

        [Display(Name = "Đến ngày")]
        public DateTime? EndDate { get; set; }
        public string? Status { get; set; }

        // Ràng buộc logic
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            // Ràng buộc 1: EndDate phải lớn hơn hoặc bằng StartDate
            if (StartDate.HasValue && EndDate.HasValue)
            {
                if (EndDate < StartDate)
                {
                    yield return new ValidationResult(
                        "Đến ngày phải lớn hơn hoặc bằng Từ ngày.",
                        new[] { nameof(EndDate) }
                    );
                }
            }
        }
    }
}