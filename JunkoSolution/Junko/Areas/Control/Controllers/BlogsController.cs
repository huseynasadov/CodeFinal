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
    public class BlogsController : Controller
    {
        private readonly JunkoDBContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public BlogsController(JunkoDBContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: Control/Blogs
        public async Task<IActionResult> Index()
        {
            var junkoDBContext = _context.Blogs.Include("BlogTranslates").OrderByDescending(x=>x.ModifiedAt);
            return View(await junkoDBContext.ToListAsync());
        }

        // GET: Control/Blogs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            BlogViewModel model = new BlogViewModel
            {
                Blog = await _context.Blogs.Include("BlogReviews.User").FirstOrDefaultAsync(x => x.Id == id),
                BlogTranslates = _context.BlogTranslates.Include("Language").Where(x => x.BlogId == id).ToList()
            };
            if (model.Blog == null)
            {
                return NotFound();
            }

            return View(model);
        }

        // GET: Control/Blogs/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BlogViewModel model)
        {
            if (model.Blog.PhotoUpload != null)
            {
                try
                {
                    FileManager fileManager = new FileManager(_webHostEnvironment);
                    model.Blog.Photo = fileManager.Upload(model.Blog.PhotoUpload);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("PhotoUpload", e.Message);
                }
            }
            if (ModelState.IsValid)
            {
                _context.Add(model.Blog);
                await _context.SaveChangesAsync();
                foreach (var blog in model.BlogTranslates)
                {
                    blog.BlogId = _context.Blogs.FirstOrDefault(x => x.Photo == model.Blog.Photo && x.CreatedAt == model.Blog.CreatedAt).Id;
                    _context.Add(blog);
                    await _context.SaveChangesAsync();
                }
                TempData["Success"] = "Yeni Xəbər yaradıldl";
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        // GET: Control/Blogs/Edit/5
        public async Task<IActionResult> Edit(int? id,bool status = true)
        {
            if (id == null)
            {
                return NotFound();
            }
            BlogViewModel model = new BlogViewModel
            {
                Blog = await _context.Blogs.FirstOrDefaultAsync(x => x.Id == id),
                BlogTranslates = _context.BlogTranslates.Include("Language").Where(x => x.BlogId == id).ToList()
            };
            if (model.Blog == null)
            {
                return NotFound();
            }
            if (HttpContext.Request.Headers["x-requested-with"] == "XMLHttpRequest")
            {

                model.Blog.Status = status;
                _context.SaveChanges();
                return Json(new { res = true });
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,BlogViewModel model)
        {
            if (id != model.Blog.Id)
            {
                return NotFound();
            }
            if (model.Blog.PhotoUpload != null)
            {
                try
                {
                    FileManager fileManager = new FileManager(_webHostEnvironment);
                    model.Blog.Photo = fileManager.Upload(model.Blog.PhotoUpload);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("PhotoUpload", e.Message);
                }
            }
            if (ModelState.IsValid)
            {
                foreach (var item in model.BlogTranslates)
                {
                    item.BlogId = id;
                    _context.BlogTranslates.Update(item);
                }
                await _context.SaveChangesAsync();
                try
                {
                    model.Blog.ModifiedAt = DateTime.Now;
                    _context.Update(model.Blog);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BlogExists(model.Blog.Id))
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

        // GET: Control/Blogs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blog = await _context.Blogs
                .Include(b => b.AdminManager)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (blog == null)
            {
                return NotFound();
            }
            List<BlogTranslate> blogTranslates = _context.BlogTranslates.Where(x => x.Blog.Id == id).ToList();
            foreach (var item in blogTranslates)
            {
                _context.BlogTranslates.Remove(item);
            }
            await _context.SaveChangesAsync();
            _context.Blogs.Remove(blog);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

       
        private bool BlogExists(int id)
        {
            return _context.Blogs.Any(e => e.Id == id);
        }
    }
}
