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
       
        public IActionResult Index()
        {

            return View();
        }
    }
}