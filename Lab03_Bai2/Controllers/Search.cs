namespace Lab03_Bai2.Controllers
{
    public class ProductSearchModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int? MinPrice { get; set; }
        public int? MaxPrice { get; set; }
    }
}
