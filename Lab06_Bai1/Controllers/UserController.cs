using Lab06_Bai1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab06_Bai1.Controllers
{
    public class UserController(IUserService userService, ILoggingService loggingService, IEmailService emailService) : Controller
    {
        // Hiển thị danh sách người dùng
        public IActionResult Index()
        {
            // Ghi log khi truy cập
            loggingService.Log("User truy cập trang danh sách.");

            // Lấy danh sách người dùng
            var users = userService.GetUsers();

            return View(users);
        }
        // Hiển thị form thêm user
        public IActionResult Create()
        {
            return View();
        }

        // Xử lý thêm user
        [HttpPost]
        public IActionResult Create(string userName)
        {
            if (string.IsNullOrWhiteSpace(userName))
            {
                ViewBag.Error = "Tên người dùng không được để trống.";
                return View();
            }

            // Thêm user
            userService.AddUser(userName);

            // Ghi log
            loggingService.Log($"Đã thêm user: {userName}");

            // Gửi email
            emailService.SendEmail("admin@gmail.com", "Thông báo thêm user", $"User mới được thêm: {userName}");

            return RedirectToAction("Index");
        }
    }

}
