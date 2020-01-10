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
    public class BrandCategoriesController : Controller
    {
        private readonly JunkoDBContext _context;

        public BrandCategoriesController(JunkoDBContext context)
        {
            _context = context;
        }

        // GET: Control/BrandCategories
        public async Task<IActionResult> Index()
        {
            var junkoDBContext = _context.BrandProductCategories.Include(b => b.Brand).Include("ProductSubCategory.ProductSubCategoryTranslate").OrderBy(x=>x.Brand.Name);
            return View(await junkoDBContext.ToListAsync());
        }

      

        // GET: Control/BrandCategories/Create
        public IActionResult Create()
        {
            ViewData["BrandId"] = new SelectList(_context.Brands.OrderByDescending(x=>x.CreatedAt), "Id", "Name");
            ViewData["ProductSubCategoryId"] = new SelectList(_context.ProductSubCategoryTranslates.Where(x=>x.LanguageId==2).OrderByDescending(x => x.ProductSubCategory.CreatedAt), "ProductSubCategoryId", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,BrandId,ProductSubCategoryId")] BrandProductCategory brandProductCategory)
        {
            if (ModelState.IsValid)
            {
              BrandProductCategory brandProduct=  _context.BrandProductCategories.FirstOrDefault(x => x.ProductSubCategoryId == brandProductCategory.ProductSubCategoryId && x.BrandId == brandProductCategory.BrandId);
                if (brandProduct!=null)
                {
                    TempData["Error"] = "Artiq Bu Brend üçün Kateqoriya seçilib";

                    ViewData["BrandId"] = new SelectList(_context.Brands, "Id", "Name", brandProductCategory.BrandId);
                    ViewData["ProductSubCategoryId"] = new SelectList(_context.ProductCategoryTranslates.Where(x=>x.LanguageId==2), "ProductCategoryId", "Name", brandProductCategory.ProductSubCategoryId);
                    return View(brandProductCategory);
                }
                _context.Add(brandProductCategory);
                await _context.SaveChangesAsync();

                TempData["Success"] = "Brend üçün Kateqoriya uğurla seçildi";
                return RedirectToAction(nameof(Index));
            }
            ViewData["BrandId"] = new SelectList(_context.Brands, "Id", "Name", brandProductCategory.BrandId);
            ViewData["ProductSubCategoryId"] = new SelectList(_context.ProductCategoryTranslates.Where(x => x.LanguageId == 2), "ProductCategoryId", "Name", brandProductCategory.ProductSubCategoryId);
            return View(brandProductCategory);
        }

    

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("error","home");
            }

            var brandProductCategory = await _context.BrandProductCategories
                .Include(b => b.Brand)
                .Include(b => b.ProductSubCategory)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (brandProductCategory == null)
            {
                return RedirectToAction("error", "home");
            }
            _context.BrandProductCategories.Remove(brandProductCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BrandProductCategoryExists(int id)
        {
            return _context.BrandProductCategories.Any(e => e.Id == id);
        }
    }
}
