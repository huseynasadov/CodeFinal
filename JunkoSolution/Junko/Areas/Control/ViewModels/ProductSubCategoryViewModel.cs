using Junko.Models;
using Junko.ModelTranslate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.Areas.Control.ViewModels
{
    public class ProductSubCategoryViewModel
    {
        public ProductSubCategory ProductSubCategory { get; set; }
        public List<ProductSubCategoryTranslate> ProductSubCategoryTranslates { get; set; }
    }
}
