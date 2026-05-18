using Lab03_Bai3.Models;
using Lab3_Bai3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lab3_Bai3.Controllers
{
    public class HomeController : Controller
    {
        public static List<Order> orders = new List<Order>();

        public IActionResult Index(OrderFilterModel filter)
        {
            var result = orders.AsQueryable();

            // Lọc theo ngày bắt đầu
            if (filter != null && filter.StartDate.HasValue)
            {
                result = result.Where(o => o.OrderDate >= filter.StartDate.Value);
            }

            // Lọc theo ngày kết thúc
            if (filter != null && filter.EndDate.HasValue)
            {
                result = result.Where(o => o.OrderDate <= filter.EndDate.Value);
            }

            // Lọc theo trạng thái
            if (filter != null && !string.IsNullOrWhiteSpace(filter.Status))
            {
                result = result.Where(o => o.Status == filter.Status);
            }

            ViewBag.Orders = result.ToList();
            ViewBag.Statuses = new List<string> { "Pending", "Shipping", "Completed", "Cancelled" };
            return View(filter ?? new OrderFilterModel());
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
