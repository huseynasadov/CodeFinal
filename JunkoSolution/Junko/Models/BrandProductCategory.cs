using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.Models
{
    public class BrandProductCategory
    {
        public int Id { get; set; }
        [ForeignKey("Brand")]
        public int BrandId { get; set; }
        [ForeignKey("ProductSubCategory")]
        public int ProductSubCategoryId { get; set; }
        public Brand Brand { get; set; }
        public ProductSubCategory ProductSubCategory { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
