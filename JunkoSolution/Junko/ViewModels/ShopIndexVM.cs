using Junko.Models;
using Junko.ModelTranslate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.ViewModels
{
    public class ShopIndexVM
    {
        public Breadcrumb Breadcrumb { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<ProductCategoryTranslate> ProductCategoryTranslates { get; set; }
        public Pagination Pagination { get; set; }
        public int ProductCount { get; set; }
    }
}
