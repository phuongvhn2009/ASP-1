using Lab06_Bai2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lab06_Bai2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.SetString("Name", "Vũ Hoàng Nhật Phương");
            HttpContext.Session.SetString("Email", "Phuongvhntb01940@gmail.com");

            // Tạo đối tượng User và lưu vào Session
            var user = new User
            {
                Name = "Vũ Hoàng Nhật Phương (Object)",
                Email = "Phuongvhntb01940@gmail.com"
            };
            HttpContext.Session.SetObject("User", user);

            ViewBag.User = HttpContext.Session.GetObject<User>("User");
            return View();
        }
        public IActionResult About()
        {
            ViewBag.Name = HttpContext.Session.GetString("Name");
            ViewBag.Email = HttpContext.Session.GetString("Email");
            
            // Lấy đối tượng User từ Session và truyền vào ViewBag
            ViewBag.User = HttpContext.Session.GetObject<User>("User");
           
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
