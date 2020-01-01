using Junko.ModelTranslate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.Models
{
    public class Product:BaseAuditClass
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public int BrandProductCategoryId { get; set; }
        public decimal Price { get; set; }
        public byte? Discount { get; set; }
        public int? DiscountDate { get; set; }
        public bool Status { get; set; }
        public bool IsFavory { get; set; }
        public DateTime CreatedAt { get; set; }
        public decimal? FollowCount { get; set; }
        public BrandProductCategory BrandProductCategory { get; set; }
        public ICollection<ProductTranslate> ProductTranslates { get; set; }
        public ICollection<ProductPhoto> ProductPhotos { get; set; }
        public ICollection<ProductColor> ProductColors { get; set; }


    }
}
