using Junko.DAL;
using Junko.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.ViewComponents
{
    public class ControlUserViewComponent : ViewComponent
    {
        private readonly UserManager<AppAdmin> _userManager;
        public ControlUserViewComponent(UserManager<AppAdmin> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            AppAdmin appUser = await _userManager.FindByNameAsync(User.Identity.Name);
            if (appUser!=null)
            {
                ViewBag.AdminUser = appUser.Email;
            }

            return View();
        }
    }
}
