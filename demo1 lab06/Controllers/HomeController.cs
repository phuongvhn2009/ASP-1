using demo1_lab06.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace demo1_lab06.Controllers
{
    
    public class HomeController : Controller
    {
        private ImessageService _messageService;

        public HomeController(ImessageService messageService)
        {
            _messageService = messageService;
        }

        public IActionResult Index()
        {
            _messageService.Send("Hello, this is a test message from HomeController!");
            return View();
        }

        public IActionResult Privacy()
        {
            _messageService.Send("Hello, this is a test message from Privacy action!");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
