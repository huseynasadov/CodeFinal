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
using Junko.Helpers;

namespace Junko.Areas.Control.Controllers
{
    [Area("Control")]
    [Authorize]
    public class ProductPhotoesController : Controller
    {

        private readonly JunkoDBContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ProductPhotoesController(JunkoDBContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: Control/ProductPhotoes
        public async Task<IActionResult> Index()
        {
            var junkoDBContext = _context.ProductPhotos.Include(p => p.Product).OrderByDescending(x=>x.CreatedAt);
            return View(await junkoDBContext.ToListAsync());
        }

       

        // GET: Control/ProductPhotoes/Create
        public IActionResult Create()
        {
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductPhoto productPhoto)
        {
            if (productPhoto.PhotoUpload != null)
            {
                try
                {
                    FileManager fileManager = new FileManager(_webHostEnvironment);
                    productPhoto.Photo = fileManager.Upload(productPhoto.PhotoUpload);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("PhotoUpload", e.Message);
                }
            }
            if (ModelState.IsValid)
            {
                _context.Add(productPhoto);
                await _context.SaveChangesAsync();
                TempData["Success"] = "Məhsul üçün Şəkil Əlavə olundu";
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name", productPhoto.ProductId);
            return View(productPhoto);
        }

        // GET: Control/ProductPhotoes/Edit/5
        public async Task<IActionResult> Edit(int? id, bool status=true)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productPhoto = await _context.ProductPhotos.FindAsync(id);
            if (productPhoto == null)
            {
                return NotFound();
            }
            if (HttpContext.Request.Headers["x-requested-with"] == "XMLHttpRequest")
            {

                productPhoto.Status = status;
                _context.SaveChanges();
                return Json(new { res = true });
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name", productPhoto.ProductId);
            return View(productPhoto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,ProductPhoto productPhoto)
        {
            if (id != productPhoto.Id)
            {
                return NotFound();
            }
            if (productPhoto.PhotoUpload != null)
            {
                try
                {
                    FileManager fileManager = new FileManager(_webHostEnvironment);
                    productPhoto.Photo = fileManager.Upload(productPhoto.PhotoUpload);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("PhotoUpload", e.Message);
                }
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productPhoto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductPhotoExists(productPhoto.Id))
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
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name", productPhoto.ProductId);
            return View(productPhoto);
        }

    
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productPhoto = await _context.ProductPhotos
                .Include(p => p.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productPhoto == null)
            {
                return NotFound();
            }
            _context.ProductPhotos.Remove(productPhoto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductPhotoExists(int id)
        {
            return _context.ProductPhotos.Any(e => e.Id == id);
        }
    }
}
