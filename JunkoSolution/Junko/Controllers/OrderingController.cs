using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Junko.DAL;
using Junko.Models;
using Microsoft.AspNetCore.Mvc;
using Junko.Helpers;
using Junko.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Localization;

namespace Junko.Controllers
{
    public class OrderingController : Controller
    {
        private readonly JunkoDBContext _db;
        public OrderingController(JunkoDBContext context)
        {
            _db = context;
        }
        public IActionResult Cart()
        {
            var rqf = Request.HttpContext.Features.Get<IRequestCultureFeature>();
            var culture = rqf.RequestCulture.Culture;
            List<CartItem> cart = HttpContext.Session.GetJson<List<CartItem>>("Cart") ?? new List<CartItem>();
            CartVM model = new CartVM {
                Breadcrumb = new Breadcrumb
                {
                    Path = new Dictionary<string, string> {
                        { "Home", Url.Action("Index", "Home") },
                        { "Cart", null }
                    },
                    Page = Page.Cart
                },
                LanguageId=_db.Languages.FirstOrDefault(a=>a.LanguageCode==culture.ToString()).Id,
                CartItems = cart,
                GrandTotal=cart.Sum(x=>x.Price * x.Quantity)
            };
            return View(model);
        }
        // Add Cart
        public async Task<IActionResult> Add(int id) 
        {
            Product product = await _db.Products.Include("ProductPhotos").FirstOrDefaultAsync(a=>a.Id==id);
            List<CartItem> cart = HttpContext.Session.GetJson<List<CartItem>>("Cart") ?? new List<CartItem>();
            CartItem cartItem = cart.FirstOrDefault(x => x.ProductId == id);
            if (cartItem==null)
            {
                cart.Add(new CartItem(product));
            }
            else
            {
                cartItem.Quantity += 1;
            }

            HttpContext.Session.SetJson("Cart",cart);
            if (HttpContext.Request.Headers["x-requested-with"] != "XMLHttpRequest")
                return Redirect(Request.Headers["Referer"].ToString());


            return ViewComponent("SmallCart");
        }

        public IActionResult Decrease(int id)
        {
            List<CartItem> cart = HttpContext.Session.GetJson<List<CartItem>>("Cart");
            CartItem cartItem = cart.FirstOrDefault(x => x.ProductId == id);
            if (cartItem.Quantity > 1)
            {
                --cartItem.Quantity;
            }
            else
            {
                cart.RemoveAll(x=>x.ProductId==id);
            }

            if (cart.Count==0)
            {
                HttpContext.Session.Remove("Cart");
            }
            else
            {
                HttpContext.Session.SetJson("Cart", cart);
            }
            HttpContext.Session.SetJson("Cart", cart);
            if (HttpContext.Request.Headers["x-requested-with"] != "XMLHttpRequest")
                return Redirect(Request.Headers["Referer"].ToString());

            return RedirectToAction("cart");
        }

        public IActionResult Remove(int id)
        {
            List<CartItem> cart = HttpContext.Session.GetJson<List<CartItem>>("Cart");
                
           cart.RemoveAll(x => x.ProductId == id);
           
            if (cart.Count == 0)
            {
                HttpContext.Session.Remove("Cart");
            }
            else
            {
                HttpContext.Session.SetJson("Cart", cart);
            }
            if (HttpContext.Request.Headers["x-requested-with"] != "XMLHttpRequest")
                return Redirect(Request.Headers["Referer"].ToString());

            return ViewComponent("SmallCart");
        }

        public IActionResult Clear()
        {
           HttpContext.Session.Remove("Cart");

            return Redirect(Request.Headers["Referer"].ToString());
        }

        public IActionResult Wishlist()
        {
            return View();
        }
        public IActionResult Checkout()
        {
            return View();
        }
       
    }
}