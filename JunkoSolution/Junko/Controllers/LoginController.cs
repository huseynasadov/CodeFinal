using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public async Task<IActionResult> Index(string returnUrl = "/")
        {
            var cookieValue = Request.Cookies["Token"];
            if (cookieValue!=null)
            {
                UserClient user =await _db.UserClients.FirstOrDefaultAsync(a => a.Token == cookieValue);
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
        public async Task<IActionResult> Index(LoginVM model, string returnUrl = "/")
        {
            if (ModelState.IsValid)
            {
                UserClient user =await _db.UserClients.FirstOrDefaultAsync(a => a.Email == model.Login.Email);
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
                   await _db.SaveChangesAsync();
                    var option = new CookieOptions { 
                    Expires= DateTime.Now.AddMinutes(60),
                    IsEssential=true
                    };
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
        public async Task<IActionResult> Register(RegisterVM model, string returnUrl)
        {
            if (await _db.UserClients.AnyAsync(a => a.Email == model.User.Email))
            {
                ModelState.AddModelError("User.Email", "This Email was Registered");
                model.Breadcrumb = new Breadcrumb
                {
                    Path = new Dictionary<string, string> {
                        { "Home", Url.Action("Index", "Home") },
                        { "Register", null }
                    },
                    Page = Page.Login
                };
                TempData["Error"] = "This user have been Registered";
                return View(model);
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
               await _db.UserClients.AddAsync(model.User);
               await _db.SaveChangesAsync();
                var option = new CookieOptions { 
                    Expires= DateTime.Now.AddMinutes(60),
                    IsEssential=true
                };
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

        public async Task<IActionResult> Account(string returnUrl = "/")
        {
            var rqf = Request.HttpContext.Features.Get<IRequestCultureFeature>();
            var culture = rqf.RequestCulture.Culture;

            var cookieValue = Request.Cookies["Token"];
            if (cookieValue == null) return Redirect((!string.IsNullOrEmpty(Request.Headers["Referer"]) ? Request.Headers["Referer"].ToString() : returnUrl));

            UserClient user =await _db.UserClients.FirstOrDefaultAsync(a => a.Token == cookieValue);
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
                OrderProducts=await _db.OrderProducts.Include("Product").Include("Color").Where(x=>x.Status==true && x.UserClientId==user.Id).OrderByDescending(x=>x.Complete).ThenByDescending(x=>x.CreatedAt).ToListAsync()
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(AccountVM model)
        {
            var rqf = Request.HttpContext.Features.Get<IRequestCultureFeature>();
            var culture = rqf.RequestCulture.Culture;
            UserClient user =await _db.UserClients.FirstOrDefaultAsync(x => x.Id == model.User.Id);
            model.Breadcrumb = new Breadcrumb
            {
                Path = new Dictionary<string, string> {
                        { "Home", Url.Action("Index", "Home") },
                        { "Account", null }
                    },
                Page = Page.Account
            };
            model.LanguageId = _db.Languages.FirstOrDefault(x => x.LanguageCode == culture.ToString()).Id;
            model.OrderProducts =await _db.OrderProducts.Include("Product").Where(x => x.Status == true && x.UserClientId == user.Id).OrderByDescending(x => x.Complete).ThenByDescending(x => x.CreatedAt).ToListAsync();
          
            if (User!=null && model.User.Password == "Password")
            {
                model.User.Password = user.Password;
            }
            else
            {
                PasswordHasher<UserClient> hasher = new PasswordHasher<UserClient>(
                    new OptionsWrapper<PasswordHasherOptions>(
                        new PasswordHasherOptions()
                        {
                            CompatibilityMode = PasswordHasherCompatibilityMode.IdentityV2
                        })
                );
                user.Password = hasher.HashPassword(model.User, model.User.Password);
            }

            if (ModelState.IsValid)
            {

                if (user!=null)
                {
                    user.Firstname = model.User.Firstname;
                    user.Lastname = model.User.Lastname;
                    user.Birthday = model.User.Birthday;
                    user.Email = model.User.Email;
                    user.Gender = model.User.Gender;
                    user.Address = model.User.Address;
                   await _db.SaveChangesAsync();
                    if (model.LanguageId == 1)
                    {
                        TempData["Success"] = "Changed has been Success !";
                    }
                    else {
                        TempData["Success"] = "Dəyişiklik uğurla tamamlandı ! !";
                    }
                    return View("Account", model);
                }

            }
           
            if (model.LanguageId == 1)
            {
                TempData["Error"] = "Changed has been Error !";
            }
            else
            {
                TempData["Error"] = "Dəyişiklik uğursuz oldu ! !";
            }
            return View("Account",model);
        }

            public async Task<IActionResult> Logout(string returnUrl="/")
        {
            var cookieValue = Request.Cookies["Token"];
            if (cookieValue==null)
            {
               return LocalRedirect(returnUrl);
            }
          UserClient user=await  _db.UserClients.FirstOrDefaultAsync(a => a.Token == cookieValue);
            if (user!=null)
            {
                user.Token = null;
               await _db.SaveChangesAsync();
            }

            Response.Cookies.Delete("Token");
            return LocalRedirect(returnUrl);
        }
    }
}