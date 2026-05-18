using System;
using System.Collections.Generic;

namespace Lab04_Bai1.Models;

public partial class Product
{
    public long ProductId { get; set; }

    public string Name { get; set; } = null!;

    public string? Category { get; set; }

    public string? Color { get; set; }

    public decimal UnitPrice { get; set; }

    public long AvailableQuantity { get; set; }

    public DateTime CratedDate { get; set; }
}
