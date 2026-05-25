using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab05_Bai3.Models;

[Table("Products")]
public class Product
{
    [Key]
    [Display(Name = "Mã sản phẩm")]
    public int Id { get; set; }

    [StringLength(250)]
    [Display(Name = "Tên sản phẩm")]
    public string? Name { get; set; }

    [Column(TypeName = "money")]
    [Display(Name = "Giá sản phẩm")]
    public decimal? Price { get; set; }

    [Display(Name = "Số lượng")]
    public int? Quantity { get; set; }

    [Display(Name = "Trạng thái")]
    public bool? Status { get; set; }
}
