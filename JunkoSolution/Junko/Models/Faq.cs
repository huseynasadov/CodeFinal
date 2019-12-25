using Junko.ModelTranslate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.Models
{
    public class Faq : BaseAuditClass
    {
        public bool Status { get; set; }
        public int? Order { get; set; }
        public ICollection<FaqTranslate> FaqTranslates { get; set; }
    }
}
