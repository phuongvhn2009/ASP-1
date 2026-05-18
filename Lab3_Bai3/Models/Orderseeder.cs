using Lab03_Bai3.Models;

namespace Lab03_Bai3.Data
{
    public static class OrderSeeder
    {
        public static List<Order> GetOrders()
        {
            return new List<Order>
            {
                new Order
                {
                    OrderId = 1,
                    CustomerName = "Nguyen Van An",
                    OrderDate = new DateTime(2026, 1, 5),
                    Status = "Pending"
                },

                new Order
                {
                    OrderId = 2,
                    CustomerName = "Tran Thi Bich",
                    OrderDate = new DateTime(2026, 1, 8),
                    Status = "Completed"
                },

                new Order
                {
                    OrderId = 3,
                    CustomerName = "Le Minh Quan",
                    OrderDate = new DateTime(2026, 1, 10),
                    Status = "Cancelled"
                },

                new Order
                {
                    OrderId = 4,
                    CustomerName = "Pham Gia Bao",
                    OrderDate = new DateTime(2026, 1, 12),
                    Status = "Shipping"
                },

                new Order
                {
                    OrderId = 5,
                    CustomerName = "Vo Thanh Tung",
                    OrderDate = new DateTime(2026, 1, 15),
                    Status = "Completed"
                },

                new Order
                {
                    OrderId = 6,
                    CustomerName = "Do Khanh Linh",
                    OrderDate = new DateTime(2026, 1, 18),
                    Status = "Pending"
                },

                new Order
                {
                    OrderId = 7,
                    CustomerName = "Hoang Minh Duc",
                    OrderDate = new DateTime(2026, 1, 20),
                    Status = "Shipping"
                },

                new Order
                {
                    OrderId = 8,
                    CustomerName = "Bui Thu Trang",
                    OrderDate = new DateTime(2026, 1, 22),
                    Status = "Completed"
                },

                new Order
                {
                    OrderId = 9,
                    CustomerName = "Dang Quoc Huy",
                    OrderDate = new DateTime(2026, 1, 25),
                    Status = "Cancelled"
                },

                new Order
                {
                    OrderId = 10,
                    CustomerName = "Phan Ngoc Mai",
                    OrderDate = new DateTime(2026, 1, 28),
                    Status = "Pending"
                }
            };
        }
    }
}