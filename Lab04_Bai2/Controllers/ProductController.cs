using Lab04_Bai2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lab04_Bai2.Controllers
{
    public class ProductController : Controller
    {
        private readonly Lab04_bai2Context _context;

        public ProductController(Lab04_bai2Context context)
        {
            _context = context;
        }

        // ===== READ =====
        public IActionResult Index()
        {
            var data = _context.Products.Include(p => p.Category).ToList();
            return View(data);
        }

        // ===== CREATE (GET) =====
        public IActionResult Create()
        {
            ViewBag.Categories = _context.Categories.ToList();
            return View();
        }

        // ===== CREATE (POST) =====
        [HttpPost]
        public IActionResult Create(Product p)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Add(p);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Categories = _context.Categories.ToList();
            return View(p);
        }

        // ===== EDIT (GET) =====
        public IActionResult Edit(long id)
        {
            var p = _context.Products.Find(id);
            if (p == null) return NotFound();

            ViewBag.Categories = _context.Categories.ToList();
            return View(p);
        }

        // ===== EDIT (POST) =====
        [HttpPost]
        public IActionResult Edit(Product p)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Update(p);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Categories = _context.Categories.ToList();
            return View(p);
        }

        // ===== DELETE =====
        public IActionResult Delete(long id)
        {
            var p = _context.Products.Find(id);
            if (p == null) return NotFound();

            _context.Products.Remove(p);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // ===== DETAILS =====
        public IActionResult Details(long id)
        {
            var p = _context.Products
                .Include(p => p.Category)
                .FirstOrDefault(p => p.ProductId == id);

            if (p == null) return NotFound();

            return View(p);
        }
    }
}