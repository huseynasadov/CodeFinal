using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.Models
{
    public class BrandProductCategory
    {
        public int Id { get; set; }
        [ForeignKey("Brand")]
        [Display(Name="Brend")]
        public int BrandId { get; set; }
        [ForeignKey("ProductSubCategory")]
        [Display(Name = "Məhsul Alt kateqoriyası")]
        public int ProductSubCategoryId { get; set; }
        [Display(Name = "Brend")]
        public Brand Brand { get; set; }
        [Display(Name = "Məhsul Alt kateqoriyası")]
        public ProductSubCategory ProductSubCategory { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
