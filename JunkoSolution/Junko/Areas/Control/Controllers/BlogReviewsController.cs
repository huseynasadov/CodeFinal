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
    public class BlogReviewsController : Controller
    {
        private readonly JunkoDBContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public BlogReviewsController(JunkoDBContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: Control/BlogReviews
        public async Task<IActionResult> Index()
        {
            var junkoDBContext = _context.BlogReviews.Include(b => b.Admin).Include("Blog.BlogTranslates").Include(b => b.User).OrderByDescending(x=>x.CreatedAt);
            return View(await junkoDBContext.ToListAsync());
        }

        // GET: Control/BlogReviews/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogReview = await _context.BlogReviews
                .Include(b => b.Admin)
                .Include("Blog.BlogTranslates")
                .Include(b => b.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (blogReview == null)
            {
                return NotFound();
            }

            return View(blogReview);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogReview = await _context.BlogReviews
                .Include(b => b.Admin)
                .Include(b => b.Blog)
                .Include(b => b.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (blogReview == null)
            {
                return NotFound();
            }
            _context.BlogReviews.Remove(blogReview);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BlogReviewExists(int id)
        {
            return _context.BlogReviews.Any(e => e.Id == id);
        }
    }
}
