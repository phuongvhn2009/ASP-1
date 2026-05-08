using Lab02_Bai4.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lab02_Bai4.Controllers
{
    public class HomeController : Controller
    {
        public static List<Product> products = new List<Product>();
        
        public IActionResult Index()
        {
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
           products.Add(product);
           return RedirectToAction("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
