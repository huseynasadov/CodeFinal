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
    public class HomeHeader
    {
        public int Id { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        [MaxLength(250)]
        public string Photo { get; set; }
        [NotMapped]
        public IFormFile PhotoUpload { get; set; }
        public int? Order { get; set; }
        public DateTime ModifiedAt { get; set; }
        public ICollection<HomeHeaderTranslate> HomeHeaderTranslates { get; set; }
    }
}
