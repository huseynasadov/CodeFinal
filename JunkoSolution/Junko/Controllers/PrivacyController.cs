using System.Collections.Generic;
using System.Linq;
using Junko.DAL;
using Junko.ViewModels;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace Junko.Controllers
{
    public class PrivacyController : Controller
    {
        JunkoDBContext _db;
        public PrivacyController(JunkoDBContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            var rqf = Request.HttpContext.Features.Get<IRequestCultureFeature>();
            var culture = rqf.RequestCulture.Culture;
            PrivacyVM model = new PrivacyVM {
                Breadcrumb = new Breadcrumb
                {
                    Path = new Dictionary<string, string> {
                        { "Home", Url.Action("Index", "Home") },
                        { "Privacy Policy", null }
                    },
                    Page = Page.Privacy
                },
                Setting = _db.SettingTranslates.FirstOrDefault(s=>s.Language.LanguageCode==culture.ToString())
            };
            return View(model);
        }
    }
}