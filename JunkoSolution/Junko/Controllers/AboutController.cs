﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Junko.DAL;
using Junko.ViewModels;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Junko.Controllers
{
    public class AboutController : Controller
    {
       private readonly JunkoDBContext _db;
        public AboutController(JunkoDBContext context)
        {
            _db = context;
        }
        public async Task<IActionResult> Index()
        {
            var rqf = Request.HttpContext.Features.Get<IRequestCultureFeature>();
            var culture = rqf.RequestCulture.Culture;
            AboutVM model = new AboutVM {
                Breadcrumb = new Breadcrumb
                {
                    Path = new Dictionary<string, string> {
                        { "Home", Url.Action("Index", "Home") },
                        { "About Us", null }
                    },
                    Page = Page.About
                },
                AboutSettingTranslate = await _db.AboutSettingTranslates.Include("AboutSetting").FirstOrDefaultAsync(a => a.Language.LanguageCode == culture.ToString()),
                WhatDoTranslates = await _db.WhatDosTranslates.Include("WhatDo").Where(w => w.Language.LanguageCode == culture.ToString() && w.WhatDo.Status == true).OrderByDescending(w => w.WhatDo.ModifiedAt).Take(2).ToListAsync(),
                OurServiceTranslates = await _db.OurServiceTranslates.Include("OurService").Where(o => o.Language.LanguageCode == culture.ToString() && o.OurService.Status == true).OrderBy(o => o.OurService.Order).Take(3).ToListAsync(),
                AdminManagers = await _db.AdminManagers.Include("Category.AdminCategoryTranslates").Where(w => w.Status == true).ToListAsync()
            };
            return View(model);
        }
    }
}