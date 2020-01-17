using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Junko.Areas.Control.ViewModels;
using Junko.DAL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Junko.Areas.Control.Controllers
{
    [Area("Control")]
    [Authorize]
    public class DashboardController :Controller
    {
        private readonly JunkoDBContext _db;
        public DashboardController(JunkoDBContext context)
        {
            _db = context;
        }
        public async Task<IActionResult> Index()
        {
            DashboardViewModel model = new DashboardViewModel { 
            Products=await _db.Products.Include("OrderProducts").Where(x=>x.Status==true).ToListAsync(),
            OrderProducts = await _db.OrderProducts.ToListAsync(),
            AmountMonthly =await _db.OrderProducts.Where(x=>x.Complete==Models.Complete.Completed && x.CreatedAt.AddMonths(1)>DateTime.Now).SumAsync(x=>x.Price*x.Quantity),
            TotalAmount = await _db.OrderProducts.Where(x=>x.Complete==Models.Complete.Completed).SumAsync(x=>x.Price * x.Quantity),
            UsersCount = await _db.UserClients.CountAsync(),
            OnlineUsersCount = await _db.UserClients.Where(x=>x.Token!=null).CountAsync(),
            BlogsCount =await _db.Blogs.Where(x=>x.Status==true).CountAsync()

            };
            return View(model);
        }
    }
}