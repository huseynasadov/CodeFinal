using Junko.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.ViewComponents
{
    public class ModalViewComponent:ViewComponent
    {
        private readonly JunkoDBContext _db;
        public ModalViewComponent(JunkoDBContext context)
        {
            _db = context;
        }
        public async Task<IViewComponentResult> InvokeAsync(int a)
        {
            
            return View();
        }
    }
}
