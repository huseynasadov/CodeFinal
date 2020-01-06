using Junko.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.ViewModels
{
    public class CheckoutVM
    {
        public Breadcrumb Breadcrumb { get; set; }
        public ICollection<OrderProduct> OrderProducts { get; set; }
        public int LanguageId { get; set; }
    }
}
