using Junko.ModelTranslate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.Models
{
    public class Product : BaseAuditClass
    {
        [Display(Name="Ad")]
        [Required,MaxLength(100)]
        public string Name { get; set; }
        [Required, MaxLength(100)]
        public string Slug { get; set; }
        [Display(Name = "Brend < Alt Kateqoriya")]
        [Required]
        public int BrandProductCategoryId { get; set; }
        [Display(Name = "Qiymət")]
        [Required, Range(0,100000)]
        public decimal Price { get; set; }
        [Range(0, 100)]
        [Display(Name = "Endirim (%)")]
        public byte? Discount { get; set; }
        [Display(Name = "Endirim (Gün)")]
        [Range(0, 365)]
        public int? DiscountDate { get; set; }
        public bool Status { get; set; }
        [Display(Name = "Yaranma vaxtı")]
        public DateTime CreatedAt { get; set; }
        [Display(Name = "Baxış sayı")]
        public decimal? FollowCount { get; set; }
        public BrandProductCategory BrandProductCategory { get; set; }
        public ICollection<ProductTranslate> ProductTranslates { get; set; }
        public ICollection<ProductPhoto> ProductPhotos { get; set; }
        public ICollection<ProductColor> ProductColors { get; set; }
        public ICollection<ProperityProduct> ProperityProducts { get; set; }
        public ICollection<ProductReview> ProductReviews { get; set; }
        public ICollection<OrderProduct> OrderProducts { get; set; }


    }
}
