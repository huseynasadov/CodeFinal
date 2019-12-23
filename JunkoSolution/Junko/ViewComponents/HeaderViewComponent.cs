
using Junko.DAL;
using Junko.ViewModels;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        JunkoDBContext _db;
        public HeaderViewComponent(JunkoDBContext context)
        {
            _db = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var rqf = Request.HttpContext.Features.Get<IRequestCultureFeature>();
            var culture = rqf.RequestCulture.Culture;
            SettingVM model = new SettingVM
            {
                Setting = _db.Setting.Include("SocialActivities").FirstOrDefault(),
                SettingTranslate = _db.SettingTranslates.FirstOrDefault(a => a.Language.LanguageCode == culture.ToString())
            };
            return View(model);
        }
    }
}
