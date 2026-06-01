using Lab06_Bai3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab06_Bai3.Controllers
{
    public class AccountController : Controller
    {
        private readonly Net107Lab6Bai3Context _context;
        public AccountController(Net107Lab6Bai3Context context)
        {
            _context = context;
        }

        //Form login
        public IActionResult Login()
        {
            return View();
        }

        // Xử lý đăng nhập
        [HttpPost]
        public IActionResult Authenticate(User model)
        {
            // Kiểm tra tài khoản trong database
            var user = _context.Users.FirstOrDefault(u =>
                u.Name == model.Name &&
                u.Password == model.Password);

            if (user != null)
            {
                // Tạo cookie username
                CookieOptions options = new CookieOptions
                {
                    Expires = DateTime.Now.AddDays(7),
                    IsEssential = true
                };

                Response.Cookies.Append("username", user.Name, options);

                // Chuyển hướng về trang chủ
                return RedirectToAction("Index", "Home");
            }

            // Đăng nhập thất bại
            ViewBag.Error = "Sai tên đăng nhập hoặc mật khẩu!";
            return View("Login");
        }

    }
}
