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
                LanguageId= _db.Languages.FirstOrDefault(a=>a.LanguageCode==culture.ToString()).Id,
                CartItems = cart,
                GrandTotal=cart.Sum(x=>x.Price * x.Quantity)
            };

            ViewBag.Colors = _db.ProductColors.Include("Color").ToList();
            return View(model);
        }
        // Add Cart
        public async Task<IActionResult> Add(int id,int colorId=1) 
        {
            Product product = await _db.Products.Include("ProductPhotos").Include("ProductColors.Color").FirstOrDefaultAsync(a=>a.Id==id);
            List<CartItem> cart = HttpContext.Session.GetJson<List<CartItem>>("Cart") ?? new List<CartItem>();
            CartItem cartItem = cart.FirstOrDefault(x => x.ProductId == id && x.ColorId==colorId);
            Color color = await _db.Colors.FirstOrDefaultAsync(x => x.Id == colorId);
            int MostFollowed = (int)_db.Products.Where(x => x.Status == true).OrderByDescending(x => x.FollowCount).FirstOrDefault().FollowCount;
            int ThisFollowd = (int)product.FollowCount;
            product.StarCount = (ThisFollowd *5/ MostFollowed);
            if (cartItem==null)
            {
                cart.Add(new CartItem(product, color));
            }
            else
            {
                cartItem.Quantity += 1;
            }
            
            await _db.SaveChangesAsync();

            HttpContext.Session.SetJson("Cart",cart);
            if (HttpContext.Request.Headers["x-requested-with"] != "XMLHttpRequest")
                return Redirect((!string.IsNullOrEmpty(Request.Headers["Referer"]) ? Request.Headers["Referer"].ToString() : "/"));


            return ViewComponent("SmallCart");
        }

        public async Task<IActionResult> Decrease(int id,int colorId=1)
        {
            List<CartItem> cart = HttpContext.Session.GetJson<List<CartItem>>("Cart");
            CartItem cartItem = cart.FirstOrDefault(x => x.ProductId == id && x.ColorId == colorId);
            Color color = await _db.Colors.FirstOrDefaultAsync(x => x.Id == colorId);
            if (cartItem.Quantity > 1)
            {
                --cartItem.Quantity;
            }
            else
            {
                cart.RemoveAll(x=>x.ProductId==id && x.ColorId==colorId);
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
                return Redirect((!string.IsNullOrEmpty(Request.Headers["Referer"]) ? Request.Headers["Referer"].ToString() : "/"));

            return RedirectToAction("cart");
        }
        [HttpPost]
        public IActionResult ChangeColor(int productId, int colorId=1)
        {
            List<CartItem> cart = HttpContext.Session.GetJson<List<CartItem>>("Cart");
            CartItem cartItem = cart.FirstOrDefault(x => x.ProductId == productId);
            cartItem.ColorId = colorId;

            HttpContext.Session.SetJson("Cart", cart);
            if (HttpContext.Request.Headers["x-requested-with"] != "XMLHttpRequest")
                return Redirect((!string.IsNullOrEmpty(Request.Headers["Referer"]) ? Request.Headers["Referer"].ToString() : "/"));

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
                return Redirect((!string.IsNullOrEmpty(Request.Headers["Referer"]) ? Request.Headers["Referer"].ToString() : "/"));

            return ViewComponent("SmallCart");
        }

        public IActionResult Clear()
        {
           HttpContext.Session.Remove("Cart");

            return Redirect((!string.IsNullOrEmpty(Request.Headers["Referer"]) ? Request.Headers["Referer"].ToString() : "/"));
        }

        public IActionResult Wishlist()
        {
            var rqf = Request.HttpContext.Features.Get<IRequestCultureFeature>();
            var culture = rqf.RequestCulture.Culture;
            List<CartItem> cart = HttpContext.Session.GetJson<List<CartItem>>("Wishlist") ?? new List<CartItem>();
            CartVM model = new CartVM
            {
                Breadcrumb = new Breadcrumb
                {
                    Path = new Dictionary<string, string> {
                        { "Home", Url.Action("Index", "Home") },
                        { "Wishlist", null }
                    },
                    Page = Page.Wishlist
                },
                LanguageId = _db.Languages.FirstOrDefault(a => a.LanguageCode == culture.ToString()).Id,
                CartItems = cart,
                GrandTotal = cart.Sum(x => x.Price * x.Quantity)
            };
            return View(model);
        }

        public async Task<IActionResult> AddWishlist(int id,int colorId=1)
        {
            Product product = await _db.Products.Include("ProductPhotos").FirstOrDefaultAsync(a => a.Id == id);
            Color color = await _db.Colors.FirstOrDefaultAsync(x => x.Id == colorId);
            List<CartItem> cart = HttpContext.Session.GetJson<List<CartItem>>("Wishlist") ?? new List<CartItem>();
            CartItem cartItem = cart.FirstOrDefault(x => x.ProductId == id && x.ColorId==colorId);
            int MostFollowed = (int)_db.Products.Where(x => x.Status == true).OrderByDescending(x => x.FollowCount).FirstOrDefault().FollowCount;
            int ThisFollowd = (int)product.FollowCount;
            product.StarCount = (ThisFollowd * 5 / MostFollowed);
            if (cartItem == null)
            {
                cart.Add(new CartItem(product, color));
            }
            else
            {
                if (HttpContext.Request.Headers["x-requested-with"] != "XMLHttpRequest")
                    return Redirect((!string.IsNullOrEmpty(Request.Headers["Referer"]) ? Request.Headers["Referer"].ToString() : "/"));

                return ViewComponent("SmallCart");
            }

            
            await _db.SaveChangesAsync();
            HttpContext.Session.SetJson("Wishlist", cart);
            if (HttpContext.Request.Headers["x-requested-with"] != "XMLHttpRequest")
                return Redirect((!string.IsNullOrEmpty(Request.Headers["Referer"]) ? Request.Headers["Referer"].ToString() : "/"));


            return ViewComponent("SmallCart");
        }

        public IActionResult RemoveWishlist(int id)
        {
            List<CartItem> cart = HttpContext.Session.GetJson<List<CartItem>>("Wishlist");

            cart.RemoveAll(x => x.ProductId == id);

            if (cart.Count == 0)
            {
                HttpContext.Session.Remove("Wishlist");
            }
            else
            {
                HttpContext.Session.SetJson("Wishlist", cart);
            }

           return Redirect((!string.IsNullOrEmpty(Request.Headers["Referer"]) ? Request.Headers["Referer"].ToString() : "/"));
        }

        public IActionResult ClearWishlist()
        {
            HttpContext.Session.Remove("Wishlist");

            return Redirect((!string.IsNullOrEmpty(Request.Headers["Referer"]) ? Request.Headers["Referer"].ToString() : "/"));
        }

        public async Task<IActionResult> Checkout()
        {
            var rqf = Request.HttpContext.Features.Get<IRequestCultureFeature>();
            var culture = rqf.RequestCulture.Culture;

            var cookieValue = Request.Cookies["Token"];
            if (cookieValue == null) return RedirectToAction("index", "login");
            UserClient user = await _db.UserClients.FirstOrDefaultAsync(a => a.Token == cookieValue);
            if (user == null) return  RedirectToAction("index", "login");

            List<CartItem> carts = HttpContext.Session.GetJson<List<CartItem>>("Cart") ?? new List<CartItem>();
            CheckoutVM model = new CheckoutVM {
                Breadcrumb = new Breadcrumb
                {
                    Path = new Dictionary<string, string> {
                        { "Home", Url.Action("Index", "Home") },
                        { "Checkout", null }
                    },
                    Page = Page.Checkout
                },
                LanguageId=_db.Languages.FirstOrDefault(x=>x.LanguageCode==culture.ToString()).Id
            };

            foreach (var cart in carts)
            {
                if (await _db.OrderProducts.FirstOrDefaultAsync(x => x.ProductId == cart.ProductId &&  x.UserClientId==user.Id && x.Complete==Complete.Processsing && x.Status==true) != null)
                {
                    _db.OrderProducts.FirstOrDefault(x => x.ProductId == cart.ProductId && x.UserClientId == user.Id && x.Complete == Complete.Processsing && x.Status==true).Quantity += cart.Quantity;
                   await _db.SaveChangesAsync();
                }
                else
                {
                    OrderProduct orderProduct = new OrderProduct
                    {
                        ProductId = cart.ProductId,
                        Price = cart.Price,
                        Quantity = cart.Quantity,
                        CreatedAt = DateTime.Now,
                        User = user,
                        Status=true,
                        Complete=Complete.Processsing,
                        ColorId = cart.ColorId
                    };
                   await _db.OrderProducts.AddAsync(orderProduct);
                   await _db.SaveChangesAsync();
                }
            }
            model.OrderProducts =await _db.OrderProducts.Include("Product").Where(x => x.UserClientId == user.Id && x.Status==true && x.Complete==Complete.Processsing).OrderByDescending(x => x.CreatedAt).ToListAsync();
            return View(model);
        }

        public async Task<IActionResult> RemoveOrder(int? id) {
            if (id == null) return RedirectToAction("error", "home");
            OrderProduct orderProduct =await _db.OrderProducts.FirstOrDefaultAsync(x => x.Id == id && x.Status == true);
            if(orderProduct==null) return RedirectToAction("error", "home");
            orderProduct.Status = false;
           await _db.SaveChangesAsync();
            return Redirect((!string.IsNullOrEmpty(Request.Headers["Referer"]) ? Request.Headers["Referer"].ToString() : "/"));
        }
    }
}