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
        public int ProductId { get; set; }
        public Product Product { get; set; }
        [MaxLength(500)]
        public string Photo { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Status { get; set; }
        [NotMapped]
        public IFormFile PhotoUpload { get; set; }
    }
}
