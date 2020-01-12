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
using Junko.Areas.Control.ViewModels;
using Junko.Helpers;
using Microsoft.AspNetCore.Hosting;
using Junko.ModelTranslate;

namespace Junko.Areas.Control.Controllers
{
    [Area("Control")]
    [Authorize]
    public class ProductCategoriesController : Controller
    {
        private readonly JunkoDBContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ProductCategoriesController(JunkoDBContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: Control/ProductCategories
        public async Task<IActionResult> Index()
        {
            var junkoDBContext = _context.ProductCategories.Include(p => p.AdminManager).Include("ProductCategoryTranslate").OrderByDescending(x=>x.ModifiedAt);
            return View(await junkoDBContext.ToListAsync());
        }

        // GET: Control/ProductCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ProductCategoryViewModel model = new ProductCategoryViewModel
            {
                ProductCategory = await _context.ProductCategories.FirstOrDefaultAsync(x => x.Id == id),
                ProductCategoryTranslates = _context.ProductCategoryTranslates.Include("Language").Where(x => x.ProductCategoryId == id).ToList()
            };
            if (model.ProductCategory == null)
            {
                return NotFound();
            }

            return View(model);
        }

        // GET: Control/ProductCategories/Create
        public IActionResult Create()
        {
           
            ViewData["AdminManagerId"] = new SelectList(_context.AdminManagers, "Id", "Email");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductCategoryViewModel model)
        {
            if (model.ProductCategory.PhotoUpload != null)
            {
                try
                {
                    FileManager fileManager = new FileManager(_webHostEnvironment);
                    model.ProductCategory.Photo = fileManager.Upload(model.ProductCategory.PhotoUpload);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("PhotoUpload", e.Message);
                }
            }
            if (ModelState.IsValid)
            {
                if (_context.ProductCategoryTranslates.Any(x => x.Name.ToLower() == model.ProductCategoryTranslates[1].Name.ToLower()))
                {
                    TempData["Error"] = "Mu adda Kateqoriya mövcuddur!";
                    ViewData["AdminManagerId"] = new SelectList(_context.AdminManagers, "Id", "Email", model.ProductCategory.AdminManagerId);
                    return View(model);

                }
                model.ProductCategory.CreatedAt = DateTime.Now;
                model.ProductCategory.ModifiedAt = DateTime.Now;
                model.ProductCategory.Status = true;
                _context.Add(model.ProductCategory);
                await _context.SaveChangesAsync();
                foreach (var productCategory in model.ProductCategoryTranslates)
                {
                    productCategory.ProductCategoryId =_context.ProductCategories.FirstOrDefault(x=>x.Photo==model.ProductCategory.Photo && x.CreatedAt==model.ProductCategory.CreatedAt).Id ;
                    _context.Add(productCategory);
                    await _context.SaveChangesAsync();
                }
                TempData["Success"] = "Yeni Məhsul yaradıldl";
                return RedirectToAction(nameof(Index));
            }
            ViewData["AdminManagerId"] = new SelectList(_context.AdminManagers, "Id", "Email", model.ProductCategory.AdminManagerId);
            return View(model);
        }

        // GET: Control/ProductCategories/Edit/5
        public async Task<IActionResult> Edit(int? id,bool status=true)
        {
            if (id == null)
            {
                return NotFound();
            }
            ProductCategoryViewModel model = new ProductCategoryViewModel
            {
                ProductCategory = await _context.ProductCategories.FirstOrDefaultAsync(x => x.Id == id),
                ProductCategoryTranslates = _context.ProductCategoryTranslates.Include("Language").Where(x => x.ProductCategoryId == id).ToList()
            };
            if (model.ProductCategory == null)
            {
                return NotFound();
            }
            if (HttpContext.Request.Headers["x-requested-with"] == "XMLHttpRequest")
            {

                model.ProductCategory.Status = status;
                _context.SaveChanges();
                return Json(new { res = true });
            }
            ViewData["AdminManagerId"] = new SelectList(_context.AdminManagers, "Id", "Email", model.ProductCategory.AdminManagerId);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ProductCategoryViewModel model)
        {
            if (id != model.ProductCategory.Id)
            {
                return NotFound();
            }
            if (model.ProductCategory.PhotoUpload != null)
            {
                try
                {
                    FileManager fileManager = new FileManager(_webHostEnvironment);
                    model.ProductCategory.Photo = fileManager.Upload(model.ProductCategory.PhotoUpload);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("PhotoUpload", e.Message);
                }
            }

            if (ModelState.IsValid)
            {
                foreach (var item in model.ProductCategoryTranslates)
                {
                    item.ProductCategoryId = id;
                    _context.ProductCategoryTranslates.Update(item);
                }
                await _context.SaveChangesAsync();
                try
                {
                    model.ProductCategory.ModifiedAt = DateTime.Now;
                    _context.ProductCategories.Update(model.ProductCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductCategoryExists(model.ProductCategory.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                TempData["Success"] = "Dəyişiklik uğurla başa çatdı";
                return RedirectToAction(nameof(Index));
            }
            ViewData["AdminManagerId"] = new SelectList(_context.AdminManagers, "Id", "Email", model.ProductCategory.AdminManagerId);
            return View(model);
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productCategory = await _context.ProductCategories
                .Include(p => p.AdminManager)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productCategory == null)
            {
                return NotFound();
            }
            List<ProductCategoryTranslate> ProductCategoryTranslates = _context.ProductCategoryTranslates.Where(x => x.ProductCategoryId == id).ToList();
            foreach (var item in ProductCategoryTranslates)
            {
                _context.ProductCategoryTranslates.Remove(item);
            }
           await _context.SaveChangesAsync();
            _context.ProductCategories.Remove(productCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductCategoryExists(int id)
        {
            return _context.ProductCategories.Any(e => e.Id == id);
        }
    }
}
