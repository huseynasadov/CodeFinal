using Junko.Service.DataService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.ViewComponents
{
    public class FooterViewComponent: ViewComponent
    {
        private readonly ISettingService _settingService;
        public FooterViewComponent(ISettingService settingService)
        {
            _settingService = settingService;

        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = await _settingService.GetFirst();
            return View(items);
        }
    }
}
