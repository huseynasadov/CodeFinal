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
        [Display(Name ="Ust kateqoriya")]
        public int ProductCategoryId { get; set; }
        [MaxLength(250)]
        [Display(Name = "Şəkil")]
        public string Photo { get; set; }
        [Display(Name = "Endirim")]
        public byte? Discount { get; set; }
        [Display(Name = "Endirim müddəti")]
        public int? DiscountDate { get; set; }
        [NotMapped]
        public IFormFile PhotoUpload { get; set; }
        public bool Status { get; set; }
        [Display(Name = "Yaranma tarixi")]
        public DateTime CreatedAt { get; set; }
        [Display(Name = "Ust kateqoriya")]
        public ProductCategory ProductCategory { get; set; }
        public ICollection<ProductSubCategoryTranslate> ProductSubCategoryTranslate { get; set; }
        public ICollection<BrandProductCategory> BrandProductCategories { get; set; }
        public ICollection<ProperityCategory> ProperityCategories { get; set; }
    }
}
