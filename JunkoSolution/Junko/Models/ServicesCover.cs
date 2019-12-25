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
    public class ServicesCover:BaseAuditClass
    {
        [MaxLength(250)]
        public string Photo { get; set; }
        [NotMapped]
        public IFormFile PhotoUpload { get; set; }
        public bool Status { get; set; }
        public int Order { get; set; }
        public ICollection<ServicesCoverTranslate> ServicesCoverTranslates { get; set; }
    }
}
