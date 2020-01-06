using Junko.DAL;
using Junko.Helpers;
using Junko.Models;
using Junko.ViewModels;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.ViewComponents
{
    public class SmallCartViewComponent:ViewComponent
    {
        private readonly JunkoDBContext _db;
        public SmallCartViewComponent(JunkoDBContext context)
        {
            _db = context;
        }
        public IViewComponentResult Invoke()
        {
            var rqf = Request.HttpContext.Features.Get<IRequestCultureFeature>();
            var culture = rqf.RequestCulture.Culture;
            List<CartItem> cart = HttpContext.Session.GetJson<List<CartItem>>("Cart");
            List<CartItem> cartWishlist = HttpContext.Session.GetJson<List<CartItem>>("Wishlist");
            SmallCartVM model = new SmallCartVM
            {
                LanguageId = _db.Languages.FirstOrDefault(x => x.LanguageCode == culture.ToString()).Id,
                TotalAmount=0,
                NumberOfItems=0,
                WishlistCount=cartWishlist!=null?cartWishlist.Count():0
            };
            if (cart!=null)
            {
                model.NumberOfItems = cart.Sum(x => x.Quantity);
                model.TotalAmount = cart.Sum(x => x.Quantity * x.Price);
                model.CartItems = cart.OrderByDescending(x=>x.CreatedAt).ToList();
            }
            return View(model);
        }
    }
}
