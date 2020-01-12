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
using Microsoft.AspNetCore.Hosting;
using Junko.Areas.Control.ViewModels;
using Junko.Helpers;
using Junko.ModelTranslate;

namespace Junko.Areas.Control.Controllers
{
    [Area("Control")]
    [Authorize]
    public class ProductSubCategoriesController : Controller
    {
        private readonly JunkoDBContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ProductSubCategoriesController(JunkoDBContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: Control/ProductSubCategories
        public async Task<IActionResult> Index()
        {
            var junkoDBContext = _context.ProductSubCategories.Include(p => p.AdminManager).Include("ProductCategory.ProductCategoryTranslate").OrderByDescending(x => x.ModifiedAt).ThenByDescending(x=>x.CreatedAt);
            return View(await junkoDBContext.ToListAsync());
        }

        // GET: Control/ProductSubCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ProductSubCategoryViewModel model = new ProductSubCategoryViewModel
            {
                ProductSubCategory = await _context.ProductSubCategories.Include("ProductCategory.ProductCategoryTranslate").FirstOrDefaultAsync(x => x.Id == id),
                ProductSubCategoryTranslates = _context.ProductSubCategoryTranslates.Include("Language").Where(x => x.ProductSubCategoryId == id).ToList()
            };
            if (model.ProductSubCategory == null)
            {
                return NotFound();
            }

            return View(model);
        }

        // GET: Control/ProductSubCategories/Create
        public IActionResult Create()
        {
            ViewData["ProductCategoryId"] = new SelectList(_context.ProductCategoryTranslates.Where(x=>x.LanguageId==2), "ProductCategoryId", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductSubCategoryViewModel model)
        {
            if (_context.ProductSubCategoryTranslates.Any(x=>x.Name.ToLower()==model.ProductSubCategoryTranslates[1].Name.ToLower()))
            {
                ViewData["AdminManagerId"] = new SelectList(_context.AdminManagers, "Id", "Email", model.ProductSubCategory.AdminManagerId);
                ViewData["ProductCategoryId"] = new SelectList(_context.ProductCategories, "Id", "Id", model.ProductSubCategory.ProductCategoryId);
                TempData["Error"] = "Bu adda Alt kateqoriya mövcuddur!";
                return View(model);
            }
            if (model.ProductSubCategory.PhotoUpload != null)
            {
                try
                {
                    FileManager fileManager = new FileManager(_webHostEnvironment);
                    model.ProductSubCategory.Photo = fileManager.Upload(model.ProductSubCategory.PhotoUpload);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("PhotoUpload", e.Message);
                }
            }
            if (ModelState.IsValid)
            {
                model.ProductSubCategory.CreatedAt = DateTime.Now;
                model.ProductSubCategory.ModifiedAt = DateTime.Now;
                model.ProductSubCategory.Status = true;
                _context.Add(model.ProductSubCategory);
                await _context.SaveChangesAsync();
                foreach (var productSubCategory in model.ProductSubCategoryTranslates)
                {
                    productSubCategory.ProductSubCategoryId = _context.ProductSubCategories.FirstOrDefault(x => x.Photo == model.ProductSubCategory.Photo && x.CreatedAt == model.ProductSubCategory.CreatedAt).Id;
                    _context.Add(productSubCategory);
                    await _context.SaveChangesAsync();
                }
                TempData["Success"] = "Yeni Alt kateqoriya yaradıldl";
                return RedirectToAction(nameof(Index));
            }
            ViewData["AdminManagerId"] = new SelectList(_context.AdminManagers, "Id", "Email", model.ProductSubCategory.AdminManagerId);
            ViewData["ProductCategoryId"] = new SelectList(_context.ProductCategories, "Id", "Id", model.ProductSubCategory.ProductCategoryId);
            return View(model);
        }

        // GET: Control/ProductSubCategories/Edit/5
        public async Task<IActionResult> Edit(int? id, bool status=true)
        {
            if (id == null)
            {
                return NotFound();
            }
            ProductSubCategoryViewModel model = new ProductSubCategoryViewModel
            {
                ProductSubCategory = await _context.ProductSubCategories.FirstOrDefaultAsync(x => x.Id == id),
                ProductSubCategoryTranslates = _context.ProductSubCategoryTranslates.Include("Language").Where(x => x.ProductSubCategoryId == id).ToList()
            };
            if (model.ProductSubCategory == null)
            {
                return NotFound();
            }
            if (HttpContext.Request.Headers["x-requested-with"] == "XMLHttpRequest")
            {

                model.ProductSubCategory.Status = status;
                _context.SaveChanges();
                return Json(new { res = true });
            }
            ViewData["AdminManagerId"] = new SelectList(_context.AdminManagers, "Id", "Email", model.ProductSubCategory.AdminManagerId);
            ViewData["ProductCategoryId"] = new SelectList(_context.ProductCategoryTranslates.Where(x => x.LanguageId == 2), "ProductCategoryId", "Name",model.ProductSubCategory.Id);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ProductSubCategoryViewModel model)
        {
            if (id != model.ProductSubCategory.Id)
            {
                return NotFound();
            }
            if (model.ProductSubCategory.PhotoUpload != null)
            {
                try
                {
                    FileManager fileManager = new FileManager(_webHostEnvironment);
                    model.ProductSubCategory.Photo = fileManager.Upload(model.ProductSubCategory.PhotoUpload);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("PhotoUpload", e.Message);
                }
            }
            if (ModelState.IsValid)
            {
                foreach (var item in model.ProductSubCategoryTranslates)
                {
                    item.ProductSubCategoryId = id;
                    _context.ProductSubCategoryTranslates.Update(item);
                }
                await _context.SaveChangesAsync();
                try
                {
                    model.ProductSubCategory.ModifiedAt = DateTime.Now;
                    _context.ProductSubCategories.Update(model.ProductSubCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductSubCategoryExists(model.ProductSubCategory.Id))
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
            ViewData["AdminManagerId"] = new SelectList(_context.AdminManagers, "Id", "Email", model.ProductSubCategory.AdminManagerId);
            ViewData["ProductCategoryId"] = new SelectList(_context.ProductCategories, "Id", "Id", model.ProductSubCategory.ProductCategoryId);
            return View(model);
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var productSubCategory = await _context.ProductSubCategories
                .Include(p => p.AdminManager)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productSubCategory == null)
            {
                return NotFound();
            }
            List<ProductSubCategoryTranslate> ProductSubCategoryTranslates = _context.ProductSubCategoryTranslates.Where(x => x.ProductSubCategoryId == id).ToList();
            foreach (var item in ProductSubCategoryTranslates)
            {
                _context.ProductSubCategoryTranslates.Remove(item);
            }
            await _context.SaveChangesAsync();
            _context.ProductSubCategories.Remove(productSubCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductSubCategoryExists(int id)
        {
            return _context.ProductSubCategories.Any(e => e.Id == id);
        }
    }
}
