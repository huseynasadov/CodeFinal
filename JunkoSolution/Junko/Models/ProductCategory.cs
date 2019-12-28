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
    public class ProductCategory:BaseAuditClass
    {
        public string Photo { get; set; }
        [NotMapped]
        public IFormFile PhotoUpload { get; set; }
        public ICollection<ProductCategoryTranslate> ProductCategoryTranslate { get; set; }
        public ICollection<ProductSubCategory> ProductSubCategories { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Status { get; set; }
    }
}
