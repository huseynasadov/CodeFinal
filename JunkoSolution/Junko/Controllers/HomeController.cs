using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Junko.Models;
using Junko.Service.DataService;
using Junko.Data.Entries;

namespace Junko.Controllers
{
    public class HomeController : Controller
    {

        private readonly ISettingService _settingService;
        public HomeController(ISettingService settingService)
        {
            _settingService = settingService;

        }
        public IActionResult Index()
        {
            return View();
        }

       
        [Route("error")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
