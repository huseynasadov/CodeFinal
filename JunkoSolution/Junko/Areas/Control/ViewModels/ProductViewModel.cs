using Junko.Models;
using Junko.ModelTranslate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.Areas.Control.ViewModels
{
    public class ProductViewModel
    {
        public Product Product { get; set; }
        public List<ProductTranslate> ProductTranslates { get; set; }
        public List<BrandProductCategory> BrandProductCategories { get; set; }
    }
}
