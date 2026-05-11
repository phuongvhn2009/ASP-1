using Lab03_Bai1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lab03_Bai1.Controllers
{
    public class HomeController : Controller
    {
        public static List<Product> Products = new List<Product>
        {
            new Product { Id = 1, Name = "Iphone 5", Description = "Description of Product 1", Price = 100 },
            new Product { Id = 2, Name = "Laptop AI", Description = "Description of Product 2", Price = 200 },
            new Product { Id = 3, Name = "SamSung Galaxy", Description = "Description of Product 3", Price = 300 },

        };
        public IActionResult Index()
        {
            return View(Products);
        }
        // Hiển thị form chỉnh sửa sản phẩm
        public IActionResult Edit(int id)
        {
            var product = Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
        // Xử lý POST request để cập nhật thông tin sản phẩm
        [HttpPost]
        public IActionResult Update([FromForm] Product updatedProduct)
        {
            var product = Products.FirstOrDefault(p => p.Id == updatedProduct.Id);
            if (product == null)
            {
                return NotFound();
            }
            // Cập nhật thông tin sản phẩm
            product.Name = updatedProduct.Name;
            product.Description = updatedProduct.Description;
            product.Price = updatedProduct.Price;
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
