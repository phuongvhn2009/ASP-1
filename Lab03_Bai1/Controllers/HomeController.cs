using Lab03_Bai1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lab03_Bai1.Controllers
{
    public class HomeController : Controller
    {
        public static List<Product> Products = new List<Product>
        {
            new Product { Id = 1, Name = "Iphone 5", Description = "Description of Product 1", Price = 100 },
            new Product { Id = 2, Name = "Laptop AI", Description = "Description of Product 2", Price = 200 },
            new Product { Id = 3, Name = "SamSung Galaxy", Description = "Description of Product 3", Price = 300 },

        };
        public IActionResult Index()
        {
            return View(Products);
        }
        public IActionResult Edit()
        {
            return View();
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
