using Junko.ModelTranslate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.Models
{
    public class Category:BaseAuditClass
    {
        public DateTime CreatedAt { get; set; }
        public bool Status { get; set; }
        public ICollection<BlogCategory> BlogCategories { get; set; }
        public ICollection<BlogCategoryTranslate> BlogCategoryTranslates { get; set; }
    }
}
