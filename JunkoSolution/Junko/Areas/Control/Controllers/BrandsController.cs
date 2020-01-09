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

namespace Junko.Areas.Control.Controllers
{
    [Area("Control")]
    [Authorize]
    public class BrandsController : Controller
    {
        private readonly JunkoDBContext _context;

        public BrandsController(JunkoDBContext context)
        {
            _context = context;
        }

        // GET: Control/Brands
        public async Task<IActionResult> Index()
        {
            var junkoDBContext = _context.Brands.Include(b => b.AdminManager).OrderByDescending(x=>x.CreatedAt);
            return View(await junkoDBContext.ToListAsync());
        }

        

        // GET: Control/Brands/Create
        public IActionResult Create()
        {
            ViewData["AdminManagerId"] = new SelectList(_context.AdminManagers, "Id", "Email");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Slug,Status,CreatedAt,Id,AdminManagerId,ModifiedAt")] Brand brand)
        {
            if (ModelState.IsValid)
            {
                _context.Add(brand);
                await _context.SaveChangesAsync();
                TempData["Success"] = "Yeni Brend uğurla yaradıldı";
                return RedirectToAction(nameof(Index));
            }
            ViewData["AdminManagerId"] = new SelectList(_context.AdminManagers, "Id", "Email", brand.AdminManagerId);
            return View(brand);
        }

        // GET: Control/Brands/Edit/5
        public async Task<IActionResult> Edit(int? id, bool status)
        {
            if (id == null)
            {
                return NotFound();
            }

            var brand = await _context.Brands.FindAsync(id);
            if (brand == null)
            {
                return NotFound();
            }

            if (HttpContext.Request.Headers["x-requested-with"] == "XMLHttpRequest") {

                brand.Status = status;
                _context.SaveChanges();
                return Json(new { res = true });
            }
            return View(brand);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Slug,Status,CreatedAt,Id,AdminManagerId,ModifiedAt")] Brand brand)
        {
            if (id != brand.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(brand);
                    await _context.SaveChangesAsync();
                    TempData["Success"] = "Dəyişiklik uğurla başa çatdı";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BrandExists(brand.Id))
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
            ViewData["AdminManagerId"] = new SelectList(_context.AdminManagers, "Id", "Email", brand.AdminManagerId);
            return View(brand);
        }

        
        public async Task<IActionResult> Delete(int? id)
        {
            var brand = await _context.Brands.FindAsync(id);
            _context.Brands.Remove(brand);
            await _context.SaveChangesAsync();
            TempData["Success"] = "Admin Deleted";
            return RedirectToAction(nameof(Index));
        }

        private bool BrandExists(int id)
        {
            return _context.Brands.Any(e => e.Id == id);
        }
    }
}
