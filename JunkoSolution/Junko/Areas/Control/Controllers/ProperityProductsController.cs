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
    public class ProperityProductsController : Controller
    {
        private readonly JunkoDBContext _context;

        public ProperityProductsController(JunkoDBContext context)
        {
            _context = context;
        }

        // GET: Control/ProperityProducts
        public async Task<IActionResult> Index()
        {
            var junkoDBContext = _context.ProperityProducts.Include(p => p.Product).Include("Properity.ProperityTranslates").OrderByDescending(x=>x.CreatedAt);
            return View(await junkoDBContext.ToListAsync());
        }

      
        // GET: Control/ProperityProducts/Create
        public IActionResult Create()
        {
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name");
            ViewData["ProperityId"] = new SelectList(_context.ProperityTranslates.Where(x=>x.LanguageId==2), "ProperityId", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProperityProduct properityProduct)
        {
            if (ModelState.IsValid)
            {
                ProperityProduct properity = _context.ProperityProducts.FirstOrDefault(x => x.ProductId == properityProduct.ProductId && x.ProperityId == properityProduct.ProperityId);
                if (properity!=null)
                {
                    TempData["Error"] = "Artiq Bu Məhsul üçün Xüsusiyyət seçilib";
                    ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name", properityProduct.ProductId);
                    ViewData["ProperityId"] = new SelectList(_context.ProperityTranslates.Where(x => x.LanguageId == 2), "ProperityId", "Name", properityProduct.ProperityId);
                    return View(properityProduct);
                }
                _context.Add(properityProduct);
                await _context.SaveChangesAsync();
                TempData["Success"] = "Məhsul üçün Xüsusiyyət uğurla seçildi";
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name", properityProduct.ProductId);
            ViewData["ProperityId"] = new SelectList(_context.ProperityTranslates.Where(x => x.LanguageId == 2), "ProperityId", "Name", properityProduct.ProperityId);
            return View(properityProduct);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var properityProduct = await _context.ProperityProducts
                .Include(p => p.Product)
                .Include(p => p.Properity)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (properityProduct == null)
            {
                return NotFound();
            }
            _context.ProperityProducts.Remove(properityProduct);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProperityProductExists(int id)
        {
            return _context.ProperityProducts.Any(e => e.Id == id);
        }
    }
}
