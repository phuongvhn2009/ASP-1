using Lab03_Bai2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lab03_Bai2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Search([FromQuery] ProductSearchModel search)
        {
            // Validate ràng buộc logic liên trường
            if (search.MinPrice.HasValue && search.MaxPrice.HasValue
                && search.MaxPrice < search.MinPrice)
            {
                ModelState.AddModelError("MaxPrice",
                    "Giá đến phải lớn hơn hoặc bằng Giá từ.");
                ViewBag.Products = new List<Product>();
                return View(search);
            }

            var products = ProductSeeder.GetProducts().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search.Name))
                products = products.Where(p =>
                    p.Name.Contains(search.Name.Trim(),          // ← thêm Trim()
                        StringComparison.OrdinalIgnoreCase));

            if (search.MinPrice.HasValue)
                products = products.Where(p => p.Price >= search.MinPrice.Value);

            if (search.MaxPrice.HasValue)
                products = products.Where(p => p.Price <= search.MaxPrice.Value);

            ViewBag.Products = products.ToList();
            return View(search);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
