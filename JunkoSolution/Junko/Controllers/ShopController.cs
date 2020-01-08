using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Junko.DAL;
using Junko.Helpers;
using Junko.Models;
using Junko.ModelTranslate;
using Junko.ViewModels;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Junko.Controllers
{
    public class ShopController : Controller
    {
        private readonly JunkoDBContext _db;
        public ShopController(JunkoDBContext context)
        {
            _db = context;
        }
        public IActionResult Index(int? page, int? category, int? orderby, string filter, int? brand, string search)
        {
            int count = page ?? 1;
            int pageCount = 1;
            var rqf = Request.HttpContext.Features.Get<IRequestCultureFeature>();
            var culture = rqf.RequestCulture.Culture;
            ShopIndexVM model = new ShopIndexVM
            {
                Breadcrumb = new Breadcrumb
                {
                    Path = new Dictionary<string, string> {
                        { "Home", Url.Action("Index", "Home") },
                        { "Products", null }
                    },
                    Page = Page.Shop
                },
                Pagination = new Pagination
                {
                    Page = Page.Shop,
                    CurrentPage = count,
                    OrderBy = orderby
                },
                ProductCategoryTranslates = _db.ProductCategoryTranslates.Include("ProductCategory.ProductSubCategories.ProductSubCategoryTranslate").Where(p => p.Language.LanguageCode == culture.ToString() && p.ProductCategory.Status == true).OrderBy(o => o.ProductCategory.CreatedAt).ToList()


            };

            if (category != null)
            {
                model.Products = _db.Products.Include("ProductPhotos").Where(p => p.Status == true && p.BrandProductCategory.ProductSubCategoryId == category).OrderByDescending(p => p.CreatedAt).Skip((count - 1) * 12).Take(12).ToList();
                pageCount = _db.Products.Where(p => p.Status == true && p.BrandProductCategory.ProductSubCategoryId == category).Count() / 12;
                if (_db.Products.Where(p => p.Status == true && p.BrandProductCategory.ProductSubCategoryId == category).Count() % 12 != 0)
                {
                    pageCount++;
                }
                model.Pagination.PageCount = pageCount;
                if (orderby == 2)
                {
                    model.Products = _db.Products.Include("ProductPhotos").Where(p => p.Status == true && p.BrandProductCategory.ProductSubCategoryId == category).OrderByDescending(p => p.CreatedAt).Skip((count - 1) * 12).Take(12).ToList();
                }
                else if (orderby == 3)
                {
                    model.Products = _db.Products.Include("ProductPhotos").Where(p => p.Status == true && p.BrandProductCategory.ProductSubCategoryId == category).OrderByDescending(p => p.Price).Skip((count - 1) * 12).Take(12).ToList();
                }
                else if (orderby == 4)
                {
                    model.Products = _db.Products.Include("ProductPhotos").Where(p => p.Status == true && p.BrandProductCategory.ProductSubCategoryId == category).OrderBy(p => p.Price).Skip((count - 1) * 12).Take(12).ToList();
                }
                else if (orderby == 5)
                {
                    model.Products = _db.Products.Include("ProductPhotos").Where(p => p.Status == true && p.BrandProductCategory.ProductSubCategoryId == category).OrderBy(p => p.Name).Skip((count - 1) * 12).Take(12).ToList();
                }
                model.Pagination.CategoryId = category;
            }
            else
            {
                model.Products = _db.Products.Include("ProductPhotos").Where(p => p.Status == true).OrderByDescending(p => p.CreatedAt).Skip((count - 1) * 12).Take(12).ToList();
                pageCount = _db.Products.Where(p => p.Status == true).Count() / 12;
                if (_db.Products.Where(p => p.Status == true).Count() % 12 != 0)
                {
                    pageCount++;
                }
                if (orderby == 2)
                {
                    model.Products = _db.Products.Include("ProductPhotos").Where(p => p.Status == true).OrderByDescending(p => p.CreatedAt).Skip((count - 1) * 12).Take(12).ToList();
                }
                else if (orderby == 3)
                {
                    model.Products = _db.Products.Include("ProductPhotos").Where(p => p.Status == true).OrderByDescending(p => p.Price).Skip((count - 1) * 12).Take(12).ToList();
                }
                else if (orderby == 4)
                {
                    model.Products = _db.Products.Include("ProductPhotos").Where(p => p.Status == true).OrderBy(p => p.Price).Skip((count - 1) * 12).Take(12).ToList();
                }
                else if (orderby == 5)
                {
                    model.Products = _db.Products.Include("ProductPhotos").Where(p => p.Status == true).OrderBy(p => p.Name).Skip((count - 1) * 12).Take(12).ToList();
                }
               
                
            }
            if (brand != null)
            {
                model.Products = _db.Products.Include("ProductPhotos").Where(p => p.BrandProductCategoryId == brand && p.Status == true).Skip((count - 1) * 12).Take(12).ToList();
                model.Pagination.BrandId = brand;
                pageCount = _db.Products.Where(p => p.Status == true && p.BrandProductCategoryId == brand).Count() / 12;
                if (_db.Products.Where(p => p.Status == true && p.BrandProductCategoryId == brand).Count() % 12 != 0)
                {
                    pageCount++;
                }
            }
            if (search != null)
            {
                model.Products = _db.Products.Include("ProductPhotos").Where(p => p.Name.Contains(search) || p.BrandProductCategory.Brand.Name.Contains(search) || p.BrandProductCategory.ProductSubCategory.ProductSubCategoryTranslate.Any(a => a.Name.Contains(search)) && p.Status == true).Skip((count - 1) * 12).Take(12).ToList();
                pageCount = _db.Products.Where(p => p.Name.Contains(search) || p.BrandProductCategory.Brand.Name.Contains(search) || p.BrandProductCategory.ProductSubCategory.ProductSubCategoryTranslate.Any(a => a.Name.Contains(search)) && p.Status == true).Count() / 12;
                if (_db.Products.Where(p => p.Name.Contains(search) || p.BrandProductCategory.Brand.Name.Contains(search) || p.BrandProductCategory.ProductSubCategory.ProductSubCategoryTranslate.Any(a => a.Name.Contains(search)) && p.Status == true).Count() % 12 != 0)
                {
                    pageCount++;
                }
            }
            if (filter != null)
            {
                string[] parts = filter.Split('-');
                model.Products = _db.Products.Include("ProductPhotos").Where(p => p.Status == true && p.Price > decimal.Parse(parts[0]) && p.Price < decimal.Parse(parts[1])).OrderByDescending(p => p.Price).Skip((count - 1) * 12).Take(12).ToList();
                
                pageCount = _db.Products.Where(p => p.Status == true && p.Price > decimal.Parse(parts[0]) && p.Price < decimal.Parse(parts[1])).Count() / 12;
                if (_db.Products.Where(p => p.Status == true && p.Price > decimal.Parse(parts[0]) && p.Price < decimal.Parse(parts[1])).Count() % 12 != 0)
                {
                    pageCount++;
                }
            }
            model.ProductCount = model.Products.Count();
           
            return View(model);
        }
        public IActionResult Detail(string slug)
        {
            if (slug == null)
            {
                return RedirectToAction("error", "home");
            }
            AdminManager admin = new AdminManager();
            UserClient user = new UserClient();
            var cookieUser = Request.Cookies["Token"];
            var cookieAdmin = Request.Cookies["TokenAdmin"];
            if (cookieAdmin != null)
            {
                admin =  _db.AdminManagers.FirstOrDefault(a => a.Token == cookieAdmin);
            }
            if (cookieUser != null)
            {
                user = _db.UserClients.FirstOrDefault(a => a.Token == cookieUser);
            }
            var rqf = Request.HttpContext.Features.Get<IRequestCultureFeature>();
            var culture = rqf.RequestCulture.Culture;
            Product product = _db.Products.Include("ProductTranslates").Include("ProductPhotos").Include("ProductColors.Color").Include("BrandProductCategory.ProductSubCategory.ProductSubCategoryTranslate").Include("ProperityProducts.Properity.ProperityTranslates").FirstOrDefault(p => p.Status == true && p.Slug == slug);
            Product productReview =  _db.Products.Include("ProductReviews.User").Include("ProductReviews.Admin.Category.AdminCategoryTranslates").FirstOrDefault(p => p.Status == true && p.Slug == slug);
            if (product == null)
            {
                return RedirectToAction("error", "home");
            }
            ShopDetailVM model = new ShopDetailVM
            {
                UserClientId = (user != null ? user.Id : 0),
                AdminId = (admin != null ? admin.Id : 0),
                Breadcrumb = new Breadcrumb
                {
                    Path = new Dictionary<string, string> {
                        { "Home", Url.Action("Index", "Home") },
                        { "Product Detail", null }
                    },
                    Page = Page.ShopDetail
                },
                LanguageId = _db.Languages.FirstOrDefault(l => l.LanguageCode == culture.ToString()).Id,
                Product = product,
                ProductReview=productReview,
                LikeProducts = _db.Products.Include("BrandProductCategory.ProductSubCategory.ProductSubCategoryTranslate.Language").Include("ProductPhotos").Where(p => p.Status == true && p.BrandProductCategory.ProductSubCategoryId == product.BrandProductCategory.ProductSubCategoryId).ToList(),
                MostSaledProducts = _db.Products.Include("BrandProductCategory.ProductSubCategory.ProductSubCategoryTranslate").Include("ProductPhotos").Where(p => p.Status == true).OrderBy(o => o.CreatedAt).ToList()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Review(ProductReview review)
        {
            if (ModelState.IsValid)
            {
                if (review.AdminManagerId == 0)
                {
                    review.AdminManagerId = null;
                }
                if (review.UserClientId == 0)
                {
                    review.UserClientId = null;
                }
                if (review.UserClientId==null && review.AdminManagerId==null)
                {
                    return RedirectToAction("index", "login");
                }
                review.CreatedAt = DateTime.Now;
                _db.ProductReviews.Add(review);
                _db.SaveChanges();
            }

            return LocalRedirect("/shop/detail?slug=" + _db.Products.FirstOrDefault(a=>a.Id==review.ProductId).Slug);
        }
    }
}