using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Junko.Models;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Http;
using Junko.DAL;
using Junko.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Junko.Controllers
{
    public class HomeController : Controller
    {

        private readonly JunkoDBContext _db;
        public HomeController(JunkoDBContext context)
        {
            _db = context;
        }

        public async Task<IActionResult> Index()
        {
            var rqf = Request.HttpContext.Features.Get<IRequestCultureFeature>();
            var culture = rqf.RequestCulture.Culture;
            HomeVM model = new HomeVM {
             Partners=await _db.Partners.ToListAsync(),
             BestCategory=await _db.ProductCategories.Include("ProductCategoryTranslate").Include("ProductSubCategories").OrderByDescending(a=>a.ProductSubCategories.OrderByDescending(a=>a.BrandProductCategories.OrderByDescending(a=>a.Products.OrderByDescending(a=>a.FollowCount).FirstOrDefault().FollowCount).FirstOrDefault().Products.OrderByDescending(a=>a.FollowCount).FirstOrDefault().FollowCount).FirstOrDefault().BrandProductCategories.OrderByDescending(a=>a.Products.OrderByDescending(a=>a.FollowCount).FirstOrDefault().FollowCount).FirstOrDefault().Products.OrderByDescending(a=>a.FollowCount).FirstOrDefault().FollowCount).ToListAsync(),
             NewProductsCategory=await _db.ProductCategories.Include("ProductCategoryTranslate").Include("ProductSubCategories.ProductSubCategoryTranslate").
             OrderByDescending(a=>a.ProductSubCategories.
             OrderByDescending(a=>a.BrandProductCategories.
             OrderByDescending(a=>a.Products.
             OrderByDescending(a=>a.CreatedAt).
             FirstOrDefault().CreatedAt).
             FirstOrDefault().Products.
             OrderByDescending(a=>a.CreatedAt).
             FirstOrDefault().CreatedAt).
             FirstOrDefault().BrandProductCategories.
             OrderByDescending(a=>a.Products.
             OrderByDescending(a=>a.CreatedAt).
             FirstOrDefault().CreatedAt).
             FirstOrDefault().Products.
             OrderByDescending(a=>a.CreatedAt).
             FirstOrDefault().CreatedAt).Take(3).ToListAsync(),
             BestFollow =await _db.Products.OrderByDescending(a=>a.FollowCount).FirstOrDefaultAsync(),
             HomeHeaders=await _db.HomeHeaders.Include("Product.ProductPhotos").Include("HomeHeaderTranslates").OrderBy(a=>a.Order).ToListAsync(),
             NewProducts=await _db.Products.Include("BrandProductCategory.ProductSubCategory").Where(p=>p.Status==true).OrderByDescending(a => a.CreatedAt).ToListAsync(),
             MostFollowProducts=await _db.Products.OrderByDescending(a=>a.FollowCount).Where(p=>p.Status==true).ToListAsync(),
             MostSaleds=await _db.Products.Include("ProductPhotos").Include("BrandProductCategory.ProductSubCategory.ProductSubCategoryTranslate.Language").OrderByDescending(p=>p.OrderProducts.Count).Where(p=>p.Status==true).ToListAsync(),
             SaledProducts=await _db.Products.OrderByDescending(p=>p.CreatedAt).Where(p=>p.Discount>0).ToListAsync(),
             LanguageId= _db.Languages.FirstOrDefault(l=>l.LanguageCode==culture.ToString()).Id
            };
            return View(model);
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
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );
            return LocalRedirect(returnUrl);
        }
    }
}
