using Junko.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.ViewModels
{
    public class CartVM
    {
        public List<CartItem> CartItems { get; set; }
        public decimal GrandTotal { get; set; }
        public Breadcrumb Breadcrumb { get; set; }
        public int LanguageId { get; set; }
    }
}
