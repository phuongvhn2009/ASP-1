using demoo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace demoo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult london()
        {
            return View();
        }

        public IActionResult paris()
        {
            return View();
        }

        public IActionResult tokyo()
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
