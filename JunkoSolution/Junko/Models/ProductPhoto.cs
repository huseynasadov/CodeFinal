using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.Models
{
    public class ProductPhoto
    {
        public int Id { get; set; }
        [ForeignKey("Product")]
        [Display(Name ="Məhsul")]
        public int ProductId { get; set; }
        [Display(Name = "Məhsul")]
        public Product Product { get; set; }
        [MaxLength(500)]
        [Display(Name = "Şəkil")]
        public string Photo { get; set; }
        [Display(Name = "Yaranma tarixi")]
        public DateTime CreatedAt { get; set; }
        public bool Status { get; set; }
        [NotMapped]
        public IFormFile PhotoUpload { get; set; }
    }
}
