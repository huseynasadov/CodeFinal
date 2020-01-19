using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Junko.DAL;
using Junko.Models;
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
        public async Task<IActionResult> Index(int? page, int? category, int? orderby, string filter, int? brand, string search)
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
                ProductCategoryTranslates = await _db.ProductCategoryTranslates.Include("ProductCategory.ProductSubCategories.ProductSubCategoryTranslate").Where(p => p.Language.LanguageCode == culture.ToString() && p.ProductCategory.Status == true).OrderBy(o => o.ProductCategory.CreatedAt).ToListAsync()


            };

            if (category != null)
            {
                model.Products =await _db.Products.Include("ProductPhotos").Where(p => p.Status == true && p.BrandProductCategory.ProductSubCategoryId == category).OrderByDescending(p => p.CreatedAt).Skip((count - 1) * 12).Take(12).ToListAsync();
                pageCount =await _db.Products.Where(p => p.Status == true && p.BrandProductCategory.ProductSubCategoryId == category).CountAsync() / 12;
                if (await _db.Products.Where(p => p.Status == true && p.BrandProductCategory.ProductSubCategoryId == category).CountAsync() % 12 != 0)
                {
                    pageCount++;
                }
                model.Pagination.PageCount = pageCount;
                if (orderby == 2)
                {
                    model.Products =await _db.Products.Include("ProductPhotos").Where(p => p.Status == true && p.BrandProductCategory.ProductSubCategoryId == category).OrderByDescending(p => p.CreatedAt).Skip((count - 1) * 12).Take(12).ToListAsync();
                }
                else if (orderby == 3)
                {
                    model.Products = await _db.Products.Include("ProductPhotos").Where(p => p.Status == true && p.BrandProductCategory.ProductSubCategoryId == category).OrderByDescending(p => p.Price).Skip((count - 1) * 12).Take(12).ToListAsync();
                }
                else if (orderby == 4)
                {
                    model.Products = await _db.Products.Include("ProductPhotos").Where(p => p.Status == true && p.BrandProductCategory.ProductSubCategoryId == category).OrderBy(p => p.Price).Skip((count - 1) * 12).Take(12).ToListAsync();
                }
                else if (orderby == 5)
                {
                    model.Products = await _db.Products.Include("ProductPhotos").Where(p => p.Status == true && p.BrandProductCategory.ProductSubCategoryId == category).OrderBy(p => p.Name).Skip((count - 1) * 12).Take(12).ToListAsync();
                }
                model.Pagination.CategoryId = category;
                model.ProductCount = _db.Products.Where(p => p.Status == true && p.BrandProductCategory.ProductSubCategoryId == category).Count();
            }
            else
            {
                model.Products =await _db.Products.Include("ProductPhotos").Where(p => p.Status == true).OrderByDescending(p => p.CreatedAt).Skip((count - 1) * 12).Take(12).ToListAsync();
                pageCount =await _db.Products.Where(p => p.Status == true).CountAsync() / 12;
                if (await _db.Products.Where(p => p.Status == true).CountAsync() % 12 != 0)
                {
                    pageCount++;
                }

                if (orderby == 2)
                {
                    model.Products =await _db.Products.Include("ProductPhotos").Where(p => p.Status == true).OrderByDescending(p => p.CreatedAt).Skip((count - 1) * 12).Take(12).ToListAsync();
                }
                else if (orderby == 3)
                {
                    model.Products = await _db.Products.Include("ProductPhotos").Where(p => p.Status == true).OrderByDescending(p => p.Price).Skip((count - 1) * 12).Take(12).ToListAsync();
                }
                else if (orderby == 4)
                {
                    model.Products = await _db.Products.Include("ProductPhotos").Where(p => p.Status == true).OrderBy(p => p.Price).Skip((count - 1) * 12).Take(12).ToListAsync();
                }
                else if (orderby == 5)
                {
                    model.Products = await _db.Products.Include("ProductPhotos").Where(p => p.Status == true).OrderBy(p => p.Name).Skip((count - 1) * 12).Take(12).ToListAsync();
                }
                model.ProductCount =await _db.Products.Where(p => p.Status == true).CountAsync();
            }
            if (brand != null)
            {
                model.Products = await _db.Products.Include("ProductPhotos").Where(p => p.BrandProductCategoryId == brand && p.Status == true).Skip((count - 1) * 12).Take(12).ToListAsync();
                model.Pagination.BrandId = brand;
                pageCount =await _db.Products.Where(p => p.Status == true && p.BrandProductCategoryId == brand).CountAsync() / 12;
                if (await _db.Products.Where(p => p.Status == true && p.BrandProductCategoryId == brand).CountAsync() % 12 != 0)
                {
                    pageCount++;
                }
                model.ProductCount =await _db.Products.Where(p => p.BrandProductCategoryId == brand && p.Status == true).CountAsync();
            }
            if (!string.IsNullOrEmpty(search))
            {
                model.Products =await _db.Products.Include("ProductPhotos").Where(p => p.Name.Contains(search) || p.BrandProductCategory.Brand.Name.Contains(search) || p.BrandProductCategory.ProductSubCategory.ProductSubCategoryTranslate.Any(a => a.Name.Contains(search)) && p.Status == true).Skip((count - 1) * 12).Take(12).ToListAsync();
                pageCount =await _db.Products.Where(p => p.Name.Contains(search) || p.BrandProductCategory.Brand.Name.Contains(search) || p.BrandProductCategory.ProductSubCategory.ProductSubCategoryTranslate.Any(a => a.Name.Contains(search)) && p.Status == true).CountAsync() / 12;
                if (await _db.Products.Where(p => p.Name.Contains(search) || p.BrandProductCategory.Brand.Name.Contains(search) || p.BrandProductCategory.ProductSubCategory.ProductSubCategoryTranslate.Any(a => a.Name.Contains(search)) && p.Status == true).CountAsync() % 12 != 0)
                {
                    pageCount++;
                }
                model.ProductCount =await _db.Products.Where(p => p.Name.Contains(search) || p.BrandProductCategory.Brand.Name.Contains(search) || p.BrandProductCategory.ProductSubCategory.ProductSubCategoryTranslate.Any(a => a.Name.Contains(search)) && p.Status == true).CountAsync();
            }
            if (!string.IsNullOrEmpty(filter))
            {
                string[] parts = filter.Split('-');
                model.Products =await _db.Products.Include("ProductPhotos").Where(p => p.Status == true && p.Price > decimal.Parse(parts[0]) && p.Price < decimal.Parse(parts[1])).OrderByDescending(p => p.Price).Skip((count - 1) * 12).Take(12).ToListAsync();
                
                pageCount =await _db.Products.Where(p => p.Status == true && p.Price > decimal.Parse(parts[0]) && p.Price < decimal.Parse(parts[1])).CountAsync() / 12;
                if (await _db.Products.Where(p => p.Status == true && p.Price > decimal.Parse(parts[0]) && p.Price < decimal.Parse(parts[1])).CountAsync() % 12 != 0)
                {
                    pageCount++;
                }
                model.ProductCount =await _db.Products.Where(p => p.Status == true && p.Price > decimal.Parse(parts[0]) && p.Price < decimal.Parse(parts[1])).CountAsync();
            }
            model.Pagination.PageCount = pageCount;
            return View(model);
        }
        public async Task<IActionResult> Detail(string slug)
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
                admin = await _db.AdminManagers.FirstOrDefaultAsync(a => a.Token == cookieAdmin);
            }
            if (cookieUser != null)
            {
                user = await _db.UserClients.FirstOrDefaultAsync(a => a.Token == cookieUser);
            }
            var rqf = Request.HttpContext.Features.Get<IRequestCultureFeature>();
            var culture = rqf.RequestCulture.Culture;
            Product product = await _db.Products.Include("ProductTranslates").Include("ProductPhotos").Include("ProductColors.Color").Include("BrandProductCategory.ProductSubCategory.ProductSubCategoryTranslate").Include("ProperityProducts.Properity.ProperityTranslates").FirstOrDefaultAsync(p => p.Status == true && p.Slug == slug);
            Product productReview =await _db.Products.Include("ProductReviews.User").Include("ProductReviews.Admin.Category.AdminCategoryTranslates").FirstOrDefaultAsync(p => p.Status == true && p.Slug == slug);
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
                LikeProducts = await _db.Products.Include("BrandProductCategory.ProductSubCategory.ProductSubCategoryTranslate.Language").Include("ProductPhotos").Where(p => p.Status == true && p.BrandProductCategory.ProductSubCategoryId == product.BrandProductCategory.ProductSubCategoryId).ToListAsync(),
                MostSaledProducts =await _db.Products.Include("BrandProductCategory.ProductSubCategory.ProductSubCategoryTranslate").Include("ProductPhotos").Where(p => p.Status == true).OrderBy(o => o.CreatedAt).ToListAsync()
            }; 
            if (User?.Identity?.IsAuthenticated == false)
            {
                model.Product.FollowCount++;
               await _db.SaveChangesAsync();
            }
            

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Review(ProductReview review)
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
                    return Json(new { status = false });
                }
                review.CreatedAt = DateTime.Now;
               await _db.ProductReviews.AddAsync(review);
               await _db.SaveChangesAsync();
                ProductReview model =await _db.ProductReviews.Include("User").FirstOrDefaultAsync(x => x.Id == review.Id);

                return PartialView("_ProductReview", model);
            }
            return Json(new { status = false });
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shopReview = await _db.ProductReviews
                .Include(b => b.Admin)
                .Include(b => b.Product)
                .Include(b => b.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (shopReview == null)
            {
                return NotFound();
            }
            _db.ProductReviews.Remove(shopReview);
            await _db.SaveChangesAsync();
            return Redirect((!string.IsNullOrEmpty(Request.Headers["Referer"]) ? Request.Headers["Referer"].ToString() : "/blog/detail/" + shopReview.ProductId));
        }
        public  IActionResult Modal(string slug) 
        {
            ViewBag.productId = slug;

           return ViewComponent("Modal");
        }
    }
}