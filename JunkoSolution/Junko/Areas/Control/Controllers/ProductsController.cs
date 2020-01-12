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
using Junko.ModelTranslate;

namespace Junko.Areas.Control.Controllers
{
    [Area("Control")]
    [Authorize]
    public class ProductsController : Controller
    {
        private readonly JunkoDBContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ProductsController(JunkoDBContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: Control/Products
        public async Task<IActionResult> Index()
        {
            var junkoDBContext = _context.Products.Include("BrandProductCategory.Brand").Include("BrandProductCategory.ProductSubCategory.ProductSubCategoryTranslate").OrderBy(x=>x.BrandProductCategory.Brand.Name);
            return View(await junkoDBContext.ToListAsync());
        }

        // GET: Control/Products/Details/5
        public async Task<IActionResult> Details(string slug)
        {
            
            ProductViewModel model = new ProductViewModel
            {
                Product = await _context.Products
                .Include("BrandProductCategory.Brand")
                .Include("BrandProductCategory.ProductSubCategory.ProductSubCategoryTranslate")
                .Include("ProductPhotos")
                .Include("OrderProducts.User")
                .Include("ProperityProducts.Properity.ProperityTranslates")
                .Include("ProductReviews.User")
                .FirstOrDefaultAsync(x => x.Slug == slug),
                ProductTranslates = _context.ProductTranslates.Include("Language").Where(x => x.Product.Slug == slug).ToList()
            };
            if (model.Product == null)
            {
                return RedirectToAction("error","home");
            }

            return View(model);
        }

        // GET: Control/Products/Create
        public IActionResult Create()
        {
            ViewData["BrandProductCategoryId"] = new SelectList(_context.BrandProductCategories.Include("Brand").Include("ProductSubCategory.ProductSubCategoryTranslate"), "Id", "Brand.Name");
            ProductViewModel model = new ProductViewModel { 
            BrandProductCategories= _context.BrandProductCategories.Include("Brand").Include("ProductSubCategory.ProductSubCategoryTranslate").ToList()
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductViewModel model)
        {
           
            if (ModelState.IsValid)
            {
                Product prod = _context.Products.FirstOrDefault(x => x.Name.ToLower() == model.Product.Name.ToLower());
                if (prod!=null)
                {
                    model.BrandProductCategories = _context.BrandProductCategories.Include("Brand").Include("ProductSubCategory.ProductSubCategoryTranslate").ToList();
                    TempData["Error"] = "Bu adda məhsul artıq mövcuddur!";
                    ViewData["BrandProductCategoryId"] = new SelectList(_context.BrandProductCategories, "Id", "Id", model.Product.BrandProductCategoryId);
                    return View(model);
                }
                _context.Add(model.Product);
                await _context.SaveChangesAsync();
                foreach (var product in model.ProductTranslates)
                {
                    product.ProductId = _context.Products.FirstOrDefault(x => x.Name == model.Product.Name && x.CreatedAt == model.Product.CreatedAt).Id;
                    _context.Add(product);
                    await _context.SaveChangesAsync();
                }
                TempData["Success"] = "Yeni Məhsul Yaradıldl";
                return RedirectToAction(nameof(Index));
            }
            model.BrandProductCategories = _context.BrandProductCategories.Include("Brand").Include("ProductSubCategory.ProductSubCategoryTranslate").ToList();
            ViewData["BrandProductCategoryId"] = new SelectList(_context.BrandProductCategories, "Id", "Id", model.Product.BrandProductCategoryId);
            return View(model);
        }

        // GET: Control/Products/Edit/5
        public async Task<IActionResult> Edit(int id,bool status=true)
        {

            ProductViewModel model = new ProductViewModel
            {
                Product = await _context.Products.FirstOrDefaultAsync(x => x.Id == id),
                ProductTranslates = _context.ProductTranslates.Include("Language").Where(x => x.Product.Id == id).ToList(),
                BrandProductCategories = _context.BrandProductCategories.Include("Brand").Include("ProductSubCategory.ProductSubCategoryTranslate").ToList()
            };
            if (model.Product == null)
            {
                return RedirectToAction("error", "home");
            }
            if (HttpContext.Request.Headers["x-requested-with"] == "XMLHttpRequest")
            {
                model.Product.Status = status;
                _context.SaveChanges();
                return Json(new { res = true });
            }
            ViewData["BrandProductCategoryId"] = new SelectList(_context.BrandProductCategories, "Id", "Id", model.Product.BrandProductCategoryId);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                foreach (var item in model.ProductTranslates)
                {

                    if (item.Id!=0)
                    {
                        _context.ProductTranslates.Update(item);
                    }
                    else
                    {
                        _context.ProductTranslates.Add(item);
                    }
                }
                await _context.SaveChangesAsync();
                try
                {
                    model.Product.ModifiedAt = DateTime.Now;
                    _context.Products.Update(model.Product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(model.Product.Id))
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
            ViewData["BrandProductCategoryId"] = new SelectList(_context.BrandProductCategories, "Id", "Id", model.Product.BrandProductCategoryId);
            return View(model);
        }

   

        public async Task<IActionResult> Delete(string slug)
        {
            if (slug == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.AdminManager)
                .Include(p => p.BrandProductCategory)
                .FirstOrDefaultAsync(m => m.Slug == slug);
            if (product == null)
            {
                return NotFound();
            }
            List<ProductTranslate> ProductTranslates = _context.ProductTranslates.Where(x => x.Product.Slug == slug).ToList();
            foreach (var item in ProductTranslates)
            {
                _context.ProductTranslates.Remove(item);
            }
            await _context.SaveChangesAsync();
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(string slug)
        {
            return _context.Products.Any(e => e.Slug == slug);
        }
        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.Id == id);
        }
    }
}
