﻿using System;
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
                return Redirect((!string.IsNullOrEmpty(Request.Headers["Referer"]) ? Request.Headers["Referer"].ToString() : "/"));


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

        public async Task<IActionResult> AddWishlist(int id)
        {
            Product product = await _db.Products.Include("ProductPhotos").FirstOrDefaultAsync(a => a.Id == id);
            List<CartItem> cart = HttpContext.Session.GetJson<List<CartItem>>("Wishlist") ?? new List<CartItem>();
            CartItem cartItem = cart.FirstOrDefault(x => x.ProductId == id);
            if (cartItem == null)
            {
                cart.Add(new CartItem(product));
            }
            else
            {
                if (HttpContext.Request.Headers["x-requested-with"] != "XMLHttpRequest")
                    return Redirect((!string.IsNullOrEmpty(Request.Headers["Referer"]) ? Request.Headers["Referer"].ToString() : "/"));

                return ViewComponent("SmallCart");
            }
           
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

        public IActionResult Checkout()
        {
            var rqf = Request.HttpContext.Features.Get<IRequestCultureFeature>();
            var culture = rqf.RequestCulture.Culture;

            var cookieValue = Request.Cookies["Token"];
            if (cookieValue == null) return RedirectToAction("index", "login");
            User user = _db.Users.FirstOrDefault(a => a.Token == cookieValue);
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
                if (_db.OrderProducts.FirstOrDefault(x => x.ProductId == cart.ProductId && x.UserId==user.Id) != null)
                {
                    _db.OrderProducts.FirstOrDefault(x => x.ProductId == cart.ProductId && x.UserId == user.Id).Quantity = cart.Quantity;
                    _db.SaveChanges();
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
                        Complete=Complete.Processsing
                    };
                    _db.OrderProducts.Add(orderProduct);
                    _db.SaveChanges();
                }
            }
            model.OrderProducts = _db.OrderProducts.Include("Product").Where(x => x.UserId == user.Id && x.Status==true).OrderByDescending(x => x.CreatedAt).ToList();
            return View(model);
        }

        public IActionResult RemoveOrder(int? id) {
            if (id == null) return RedirectToAction("error", "home");
            OrderProduct orderProduct = _db.OrderProducts.FirstOrDefault(x => x.Id == id && x.Status == true);
            if(orderProduct==null) return RedirectToAction("error", "home");
            orderProduct.Status = false;
            _db.SaveChanges();
            return Redirect((!string.IsNullOrEmpty(Request.Headers["Referer"]) ? Request.Headers["Referer"].ToString() : "/"));
        }
    }
}