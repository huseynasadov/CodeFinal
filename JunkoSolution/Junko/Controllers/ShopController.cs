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
    public class ShopController : Controller
    {
        JunkoDBContext _db;
        public ShopController(JunkoDBContext context)
        {
            _db = context;
        }
        public IActionResult Index(int? page)
        {
            int count = page ?? 1;
            var rqf = Request.HttpContext.Features.Get<IRequestCultureFeature>();
            var culture = rqf.RequestCulture.Culture;
            ShopIndexVM model = new ShopIndexVM {
                Breadcrumb = new Breadcrumb
                {
                    Path = new Dictionary<string, string> {
                        {"Home",Url.Action("Index","Home")},
                        {"Products",null}
                    },
                    Page = Page.Shop
                },
                Pagination = new Pagination
                {
                    Page = Page.Shop,
                    CurrentPage = count
                },
                ProductCategoryTranslates=_db.ProductCategoryTranslates.Include("ProductCategory.ProductSubCategories.ProductSubCategoryTranslate").Where(p=>p.Language.LanguageCode==culture.ToString() && p.ProductCategory.Status==true).OrderBy(o=>o.ProductCategory.CreatedAt).ToList(),
                Products=_db.Products.Include("ProductPhotos").Where(p=>p.Status==true).OrderByDescending(p=>p.CreatedAt).Skip((count - 1) * 12).Take(12).ToList(),
                ProductCount=_db.Products.Where(p=>p.Status==true).Count()
            };
            int pageCount = _db.Products.Where(b => b.Status == true).Count() / 12;
            if (_db.Products.Where(b => b.Status == true).Count() % 12 != 0)
            {
                pageCount++;
            }
            model.Pagination.PageCount = pageCount;
            return View(model);
        }
        public IActionResult Detail()
        {
            return View();
        }
    }
}