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
using Microsoft.Extensions.Localization;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Http;

namespace Junko.Controllers
{
    public class HomeController : Controller
    {

        private readonly IStringLocalizer<HomeController> _localizer;
        private readonly ISettingService _settingService;
        public HomeController(ISettingService settingService, IStringLocalizer<HomeController> localizer)
        {
            _settingService = settingService;
            _localizer = localizer;
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

        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddDays(1) }
            );

           
            return View(nameof(Index));
        }
    }
}
