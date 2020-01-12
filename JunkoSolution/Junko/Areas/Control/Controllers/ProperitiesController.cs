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
using Junko.ModelTranslate;

namespace Junko.Areas.Control.Controllers
{
    [Area("Control")]
    [Authorize]
    public class ProperitiesController : Controller
    {
        private readonly JunkoDBContext _context;

        public ProperitiesController(JunkoDBContext context)
        {
            _context = context;
        }

        // GET: Control/Properities
        public async Task<IActionResult> Index()
        {
            var junkoDBContext = _context.Properities.Include(p => p.ProperityTranslates).OrderByDescending(x=>x.ModifiedAt);
            return View(await junkoDBContext.ToListAsync());
        }

        // GET: Control/Properities/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ProperityViewModel model = new ProperityViewModel
            {
                Properity = await _context.Properities.FirstOrDefaultAsync(x => x.Id == id),
                ProperityTranslates = _context.ProperityTranslates.Include("Language").Where(x => x.ProperityId == id).ToList()
            };
            if (model.Properity == null)
            {
                return NotFound();
            }

            return View(model);
        }

        // GET: Control/Properities/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProperityViewModel model)
        {
            if (ModelState.IsValid)
            {
                _context.Add(model.Properity);
                await _context.SaveChangesAsync();
                foreach (var properity in model.ProperityTranslates)
                {
                    properity.ProperityId = _context.Properities.FirstOrDefault(x => x.CreatedAt == model.Properity.CreatedAt).Id;
                    _context.Add(properity);
                    await _context.SaveChangesAsync();
                }
                TempData["Success"] = "Yeni Xüsusiyyət yaradıldl";
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        // GET: Control/Properities/Edit/5
        public async Task<IActionResult> Edit(int? id,bool status= true)
        {
            if (id == null)
            {
                return NotFound();
            }

            ProperityViewModel model = new ProperityViewModel
            {
                Properity = await _context.Properities.FirstOrDefaultAsync(x => x.Id == id),
                ProperityTranslates = _context.ProperityTranslates.Include("Language").Where(x => x.ProperityId == id).ToList()
            };
            if (model.Properity == null)
            {
                return NotFound();
            }
            if (HttpContext.Request.Headers["x-requested-with"] == "XMLHttpRequest")
            {

                model.Properity.Status = status;
                _context.SaveChanges();
                return Json(new { res = true });
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ProperityViewModel model)
        {
            if (id != model.Properity.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                foreach (var item in model.ProperityTranslates)
                {
                    item.ProperityId = id;
                    _context.ProperityTranslates.Update(item);
                }
                await _context.SaveChangesAsync();
                try
                {

                    model.Properity.ModifiedAt = DateTime.Now;
                    _context.Update(model.Properity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProperityExists(model.Properity.Id))
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
            return View(model);
        }

       
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var properity = await _context.Properities
                .Include(p => p.AdminManager)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (properity == null)
            {
                return NotFound();
            }
            List<ProperityTranslate> properityTranslates = _context.ProperityTranslates.Where(x => x.ProperityId == id).ToList();
            foreach (var item in properityTranslates)
            {
                _context.ProperityTranslates.Remove(item);
            }
            await _context.SaveChangesAsync();
            _context.Properities.Remove(properity);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProperityExists(int id)
        {
            return _context.Properities.Any(e => e.Id == id);
        }
    }
}
