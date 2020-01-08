using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Junko.DAL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Junko.Areas.Control.Controllers
{
    [Area("Control")]
    [Authorize]
    public class DashboardController : Controller
    {
        private readonly JunkoDBContext _db;
        public DashboardController(JunkoDBContext context)
        {
            _db = context;
        }
        public async Task<IActionResult> Index()
        {

            return View();
        }
    }
}