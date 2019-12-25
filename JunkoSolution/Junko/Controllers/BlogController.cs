﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Junko.DAL;
using Junko.ModelTranslate;
using Junko.ViewModels;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Junko.Controllers
{
    public class BlogController : Controller
    {
        JunkoDBContext _db;
        public BlogController(JunkoDBContext context)
        {
            _db = context;
        }
        public IActionResult Index(int? page)
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
                Categories = _db.BlogCategoryTranslates
                .Where(c => c.Language.LanguageCode == culture.ToString() && c.Category.Status == true)
                .OrderByDescending(c => c.Category.CreatedAt).ToList(),
                Blogs = _db.BlogTranslates
                .Include("Blog.AdminManager.Category.AdminCategoryTranslates")
                .Include("Language")
                .Where(c => c.Language.LanguageCode == culture.ToString() && c.Blog.Status == true)
                .OrderByDescending(b => b.Blog.CreatedAt).Skip((count - 1) * 6).Take(6).ToList(),
                ArchiveBlogs = _db.BlogTranslates
                .Where(c => c.Language.LanguageCode == culture.ToString() && c.Blog.Status == true)
                .OrderBy(b => b.Blog.CreatedAt).Take(4).ToList()
            };
            int pageCount = _db.Blogs.Where(b => b.Status == true).Count() / 6;
            if (_db.Blogs.Where(b => b.Status == true).Count() % 6 != 0)
            {
                pageCount++;
            }
            model.Pagination.PageCount = pageCount;
            return View(model);
        }
        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Error", "Home");
            }
            var rqf = Request.HttpContext.Features.Get<IRequestCultureFeature>();
            var culture = rqf.RequestCulture.Culture;
            BlogTranslate blog = _db.BlogTranslates.Include("Blog.BlogCategories.AdminManager.Category.AdminCategoryTranslates").FirstOrDefault(c =>c.BlogId==id && c.Language.LanguageCode == culture.ToString() && c.Blog.Status == true);
            if (blog == null)
            {
                return RedirectToAction("Error", "Home");
            }
            BlogDetailVM model = new BlogDetailVM
            {
                Blog = blog,
                BlogVM=new BlogVM {
                    Breadcrumb = new Breadcrumb
                    {
                        Path = new Dictionary<string, string> {
                        {"Home",Url.Action("Index","Home")},
                        {"Blog Detail",null}
                    },
                        Page = Page.BlogDetail
                    },
                    ArchiveBlogs = _db.BlogTranslates
                .Where(c => c.Language.LanguageCode == culture.ToString() && c.Blog.Status == true)
                .OrderBy(b => b.Blog.CreatedAt).Take(4).ToList(),
                    Categories = _db.BlogCategoryTranslates
                .Where(c => c.Language.LanguageCode == culture.ToString() && c.Category.Status == true)
                .OrderByDescending(c => c.Category.CreatedAt).ToList(),
                    Blogs = _db.BlogTranslates
                .Include("Blog.AdminManager.Category.AdminCategoryTranslates")
                .Include("Language")
                .Where(c => c.Language.LanguageCode == culture.ToString() && c.Blog.Status == true)
                .OrderByDescending(b => b.Blog.CreatedAt).Take(4).ToList(),
                },
                BlogCategories = _db.BlogCategories.Include("Category.BlogCategoryTranslates").Where(b=>b.BlogId==blog.BlogId).ToList()
                
            };
            return View(model);
        }
    }
}