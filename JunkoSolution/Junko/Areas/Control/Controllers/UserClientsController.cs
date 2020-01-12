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
    public class UserClientsController : Controller
    {
        private readonly JunkoDBContext _context;

        public UserClientsController(JunkoDBContext context)
        {
            _context = context;
        }

        // GET: Control/UserClients
        public async Task<IActionResult> Index()
        {
            return View(await _context.UserClients.ToListAsync());
        }

        // GET: Control/UserClients/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userClient = await _context.UserClients.Include("OrderProducts.Product").Include("BlogReviews.Blog.BlogTranslates").Include("ProductReviews.Product")
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userClient == null)
            {
                return NotFound();
            }

            return View(userClient);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userClient = await _context.UserClients
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userClient == null)
            {
                return NotFound();
            }
            _context.UserClients.Remove(userClient);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserClientExists(int id)
        {
            return _context.UserClients.Any(e => e.Id == id);
        }
    }
}
