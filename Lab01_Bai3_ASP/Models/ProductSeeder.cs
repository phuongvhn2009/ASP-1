using Lab01_Bai3_ASP.Models;
using System.Collections.Generic;

namespace Lab01_Bai3_ASP.Models
{
    public static class ProductSeeder
    {
        public static List<ProductViewModel> GetSampleProducts()
        {
            return new List<ProductViewModel>
            {
                new ProductViewModel
                {
                    Name = "iPhone 11 Pro Max 64GB",
                    ImagePath = "/images/iphone-11-pro-max-64gb.webp",
                    DiscountBadge = 2000000,
                    MonthlyPrice = 1512000,
                    OriginalPrice = 33990000,
                    StarRating = 5,
                    ReviewCount = 439,
                    Screen = "1242 x 2688 Pixels 6.5 inch",
                    Camera = "Triple 12MP Ultra Wide, Wide, Telephoto",
                    Battery = "Lâu hơn iPhone Xs Max 5h",
                    Ram = "4 GB",
                    Cpu = "Apple A13 Bionic",
                    Os = "iOS 13"
                },
                new ProductViewModel
                {
                    Name = "iPhone 11 Pro Max 256GB",
                    ImagePath = "/images/iphone-11-pro-max-256gb.png",
                    DiscountBadge = 1500000,
                    MonthlyPrice = 1689000,
                    OriginalPrice = 37990000,
                    StarRating = 4,
                    ReviewCount = 67,
                    Screen = "1242 x 2688 Pixels 6.5 inch",
                    Camera = "Triple 12MP Ultra Wide, Wide, Telephoto",
                    Battery = "Lâu hơn iPhone Xs Max 5h",
                    Ram = "4 GB",
                    Cpu = "Apple A13 Bionic",
                    Os = "iOS 13"
                },
                new ProductViewModel
                {
                    Name = "iPhone 11 Pro Max 512GB",
                    ImagePath = "/images/iphone-11-pro-max-512gb.webp",
                    DiscountBadge = 2000000,
                    MonthlyPrice = 1565000,
                    OriginalPrice = 43990000,
                    StarRating = 4.5,
                    ReviewCount = 69,
                    Screen = "1242 x 2688 Pixels 6.5 inch",
                    Camera = "Triple 12MP Ultra Wide, Wide, Telephoto",
                    Battery = "Lâu hơn iPhone Xs Max 5h",
                    Ram = "4 GB",
                    Cpu = "Apple A13 Bionic",
                    Os = "iOS 13"
                },
                
            };
        }
    }
}