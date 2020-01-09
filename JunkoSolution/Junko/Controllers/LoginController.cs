using System;
using System.Collections.Generic;
using System.Linq;
using Junko.DAL;
using Junko.Models;
using Junko.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

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
                UserClient user = _db.UserClients.FirstOrDefault(a => a.Token == cookieValue);
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
                UserClient user = _db.UserClients.FirstOrDefault(a => a.Email == model.Login.Email);
                PasswordHasher<UserClient> hasher = new PasswordHasher<UserClient>(
                       new OptionsWrapper<PasswordHasherOptions>(
                           new PasswordHasherOptions()
                           {
                               CompatibilityMode = PasswordHasherCompatibilityMode.IdentityV2
                           })
                   );
                var result = hasher.VerifyHashedPassword(user, user.Password, model.Login.Password);

                if (user != null && result == PasswordVerificationResult.Success)
                {
                    user.Token = Guid.NewGuid().ToString();
                    _db.SaveChanges();
                    var option = new CookieOptions { 
                    Expires= DateTime.Now.AddMinutes(60),
                    IsEssential=true
                    };
                    Response.Cookies.Append("Token", user.Token, option);

                    return Redirect((!string.IsNullOrEmpty(Request.Headers["Referer"]) ? Request.Headers["Referer"].ToString() :returnUrl));
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
            if (_db.UserClients.Any(a => a.Email == model.User.Email))
            {
                ModelState.AddModelError("User.Email", "This Email was Registered");
            }
            if (ModelState.IsValid)
            {

                model.User.CreatedAt = DateTime.Now;

                PasswordHasher<UserClient> hasher = new PasswordHasher<UserClient>(
                        new OptionsWrapper<PasswordHasherOptions>(
                            new PasswordHasherOptions()
                            {
                                CompatibilityMode = PasswordHasherCompatibilityMode.IdentityV2
                            })
                    );
                model.User.Password = hasher.HashPassword(model.User, model.User.Password);
                model.User.Token = Guid.NewGuid().ToString();
                _db.UserClients.Add(model.User);
                _db.SaveChanges();
                var option = new CookieOptions { 
                    Expires= DateTime.Now.AddMinutes(60),
                    IsEssential=true
                };
                Response.Cookies.Append("Token", model.User.Token, option);
                return Redirect((!string.IsNullOrEmpty(Request.Headers["Referer"]) ? Request.Headers["Referer"].ToString() : returnUrl));
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
            var rqf = Request.HttpContext.Features.Get<IRequestCultureFeature>();
            var culture = rqf.RequestCulture.Culture;

            var cookieValue = Request.Cookies["Token"];
            if (cookieValue == null) return Redirect((!string.IsNullOrEmpty(Request.Headers["Referer"]) ? Request.Headers["Referer"].ToString() : returnUrl));

            UserClient user = _db.UserClients.FirstOrDefault(a => a.Token == cookieValue);
            if (user==null)
                return Redirect((!string.IsNullOrEmpty(Request.Headers["Referer"]) ? Request.Headers["Referer"].ToString() : returnUrl));

            AccountVM model = new AccountVM {
                Breadcrumb = new Breadcrumb
                {
                    Path = new Dictionary<string, string> {
                        { "Home", Url.Action("Index", "Home") },
                        { "Account", null }
                    },
                    Page = Page.Account
                },
                User = user,
                LanguageId=_db.Languages.FirstOrDefault(x=>x.LanguageCode==culture.ToString()).Id,
                OrderProducts=_db.OrderProducts.Include("Product").Where(x=>x.Status==true && x.UserClientId==user.Id).OrderByDescending(x=>x.Complete).ThenByDescending(x=>x.CreatedAt).ToList()
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(AccountVM model)
        {
            if (ModelState.IsValid)
            {
              UserClient user=  _db.UserClients.FirstOrDefault(a => a.Id == model.User.Id);
                if (user!=null)
                {
                    user.Firstname = model.User.Firstname;
                    user.Lastname = model.User.Lastname;
                    PasswordHasher<UserClient> hasher = new PasswordHasher<UserClient>(
                        new OptionsWrapper<PasswordHasherOptions>(
                            new PasswordHasherOptions()
                            {
                                CompatibilityMode = PasswordHasherCompatibilityMode.IdentityV2
                            })
                    );
                    user.Password = hasher.HashPassword(model.User, model.User.Password);
                    user.Birthday = model.User.Birthday;
                    user.Email = model.User.Email;
                    user.Gender = model.User.Gender;

                    _db.SaveChanges();
                }

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
               return Redirect((!string.IsNullOrEmpty(Request.Headers["Referer"]) ? Request.Headers["Referer"].ToString() : returnUrl));
            }
          UserClient user=  _db.UserClients.FirstOrDefault(a => a.Token == cookieValue);
            if (user!=null)
            {
                user.Token = null;
                _db.SaveChanges();
            }

            Response.Cookies.Delete("Token");
            return Redirect((!string.IsNullOrEmpty(Request.Headers["Referer"]) ? Request.Headers["Referer"].ToString() : returnUrl));
        }
    }
}