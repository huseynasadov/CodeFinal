using Junko.ModelTranslate;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.Models
{
    public class ProductSubCategory:BaseAuditClass
    {
        [ForeignKey("ProductCategory")]
        public int ProductCategoryId { get; set; }
        [MaxLength(250)]
        public string Photo { get; set; }
        public byte? Discount { get; set; }
        public int? DiscountDate { get; set; }
        [NotMapped]
        public IFormFile PhotoUpload { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public ICollection<ProductSubCategoryTranslate> ProductSubCategoryTranslate { get; set; }
        public ICollection<BrandProductCategory> BrandProductCategories { get; set; }
        public ICollection<ProperityCategory> ProperityCategories { get; set; }
    }
}
