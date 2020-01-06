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

namespace Junko.Areas.Control.Controllers
{
    [Area("Control")]
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

            var setting = await _context.Setting.FindAsync(id);
            if (setting == null)
            {
                return NotFound();
            }
            ViewData["AdminManagerId"] = new SelectList(_context.AdminManagers, "Id", "Email", setting.AdminManagerId);
            return View(setting);
        }

        // POST: Control/Settings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Logo,PhotoLogo,PhotoUpload,Phone,Location,Email,Id,AdminManagerId,ModifiedAt")] Setting setting)
        {
            if (id != setting.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                string DefaultImage = "noimage.png";
                if (setting.PhotoUpload!=null)
                {
                    string UploadDir = Path.Combine(webHostEnvironment.WebRootPath, "images");
                    DefaultImage = "Uploads/"+Guid.NewGuid().ToString() + "_" + setting.PhotoUpload.FileName;
                    string filePath = Path.Combine(UploadDir, DefaultImage);
                    FileStream fs = new FileStream(filePath, FileMode.Create);
                    await setting.PhotoUpload.CopyToAsync(fs);
                    fs.Close();
                }
                    setting.PhotoLogo = DefaultImage;
                try
                {
                    _context.Update(setting);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SettingExists(setting.Id))
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
            ViewData["AdminManagerId"] = new SelectList(_context.AdminManagers, "Id", "Email", setting.AdminManagerId);
            return View(setting);
        }

       

        private bool SettingExists(int id)
        {
            return _context.Setting.Any(e => e.Id == id);
        }
    }
}
