namespace Lab03_Bai2.Controllers
{
    public static class ProductSeeder
    {
        public static List<Product> GetProducts()
        {

            return new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Laptop Dell Inspiron",
                Description = "Laptop văn phòng cấu hình ổn định",
                Price = 15990000
            },

            new Product
            {
                Id = 2,
                Name = "MacBook Air M2",
                Description = "Laptop cao cấp dành cho lập trình viên",
                Price = 28990000
            },

            new Product
            {
                Id = 3,
                Name = "Chuột Logitech G102",
                Description = "Chuột gaming phổ biến",
                Price = 450000
            },

            new Product
            {
                Id = 4,
                Name = "Bàn phím cơ AKKO",
                Description = "Bàn phím cơ RGB",
                Price = 1290000
            },

            new Product
            {
                Id = 5,
                Name = "Màn hình LG 24 inch",
                Description = "Màn hình Full HD IPS",
                Price = 3290000
            },

            new Product
            {
                Id = 6,
                Name = "Tai nghe Sony WH-1000XM4",
                Description = "Tai nghe chống ồn cao cấp",
                Price = 6990000
            },

            new Product
            {
                Id = 7,
                Name = "Điện thoại iPhone 15",
                Description = "Điện thoại Apple thế hệ mới",
                Price = 24990000
            },

            new Product
            {
                Id = 8,
                Name = "Samsung Galaxy S24",
                Description = "Điện thoại Android cao cấp",
                Price = 21990000
            },

            new Product
            {
                Id = 9,
                Name = "Ổ cứng SSD Samsung 1TB",
                Description = "SSD tốc độ cao NVMe",
                Price = 2190000
            },

            new Product
            {
                Id = 10,
                Name = "Loa Bluetooth JBL",
                Description = "Loa di động âm thanh mạnh mẽ",
                Price = 1790000
            }
        };

        }
    }
}
