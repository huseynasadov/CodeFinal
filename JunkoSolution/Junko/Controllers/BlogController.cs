using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Junko.DAL;
using Junko.Models;
using Junko.ModelTranslate;
using Junko.ViewModels;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Junko.Controllers
{
    public class BlogController : Controller
    {
       private readonly JunkoDBContext _db;
        public BlogController(JunkoDBContext context)
        {
            _db = context;
        }
        public async Task<IActionResult> Index(int? page)
        {
            int count = page ?? 1;
            var rqf = Request.HttpContext.Features.Get<IRequestCultureFeature>();
            var culture = rqf.RequestCulture.Culture;
            BlogVM model = new BlogVM
            {
                Breadcrumb = new Breadcrumb
                {
                    Path = new Dictionary<string, string> {
                        {"Home",Url.Action("Index","Home")},
                        {"Blog",null}
                    },
                    Page = Page.Blog
                },
                Pagination = new Pagination
                {
                    Page = Page.Blog,
                    CurrentPage = count
                },
                Categories =await _db.BlogCategoryTranslates
                .Where(c => c.Language.LanguageCode == culture.ToString() && c.Category.Status == true)
                .OrderByDescending(c => c.Category.CreatedAt).ToListAsync(),
                Blogs = await _db.BlogTranslates
                .Include("Blog.AdminManager.Category.AdminCategoryTranslates")
                .Include("Language")
                .Where(c => c.Language.LanguageCode == culture.ToString() && c.Blog.Status == true)
                .OrderByDescending(b => b.Blog.CreatedAt).Skip((count - 1) * 6).Take(6).ToListAsync(),
                ArchiveBlogs =await _db.BlogTranslates
                .Where(c => c.Language.LanguageCode == culture.ToString() && c.Blog.Status == true)
                .OrderBy(b => b.Blog.CreatedAt).Take(4).ToListAsync()
            };
            int pageCount =await _db.Blogs.Where(b => b.Status == true).CountAsync() / 6;
            if (await _db.Blogs.Where(b => b.Status == true).CountAsync() % 6 != 0)
            {
                pageCount++;
            }
            model.Pagination.PageCount = pageCount;
            return View(model);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Error", "Home");
            }

            AdminManager admin = new AdminManager();
            UserClient user = new UserClient();
            var cookieUser = Request.Cookies["Token"];
            var cookieAdmin = Request.Cookies["TokenAdmin"];
            if (cookieAdmin != null)
            {
                admin =await _db.AdminManagers.FirstOrDefaultAsync(a => a.Token == cookieAdmin);
            }
            if (cookieUser != null)
            {
                user =await _db.UserClients.FirstOrDefaultAsync(a => a.Token == cookieUser);
            }
            var rqf = Request.HttpContext.Features.Get<IRequestCultureFeature>();
            var culture = rqf.RequestCulture.Culture;
            BlogTranslate blog =await _db.BlogTranslates.Include("Blog.BlogReviews.User").Include("Blog.BlogReviews.Admin.Category.AdminCategoryTranslates").Include("Blog.BlogCategories.AdminManager.Category.AdminCategoryTranslates").FirstOrDefaultAsync(c =>c.BlogId==id && c.Language.LanguageCode == culture.ToString() && c.Blog.Status == true);
            if (blog == null)
            {
                return RedirectToAction("Error", "Home");
            }
            BlogDetailVM model = new BlogDetailVM
            {
                Blog = blog,
                UserClientId = (user!=null?user.Id:0),
                AdminId = (admin != null ? admin.Id : 0),
                BlogVM =new BlogVM {
                    Breadcrumb = new Breadcrumb
                    {
                        Path = new Dictionary<string, string> {
                        {"Home",Url.Action("Index","Home")},
                        {"Blog Detail",null}
                    },
                        Page = Page.BlogDetail
                    },
                    ArchiveBlogs =await _db.BlogTranslates
                .Where(c => c.Language.LanguageCode == culture.ToString() && c.Blog.Status == true)
                .OrderBy(b => b.Blog.CreatedAt).Take(4).ToListAsync(),
                    Categories =await _db.BlogCategoryTranslates
                .Where(c => c.Language.LanguageCode == culture.ToString() && c.Category.Status == true)
                .OrderByDescending(c => c.Category.CreatedAt).ToListAsync(),
                    Blogs =await _db.BlogTranslates
                .Include("Blog.AdminManager.Category.AdminCategoryTranslates")
                .Include("Language")
                .Where(c => c.Language.LanguageCode == culture.ToString() && c.Blog.Status == true)
                .OrderByDescending(b => b.Blog.CreatedAt).Take(4).ToListAsync(),
                },
                BlogCategories =await _db.BlogCategories.Include("Category.BlogCategoryTranslates").Where(b=>b.BlogId==blog.BlogId).ToListAsync()
                
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Review(BlogReview review) 
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
                if (review.AdminManagerId == null && review.UserClientId == null)
                {
                    return Json(new { status = false });
                }
                review.CreatedAt = DateTime.Now;
               await _db.BlogReviews.AddAsync(review);
               await _db.SaveChangesAsync();
               BlogReview model =await _db.BlogReviews.Include("User").FirstOrDefaultAsync(x => x.Id == review.Id);

                return PartialView("_BlogReview", model);
            }

            return Json(new { status = false });
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var blogReview = await _db.BlogReviews
                .Include(b => b.Admin)
                .Include(b => b.Blog)
                .Include(b => b.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (blogReview == null)
            {
                return NotFound();
            }
            _db.BlogReviews.Remove(blogReview);
            await _db.SaveChangesAsync();
            return Redirect((!string.IsNullOrEmpty(Request.Headers["Referer"]) ? Request.Headers["Referer"].ToString() : "/blog/detail/"+blogReview.BlogId ));
        }
    }
}