using Junko.Models;
using Junko.ModelTranslate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.Areas.Control.ViewModels
{
    public class ProductCategoryViewModel
    {
        public ProductCategory ProductCategory { get; set; }
        public List<ProductCategoryTranslate> ProductCategoryTranslates { get; set; }
    }
}
