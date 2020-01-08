using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Junko.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Junko.Areas.Control.Controllers
{
    [Area("Control")]
    [Authorize]
    public class UsersController : Controller
    {
        private readonly UserManager<AppAdmin> _userManager;
        private readonly SignInManager<AppAdmin> _signInManager;
        private readonly IPasswordHasher<AppAdmin> _passwordHasher;
        public UsersController(UserManager<AppAdmin> userManager, SignInManager<AppAdmin> signInManager, IPasswordHasher<AppAdmin> passwordHasher)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _passwordHasher = passwordHasher;
        }
        public IActionResult Index()
        {
            return View(_userManager.Users);
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(User user)
        {
            if (ModelState.IsValid)
            {
                AppAdmin appUser = new AppAdmin
                {
                    Firstname = user.Firstname,
                    Lastname = user.Lastname,
                    Email = user.Email
                };
                appUser.UserName = user.Firstname + Guid.NewGuid();
                IdentityResult resultReq = await _userManager.CreateAsync(appUser, user.Password);
                if (resultReq.Succeeded)
                {
                    TempData["Success"] = "Admin is Created";
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
        public IActionResult Login()
        {
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
                    Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(appUser, login.Password, false, false);
                    if (result.Succeeded)
                        return RedirectToAction("index","Dashboard");
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

        public async Task<IActionResult> Edit()
        {
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
                if (user.Password != null)
                {
                    appUser.PasswordHash = _passwordHasher.HashPassword(appUser, user.Password);
                }

                IdentityResult result = await _userManager.UpdateAsync(appUser);
                if (result.Succeeded)
                    TempData["Success"] = "Your information has been edited!";
            }

            return View();
        }

        public async Task<IActionResult> Remove(string Email)
        {
            AppAdmin appAdmin = await _userManager.FindByEmailAsync(Email);
            if (appAdmin!=null)
            {
                IdentityResult result = await _userManager.DeleteAsync(appAdmin);
                if (result.Succeeded)
                    TempData["Success"] = "Admin Deleted";
                return RedirectToAction("index", "users");
            }

            return LocalRedirect("/home/error");
        }
    }
}