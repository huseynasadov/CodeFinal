using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.Models
{
    public class Brand:BaseAuditClass
    {
        [Required,MaxLength(100)]
        [Display(Name = "Ad")]
        public string Name { get; set; }
        [MaxLength(200)]
        public string Slug { get; set; }
        public bool Status { get; set; }
        [Display(Name = "Yaranma Tarixi")]
        public DateTime CreatedAt { get; set; }
        public ICollection<BrandProductCategory> BrandProductCategories { get; set; }
    }
}
