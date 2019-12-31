
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
    public class FooterViewComponent: ViewComponent
    {
       private readonly JunkoDBContext _db;
        public FooterViewComponent(JunkoDBContext context)
        {
            _db = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var rqf = Request.HttpContext.Features.Get<IRequestCultureFeature>();
            var culture = rqf.RequestCulture.Culture;
            SettingVM model = new SettingVM {
                Setting= await _db.Setting.Include("SocialActivities").FirstOrDefaultAsync(),
                SettingTranslate=await _db.SettingTranslates.FirstOrDefaultAsync(a=>a.Language.LanguageCode==culture.ToString())
            };
            return View(model);
        }
    }
}
