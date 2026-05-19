namespace Lab04_Bai2.Models
{
    public class Product
    {
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreatedDate { get; set; }

        public long CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
