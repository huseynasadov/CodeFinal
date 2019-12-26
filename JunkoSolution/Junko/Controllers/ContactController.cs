using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Junko.DAL;
using Junko.ViewModels;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Junko.Controllers
{
    public class ContactController : Controller
    {
        JunkoDBContext _db;
        public ContactController(JunkoDBContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            var rqf = Request.HttpContext.Features.Get<IRequestCultureFeature>();
            var culture = rqf.RequestCulture.Culture;
            ContactVM model = new ContactVM {
                Breadcrumb = new Breadcrumb
                {
                    Path = new Dictionary<string, string> {
                        { "Home", Url.Action("Index", "Home") },
                        { "Contact Us", null }
                    },
                    Page = Page.Contact
                },
                SettingTranslate=_db.SettingTranslates.Include("Setting").FirstOrDefault(s=>s.Language.LanguageCode==culture.ToString())
            };
            return View(model);
        }
    }
}