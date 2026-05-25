using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Lab05_Bai3.Models;

namespace Lab05_Bai3.Controllers;

public class ProductController : Controller
{
    private readonly AppDbContext _context;

    public ProductController(AppDbContext context)
    {
        _context = context;
    }

    // GET: Product
    public async Task<IActionResult> Index()
    {
        var products = await _context.Products.ToListAsync();
        return View(products);
    }

    // GET: Product/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var product = await _context.Products
            .FirstOrDefaultAsync(m => m.Id == id);
        
        if (product == null)
        {
            return NotFound();
        }

        return View(product);
    }

    // GET: Product/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: Product/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Name,Price,Quantity,Status")] Product product)
    {
        if (ModelState.IsValid)
        {
            _context.Add(product);
            await _context.SaveChangesAsync();
            TempData["SuccessMessage"] = "Thêm mới sản phẩm thành công!";
            return RedirectToAction(nameof(Index));
        }
        return View(product);
    }

    // GET: Product/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var product = await _context.Products.FindAsync(id);
        if (product == null)
        {
            return NotFound();
        }
        return View(product);
    }

    // POST: Product/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Price,Quantity,Status")] Product product)
    {
        if (id != product.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(product);
                await _context.SaveChangesAsync();
                TempData["SuccessMessage"] = "Cập nhật sản phẩm thành công!";
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(product.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }
        return View(product);
    }

    // POST: Product/Delete/5
    // Thay vì dùng Remove() rồi SaveChanges(), chúng ta sử dụng ExecuteDeleteAsync() chỉ với 1 dòng code.
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        // ExecuteDeleteAsync xóa bản ghi trực tiếp trong Database dựa trên điều kiện lọc.
        // Đây là tính năng mạnh mẽ từ EF Core 7+ giúp tăng hiệu năng rõ rệt.
        await _context.Products.Where(p => p.Id == id).ExecuteDeleteAsync();

        TempData["SuccessMessage"] = "Xóa sản phẩm thành công!";
        return RedirectToAction(nameof(Index));
    }

    private bool ProductExists(int id)
    {
        return _context.Products.Any(e => e.Id == id);
    }
}
