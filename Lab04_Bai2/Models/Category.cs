namespace Lab04_Bai2.Models
{
    public class Category
    {
        public long CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string ImageUrl { get; set; }

        public List<Product> Products { get; set; }
    }
}
