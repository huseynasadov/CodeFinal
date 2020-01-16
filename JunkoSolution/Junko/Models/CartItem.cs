﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.Models
{
    public class CartItem
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get { return Quantity * Price; } }
        public string Image { get; set; }
        public DateTime CreatedAt { get; set; }
        //public string Color { get; set; }

        public CartItem()
        {

        }
        public CartItem(Product product)
        {
            ProductId = product.Id;
            ProductName = product.Name;
            Image = (product.ProductPhotos.Count >0 ? product.ProductPhotos.FirstOrDefault().Photo :"noimage.png");
            Price = product.Price;
            Quantity = 1;
            CreatedAt = DateTime.Now;
            //Color = (product.ProductColors.Count > 0 ? product.ProductColors.FirstOrDefault().Color.Name : "#000");
        }
    }
}
