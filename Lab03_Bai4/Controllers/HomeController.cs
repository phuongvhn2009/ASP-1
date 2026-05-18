using Lab03_Bai4.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lab03_Bai4.Controllers
{
    public class HomeController : Controller
    {
        public static List<Order> Orders = new List<Order>();
        public IActionResult Index()
        {
            return View(Orders);
        }
        public IActionResult Create()
        {
            Order order = new Order();
            order.OrderDate = DateTime.Now;
            order.OrderDetails.Add(new OrderDetail());
            order.OrderDetails.Add(new OrderDetail());
            order.OrderDetails.Add(new OrderDetail());
            return View();
        }

        [HttpPost]
        public IActionResult Create(Order order)
        {
            int maxoderid = Orders.Count > 0 ? Orders.Max(o => o.OrderId) : 0;
            order.OrderId = maxoderid + 1;
            Orders.Add(order);
            return RedirectToAction("Index");
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
