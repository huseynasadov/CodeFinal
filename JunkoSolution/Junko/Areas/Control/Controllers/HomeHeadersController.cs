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
    public class HomeHeadersController : Controller
    {
        private readonly JunkoDBContext _context;
        private readonly IWebHostEnvironment webHostEnvironment;
        public HomeHeadersController(JunkoDBContext context, IWebHostEnvironment _webHostEnvironment)
        {
            _context = context;
            webHostEnvironment = _webHostEnvironment;
        }

        // GET: Control/HomeHeaders
        public async Task<IActionResult> Index()
        {
            var junkoDBContext = _context.HomeHeaders.Include(h => h.Product).OrderBy(x=>x.Order);
            return View(await junkoDBContext.ToListAsync());
        }

        
        // GET: Control/HomeHeaders/Create
        public IActionResult Create()
        {
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name");
            ViewData["HomeHeaderCount"] = _context.HomeHeaders.Count();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( HomeHeaderViewModel model)
        {
            if (model.HomeHeader.PhotoUpload != null)
            {
                try
                {
                    FileManager fileManager = new FileManager(webHostEnvironment);
                    model.HomeHeader.Photo = fileManager.Upload(model.HomeHeader.PhotoUpload);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("PhotoUpload", e.Message);
                }
            }
            if (ModelState.IsValid)
            {
                _context.Add(model.HomeHeader);
                await _context.SaveChangesAsync();
                foreach (var homeHeader in model.HomeHeaderTranslates)
                {
                    homeHeader.HomeHeaderId = _context.HomeHeaders.FirstOrDefault(x => x.Photo == model.HomeHeader.Photo && x.ModifiedAt == model.HomeHeader.ModifiedAt).Id;
                    _context.Add(homeHeader);
                    await _context.SaveChangesAsync();
                }
                TempData["Success"] = "Yeni Ana Səhifə Başlığı yaradıldl";
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name", model.HomeHeader.ProductId);
            return View(model);
        }

        // GET: Control/HomeHeaders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            HomeHeaderViewModel model = new HomeHeaderViewModel
            {
                HomeHeader = await _context.HomeHeaders.FirstOrDefaultAsync(x => x.Id == id),
                HomeHeaderTranslates = _context.HomeHeaderTranslates.Include("Language").Where(x => x.HomeHeaderId == id).ToList()
            };
            if (model.HomeHeader == null)
            {
                return NotFound();
            }
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name", model.HomeHeader.ProductId);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,HomeHeaderViewModel model)
        {
            if (id != model.HomeHeader.Id)
            {
                return NotFound();
            }
            if (model.HomeHeader.PhotoUpload != null)
            {
                try
                {
                    FileManager fileManager = new FileManager(webHostEnvironment);
                    model.HomeHeader.Photo = fileManager.Upload(model.HomeHeader.PhotoUpload);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("HomeHeader_PhotoUpload", e.Message);
                }
            }
            if (ModelState.IsValid)
            {
                foreach (var item in model.HomeHeaderTranslates)
                {
                    item.HomeHeaderId = id;
                    _context.HomeHeaderTranslates.Update(item);
                }
                await _context.SaveChangesAsync();
                try
                {
                    model.HomeHeader.ModifiedAt = DateTime.Now;
                    _context.Update(model.HomeHeader);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HomeHeaderExists(model.HomeHeader.Id))
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
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name", model.HomeHeader.ProductId);
            return View(model);
        }

        // GET: Control/HomeHeaders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homeHeader = await _context.HomeHeaders
                .Include(h => h.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (homeHeader == null)
            {
                return NotFound();
            }
            List<HomeHeaderTranslate> homeHeaderTranslates = _context.HomeHeaderTranslates.Where(x => x.HomeHeaderId == id).ToList();
            foreach (var item in homeHeaderTranslates)
            {
                _context.HomeHeaderTranslates.Remove(item);
            }
            await _context.SaveChangesAsync();
            _context.HomeHeaders.Remove(homeHeader);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        private bool HomeHeaderExists(int id)
        {
            return _context.HomeHeaders.Any(e => e.Id == id);
        }

        [HttpPost]
        public IActionResult EditOrder(int[] order)
        {
            int? Order1;
            HomeHeader homeHeader = _context.HomeHeaders.FirstOrDefault(x => x.Id == order[0]);
            HomeHeader homeHeader1 = _context.HomeHeaders.FirstOrDefault(x => x.Id == order[1]);
            Order1 = homeHeader.Order;

            homeHeader.Order = homeHeader1.Order;
            homeHeader1.Order = Order1;
           
            _context.SaveChanges();
            return Json(new {success="Ok" });
        }
    }
}
