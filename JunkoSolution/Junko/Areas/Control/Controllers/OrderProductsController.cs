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
    public class OrderProductsController : Controller
    {
        private readonly JunkoDBContext _context;

        public OrderProductsController(JunkoDBContext context)
        {
            _context = context;
        }

        // GET: Control/OrderProducts
        public async Task<IActionResult> Index()
        {
            var junkoDBContext = _context.OrderProducts.Include(o => o.Product).Include(o => o.User);
            return View(await junkoDBContext.ToListAsync());
        }

        // GET: Control/OrderProducts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderProduct = await _context.OrderProducts
                .Include(o => o.Product)
                .Include(o => o.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (orderProduct == null)
            {
                return NotFound();
            }

            return View(orderProduct);
        }

       

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderProduct = await _context.OrderProducts
                .Include(o => o.Product)
                .Include(o => o.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (orderProduct == null)
            {
                return NotFound();
            }
            _context.OrderProducts.Remove(orderProduct);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderProductExists(int id)
        {
            return _context.OrderProducts.Any(e => e.Id == id);
        }
    }
}
