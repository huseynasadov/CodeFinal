﻿using System.Collections.Generic;
using System.Linq;
using Junko.DAL;
using Junko.ViewModels;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Junko.Controllers
{
    public class FaqController : Controller
    {
        JunkoDBContext _db;
        public FaqController(JunkoDBContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            var rqf = Request.HttpContext.Features.Get<IRequestCultureFeature>();
            var culture = rqf.RequestCulture.Culture;
            FaqVM model = new FaqVM {
                Breadcrumb = new Breadcrumb
                {
                    Path = new Dictionary<string, string> {
                        { "Home", Url.Action("Index", "Home") },
                        { "FAQ", null }
                    },
                    Page = Page.FAQ
                },
                Setting=_db.SettingTranslates.FirstOrDefault(s=>s.Language.LanguageCode==culture.ToString()),
                FaqTranslates=_db.FaqTranslates.Include("Faq").Where(f=>f.Language.LanguageCode==culture.ToString() && f.Faq.Status==true).OrderBy(f=>f.Faq.Order).ToList()
            };
            return View(model);
        }
    }
}