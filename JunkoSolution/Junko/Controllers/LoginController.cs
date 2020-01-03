using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Helpers;
using Junko.DAL;
using Junko.Models;
using Junko.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Junko.Controllers
{

    public class LoginController : Controller
    {
        private readonly JunkoDBContext _db;
        public LoginController(JunkoDBContext context)
        {
            _db = context;
        }
        public IActionResult Index(string returnUrl = "/")
        {
            var cookieValue = Request.Cookies["Token"];
            if (cookieValue!=null)
            {
                User user = _db.Users.FirstOrDefault(a => a.Token == cookieValue);
                if (user != null) return LocalRedirect(returnUrl);
            }
            LoginVM model = new LoginVM
            {
                Breadcrumb = new Breadcrumb
                {
                    Path = new Dictionary<string, string> {
                        { "Home", Url.Action("Index", "Home") },
                        { "Register", null }
                    },
                    Page = Page.Login
                },
                ReturnUrl = returnUrl
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(LoginVM model, string returnUrl = "/")
        {
            if (ModelState.IsValid)
            {
                User user = _db.Users.FirstOrDefault(a => a.Email == model.Login.Email);
                if (user != null && Crypto.VerifyHashedPassword(user.Password, model.Login.Password))
                {
                    user.Token = Guid.NewGuid().ToString();
                    _db.SaveChanges();
                    var option = new CookieOptions();
                    option.Expires = DateTime.Now.AddMinutes(60);
                    option.IsEssential = true;
                    Response.Cookies.Append("Token", user.Token, option);

                    return LocalRedirect(returnUrl);
                }
            }
            model.Breadcrumb = new Breadcrumb
            {
                Path = new Dictionary<string, string> {
                        { "Home", Url.Action("Index", "Home") },
                        { "Register", null }
                    },
                Page = Page.Login
            };
            return View(model);
        }
        public IActionResult Register(string returnUrl)
        {
            RegisterVM model = new RegisterVM
            {
                Breadcrumb = new Breadcrumb
                {
                    Path = new Dictionary<string, string> {
                        { "Home", Url.Action("Index", "Home") },
                        { "Register", null }
                    },
                    Page = Page.Login
                },
                ReturnUrl = returnUrl
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Register(RegisterVM model, string returnUrl)
        {
            if (_db.Users.Any(a => a.Email == model.User.Email))
            {
                ModelState.AddModelError("User.Email", "This Email was Registered");
            }
            if (ModelState.IsValid)
            {

                model.User.CreatedAt = DateTime.Now;
                model.User.Password = Crypto.HashPassword(model.User.Password);
                model.User.Token = Guid.NewGuid().ToString();
                _db.Users.Add(model.User);
                _db.SaveChanges();
                var option = new CookieOptions();
                option.Expires = DateTime.Now.AddMinutes(60);
                option.IsEssential = true;
                Response.Cookies.Append("Token", model.User.Token, option);
                return LocalRedirect(returnUrl);
            }
            model.Breadcrumb = new Breadcrumb
            {
                Path = new Dictionary<string, string> {
                        { "Home", Url.Action("Index", "Home") },
                        { "Register", null }
                    },
                Page = Page.Login
            };
            return View(model);
        }

        public IActionResult Account(string returnUrl = "/")
        {
            var cookieValue = Request.Cookies["Token"];
            if (cookieValue == null) return LocalRedirect(returnUrl);
            
            User user = _db.Users.FirstOrDefault(a => a.Token == cookieValue);
            if (user==null) return LocalRedirect(returnUrl); ;

            AccountVM model = new AccountVM {
                Breadcrumb = new Breadcrumb
                {
                    Path = new Dictionary<string, string> {
                        { "Home", Url.Action("Index", "Home") },
                        { "Account", null }
                    },
                    Page = Page.Account
                },
                User = user
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(AccountVM model)
        {
            if (ModelState.IsValid)
            {
                _db.Update(model.User);
                _db.SaveChanges();

            }
            model.Breadcrumb = new Breadcrumb
            {
                Path = new Dictionary<string, string> {
                        { "Home", Url.Action("Index", "Home") },
                        { "Account", null }
                    },
                Page = Page.Account
            };
            return View("Account",model);
        }

            public IActionResult Logout(string returnUrl="/")
        {
            var cookieValue = Request.Cookies["Token"];
            if (cookieValue==null)
            {
                return LocalRedirect(returnUrl);
            }
          User user=  _db.Users.FirstOrDefault(a => a.Token == cookieValue);
            if (user!=null)
            {
                user.Token = null;
                _db.SaveChanges();
            }

            Response.Cookies.Delete("Token"); 
            return LocalRedirect(returnUrl);
        }
    }
}