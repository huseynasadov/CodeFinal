using Junko.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.ViewModels
{
    public class SmallCartVM
    {
        public List<CartItem> CartItems { get; set; }
        public int NumberOfItems { get; set; }
        public decimal TotalAmount { get; set; }
        public int LanguageId { get; set; }
        public int WishlistCount { get; set; }
    }
}
