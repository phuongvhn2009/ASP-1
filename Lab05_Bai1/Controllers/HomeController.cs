using Lab05_Bai1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lab05_Bai1.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var informations = _context.Informations.ToList();
            return View(informations);
        }

        public IActionResult Create()
        {
            Information info = new Information
            {
                Name = "Tech Company",
                License = "MIT",
                Established = new DateTime(2010, 1, 1),
                Revenue = 1000000m

            };
            _context.Informations.Add(info);
            _context.SaveChanges();
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
