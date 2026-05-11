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
            var products = ProductSeeder.GetProducts().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search.Name))
            {
                products = products.Where(p =>
                    p.Name.Contains(search.Name,
                    StringComparison.OrdinalIgnoreCase));
            }

            if (search.MinPrice.HasValue)
            {
                products = products.Where(p =>
                    p.Price >= search.MinPrice.Value);
            }

            if (search.MaxPrice.HasValue)
            {
                products = products.Where(p =>
                    p.Price <= search.MaxPrice.Value);
            }
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
