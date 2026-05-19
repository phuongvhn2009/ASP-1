using Lab04_Bai2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Lab04_Bai2.Controllers
{
    public class HomeController : Controller
    {
        private readonly Lab04_bai2Context _context;

        public HomeController(Lab04_bai2Context context)
        {
            _context = context;
        }

        // Trang Index (hiển thị category + product)
        public IActionResult Index()
        {
            var categories = _context.Categories.ToList();
            var products = _context.Products.Include(p => p.Category).ToList();

            ViewBag.Categories = categories;
            return View(products);
        }

        // Trang chi tiết
        public IActionResult Details(long id)
        {
            var product = _context.Products
                .Include(p => p.Category)
                .FirstOrDefault(p => p.ProductId == id);

            if (product == null)
                return NotFound();

            return View(product);
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
