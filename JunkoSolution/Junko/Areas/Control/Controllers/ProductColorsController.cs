using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Junko.DAL;
using Junko.Models;
using Microsoft.AspNetCore.Authorization;

namespace Junko.Areas.Control.Controllers
{
    [Area("Control")]
    [Authorize]
    public class ProductColorsController : Controller
    {
        private readonly JunkoDBContext _context;

        public ProductColorsController(JunkoDBContext context)
        {
            _context = context;
        }

        // GET: Control/ProductColors
        public async Task<IActionResult> Index()
        {
            var junkoDBContext = _context.ProductColors.Include(p => p.Color).Include(p => p.Product).OrderByDescending(x=>x.Product.ModifiedAt);
            return View(await junkoDBContext.ToListAsync());
        }

     
        // GET: Control/ProductColors/Create
        public IActionResult Create()
        {
            ViewData["ColorId"] = new SelectList(_context.Colors.Where(x=>x.Status==true), "Id", "Name");
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductColor productColor)
        {
            if (ModelState.IsValid)
            {
                ProductColor proColor = _context.ProductColors.FirstOrDefault(x => x.ProductId == productColor.ProductId && x.ColorId == productColor.ColorId);
                if (proColor != null)
                {
                    TempData["Error"] = "Artiq Bu Məhsul üçün Rəng seçilib";
                    ViewData["ColorId"] = new SelectList(_context.Colors.Where(x => x.Status == true), "Id", "Name"); 
                    ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name");
                    return View(productColor);
                }
                _context.Add(productColor);
                await _context.SaveChangesAsync();
                TempData["Success"] = "Məhsul üçün Rəng uğurla seçildi";
                return RedirectToAction(nameof(Index));
            }
            ViewData["ColorId"] = new SelectList(_context.Colors.Where(x => x.Status == true), "Id", "Name", productColor.ColorId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name", productColor.ProductId);
            return View(productColor);
        }

     
        // GET: Control/ProductColors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productColor = await _context.ProductColors
                .Include(p => p.Color)
                .Include(p => p.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productColor == null)
            {
                return NotFound();
            }

            _context.ProductColors.Remove(productColor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

      

        private bool ProductColorExists(int id)
        {
            return _context.ProductColors.Any(e => e.Id == id);
        }
    }
}
