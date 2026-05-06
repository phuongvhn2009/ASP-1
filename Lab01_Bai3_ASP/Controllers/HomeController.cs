using Lab01_Bai3_ASP.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lab01_Bai3_ASP.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {

            var products = ProductSeeder.GetSampleProducts();

            return View(products);
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
