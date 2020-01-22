 using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Junko.Areas.Control.ViewModels;
using Junko.DAL;
using Junko.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Junko.Helpers;
using Microsoft.EntityFrameworkCore;

namespace Junko.Areas.Control.Controllers
{
    [Area("Control")]
    [Authorize]
    public class UsersController : Controller
    {
        private readonly UserManager<AppAdmin> _userManager;
        private readonly SignInManager<AppAdmin> _signInManager;
        private readonly IPasswordHasher<AppAdmin> _passwordHasher;
        private readonly JunkoDBContext _db;
        public UsersController(JunkoDBContext db, UserManager<AppAdmin> userManager, SignInManager<AppAdmin> signInManager, IPasswordHasher<AppAdmin> passwordHasher)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _passwordHasher = passwordHasher;
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_userManager.Users);
        }
        [AllowAnonymous]
        public IActionResult Register(string Token)
        {
            AppAdmin user = _db.Users.FirstOrDefault(x => x.ConcurrencyStamp == Token);
            if (user != null)
            {
                return View(user);
            }
            return NotFound();
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AdminViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (_db.Users.Any(x => x.Email == model.Email))
                {
                    TempData["Error"] = "Bu E-Poçt ünvanı artıq Qeydiyyatdan keçmişdir!";

                    return View();
                }
                AppAdmin admin = new AppAdmin
                {
                    Email = model.Email,
                    Birthday = new DateTime(2000, 01, 01),
                    Firstname = "Admin",
                    Lastname = "Admin",
                    UserName = "Admin" + Guid.NewGuid()
                };
                await _userManager.CreateAsync(admin);
                await _db.SaveChangesAsync();
                TempData["Success"] = "Yeni Admin uğurla yaradıldı və " + model.Email + " ünvanına Qeydiyyyat üçün Mail Göndərildi!";
                SendMail mail = new SendMail();
                mail.SendEmail(admin);
                return RedirectToAction(nameof(Index));
            }

            return View("index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> Register(AppAdmin user)
        {
            if (ModelState.IsValid)
            {
                AppAdmin appUser = _db.Users.FirstOrDefault(x => x.Id == user.Id);
                appUser.Firstname = user.Firstname;
                appUser.Lastname = user.Lastname;
                appUser.Birthday = user.Birthday;
                appUser.PhoneNumber = user.PhoneNumber;
                appUser.EmailConfirmed = true;
                if (user.PasswordHash != null)
                {
                    appUser.PasswordHash = _passwordHasher.HashPassword(appUser, user.PasswordHash);
                }
                appUser.UserName = user.Firstname + Guid.NewGuid();
                IdentityResult resultReq = await _userManager.UpdateAsync(appUser);
                if (resultReq.Succeeded)
                {
                    TempData["Success"] = "Sizin Admin kimi Qeydiyyatınız uğurla Tamamlandı!";
                    SendMail mail = new SendMail();
                    mail.SendSuccess(user);
                    return RedirectToAction("index", "users");
                }
                else
                {
                    foreach (IdentityError error in resultReq.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }

            return View(user);
        }
        
        // GET /account/login
        [AllowAnonymous]
        [Route("control")]
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated == true)
            {
              AppAdmin appAdmin =  _db.Users.FirstOrDefault(x => x.UserName == User.Identity.Name);
                if (appAdmin.LockoutEnabled == true)
                {
                    return RedirectToAction("index", "dashboard");
                } 
            }
            return View();
        }

        // POST /account/login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(Login login)
        {
            if (ModelState.IsValid)
            {
                AppAdmin appUser = await _userManager.FindByEmailAsync(login.Email);
                if (appUser != null)
                {
                    ViewBag.AdminUser = login.Email;
                    Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(appUser, login.Password, false, false);
                    if (result.Succeeded)
                        return RedirectToAction("index", "Dashboard");
                }
                ModelState.AddModelError("", "Login failed, wrong credentials.");
            }

            return View(login);
        }


        // GET /account/logout
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return LocalRedirect("/home");
        }

        public async Task<IActionResult> Edit(string id, bool status = true)
        {

            if (HttpContext.Request.Headers["x-requested-with"] == "XMLHttpRequest")
            {
                AppAdmin appAdmin = _db.Users.FirstOrDefault(x => x.Id == id);
                if (appAdmin != null)
                {
                    appAdmin.EmailConfirmed = status;
                    if (appAdmin.EmailConfirmed==false)
                    {
                        appAdmin.LockoutEnabled = false;
                    }
                    else
                    {
                        appAdmin.LockoutEnabled = true;
                    }
                    _db.SaveChanges();
                    return Json(new { res = true });
                }
            }

            AppAdmin appUser = await _userManager.FindByNameAsync(User.Identity.Name);
            User user = new User(appUser);

            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(User user)
        {
            AppAdmin appUser = await _userManager.FindByNameAsync(User.Identity.Name);

            if (ModelState.IsValid)
            {
                appUser.Email = user.Email;
                appUser.Lastname = user.Lastname;
                appUser.Firstname = user.Firstname;
                if (user.Password != null)
                {
                    appUser.PasswordHash = _passwordHasher.HashPassword(appUser, user.Password);
                }

                IdentityResult result = await _userManager.UpdateAsync(appUser);
                if (result.Succeeded)
                    TempData["Success"] = "Sənin Məlumatların dəyişdirildi!";
            }

            return View();
        }
        [AllowAnonymous]
        public async Task<IActionResult> EditPassword(string Token)
        {
            if (!string.IsNullOrEmpty(Token))
            {
                AppAdmin appUser = await _db.Users.FirstOrDefaultAsync(x => x.ConcurrencyStamp == Token);

                if (appUser!=null)
                {

                    User user = new User(appUser);

                    return View(user);
                }

            }
            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> EditPassword(User user)
        {

            if (ModelState.IsValid)
            {

                AppAdmin appUser = await _db.Users.FirstOrDefaultAsync(x => x.Email == user.Email);

                if (user.Password != null)
                {
                    appUser.PasswordHash = _passwordHasher.HashPassword(appUser, user.Password);
                }
                await _db.SaveChangesAsync();
                IdentityResult result = await _userManager.UpdateAsync(appUser);
                if (result.Succeeded)
                    TempData["Success"] = "Sənin Məlumatların dəyişdirildi!";
                return RedirectToAction("index", "dashboard");
            }

            return View(user);
        }
        public async Task<IActionResult> Remove(string Email)
        {
            AppAdmin appAdmin = await _userManager.FindByEmailAsync(Email);
            if (appAdmin != null)
            {
                IdentityResult result = await _userManager.DeleteAsync(appAdmin);
                if (result.Succeeded)
                    TempData["Success"] = "Admin Silindi";
                return RedirectToAction("index", "users");
            }

            return LocalRedirect("/home/error");
        }

        [AllowAnonymous]
        public IActionResult ForgotPassword() { return View(); }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> ForgotPassword(string Email) 
        {
            if (!string.IsNullOrEmpty(Email))
            {
                AppAdmin appAdmin = await _db.Users.FirstOrDefaultAsync(x => x.Email == Email);
                if (appAdmin !=null)
                {
                    SendMail mail = new SendMail();
                    mail.ForgotPassword(appAdmin);
                    TempData["Success"] = "Zəhmət olmasa E-Poçt ünvanını yoxlayın";
                    return RedirectToAction("login", "users");
                }
            }
            TempData["Success"] = "Yanlış E-Poçt";
            return View();
        }

    }
}