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
    public class Blog:BaseAuditClass
    {
        [MaxLength(400)]
        [Display(Name ="Şəkil")]
        public string Photo { get; set; }
        [Display(Name = "Yaranma tarixi")]
        public DateTime CreatedAt { get; set; }
        [NotMapped]
        public IFormFile PhotoUpload { get; set; }
        public bool Status { get; set; }
        public ICollection<BlogCategory> BlogCategories { get; set; }
        public ICollection<BlogTranslate> BlogTranslates { get; set; }
        public ICollection<BlogReview> BlogReviews { get; set; }

    }
}
