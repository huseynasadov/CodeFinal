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
    public class ColorsController : Controller
    {
        private readonly JunkoDBContext _context;

        public ColorsController(JunkoDBContext context)
        {
            _context = context;
        }

        // GET: Control/Colors
        public async Task<IActionResult> Index()
        {
            return View(await _context.Colors.OrderByDescending(x=>x.CreatedAt).ToListAsync());
        }

        public IActionResult Create()
        {
           
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Code,Status,CreatedAt")] Color color)
        {
            if (ModelState.IsValid)
            {
                _context.Add(color);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(color);
        }

        public async Task<IActionResult> Edit(int id, bool status = true)
        {
            Color color =await _context.Colors.FirstOrDefaultAsync(x => x.Id == id);
            if (color!=null)
            {
                if (HttpContext.Request.Headers["x-requested-with"] == "XMLHttpRequest")
                {
                    color.Status = status;
                    await _context.SaveChangesAsync();
                    return Json(new { res = true });
                }
            }
            return Json(new { res = false });
        }

        // GET: Control/Colors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var color = await _context.Colors
                .FirstOrDefaultAsync(m => m.Id == id);
            if (color == null)
            {
                return NotFound();
            }

            _context.Colors.Remove(color);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ColorExists(int id)
        {
            return _context.Colors.Any(e => e.Id == id);
        }
    }
}
