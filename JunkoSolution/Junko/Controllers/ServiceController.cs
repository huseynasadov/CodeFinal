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
    public class ServiceController : Controller
    {
        JunkoDBContext _db;
        public ServiceController(JunkoDBContext context)
        {
            _db = context;
        }
        public async Task<IActionResult> Index()
        {
            var rqf = Request.HttpContext.Features.Get<IRequestCultureFeature>();
            var culture = rqf.RequestCulture.Culture;
            ServiceVM model = new ServiceVM {
                Breadcrumb = new Breadcrumb
                {
                    Path = new Dictionary<string, string> {
                        {"Home",Url.Action("Index","Home")},
                        {"Service",null}
                    },
                    Page = Page.Service
                },
                ServicesCoverTranslates=await _db.ServicesCoverTranslates.Include("ServicesCover").Where(s=>s.Language.LanguageCode==culture.ToString() && s.ServicesCover.Status==true).OrderBy(o=>o.ServicesCover.Order).Take(3).ToListAsync(),
                OurServiceTranslates=await _db.OurServiceTranslates.Include("OurService").Where(s => s.Language.LanguageCode == culture.ToString() && s.OurService.Status == true).OrderBy(o => o.OurService.Order).Take(8).ToListAsync(),
            };
            return View(model);
        }
    }
}