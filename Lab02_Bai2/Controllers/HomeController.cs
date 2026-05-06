using Lab02_Bai2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lab02_Bai2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["header"] = " thong tin chi tiet sinh vien";
            var student = new Student()
            { 
                StudentId = 1,
                Name = "nam dinh 2 ngon",
                Brand = "Computer Science",
                Section = "cs2"
            };
            ViewData["Student"] = student;
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
