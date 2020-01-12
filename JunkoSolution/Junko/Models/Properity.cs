using Junko.ModelTranslate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.Models
{
    public class Properity : BaseAuditClass
    {
        public bool Status { get; set; }
        [Display(Name ="Yaranma tarixi")]
        public DateTime CreatedAt { get; set; }
        public ICollection<ProperityTranslate> ProperityTranslates { get; set; }
        public ICollection<ProperityCategory> ProperityCategories { get; set; }
        public ICollection<ProperityProduct> ProperityProducts { get; set; }
    }
}
