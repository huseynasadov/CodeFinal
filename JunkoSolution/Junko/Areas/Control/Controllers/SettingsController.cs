using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Junko.DAL;
using Junko.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Junko.Helpers;
using Junko.Areas.Control.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace Junko.Areas.Control.Controllers
{
    [Area("Control")]
    [Authorize]
    public class SettingsController : Controller
    {
        private readonly JunkoDBContext _context;
        private readonly IWebHostEnvironment webHostEnvironment;
        public SettingsController(JunkoDBContext context, IWebHostEnvironment _webHostEnvironment)
        {
            _context = context;
            webHostEnvironment = _webHostEnvironment;
        }

        // GET: Control/Settings
        public async Task<IActionResult> Index()
        {
            var junkoDBContext = _context.Setting.Include(s => s.AdminManager);
            return View(await junkoDBContext.ToListAsync());
        }


        // GET: Control/Settings/Edit/5

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            SettingViewModel model = new SettingViewModel {
                Setting = await _context.Setting.Include("SettingTranslates").FirstOrDefaultAsync(x => x.Id == id),
                SettingTranslates =  _context.SettingTranslates.Include("Language").Where(x=>x.SettingId==id).ToList()
        };
            if (model.Setting == null)
            {
                return NotFound();
            }
            ViewData["AdminManagerId"] = new SelectList(_context.AdminManagers, "Id", "Email", model.Setting.AdminManagerId);
            ViewData["SettingId"] = new SelectList(_context.Setting, "Id", "Email", model.Setting.Id);
            ViewData["LanguageId"] = new SelectList(_context.Languages, "Id", "Id", model.SettingTranslates.FirstOrDefault().LanguageId);
            return View(model);
        }

        // POST: Control/Settings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, SettingViewModel model)
        {
            if (id != model.Setting.Id)
            {
                return NotFound();
            }
            if (model.Setting.PhotoUpload != null)
            {
                try
                {
                    FileManager fileManager = new FileManager(webHostEnvironment);
                    model.Setting.PhotoLogo = fileManager.Upload(model.Setting.PhotoUpload);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("PhotoUpload", e.Message);
                }
            }
            if (ModelState.IsValid)
            {
                foreach (var setTranslate in model.SettingTranslates)
                {
                    _context.Update(setTranslate);
                }
                try
                {
                    _context.Update(model.Setting);
                    await _context.SaveChangesAsync();
                    TempData["Success"] = "Dəyişiklik uğurla başa çatdı";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SettingExists(model.Setting.Id))
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
            ViewData["AdminManagerId"] = new SelectList(_context.AdminManagers, "Id", "Email", model.Setting.AdminManagerId);
            return View(model);
        }

       

        private bool SettingExists(int id)
        {
            return _context.Setting.Any(e => e.Id == id);
        }
    }
}
