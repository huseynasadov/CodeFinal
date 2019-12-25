using Junko.ModelTranslate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.Models
{
    public class OurService:BaseAuditClass
    {
        [Required,MaxLength(100)]
        public string Icon { get; set; }
        public bool Status { get; set; }
        public int Order { get; set; }
        public ICollection<OurServiceTranslate> OurServiceTranslates { get; set; }
    }
}
