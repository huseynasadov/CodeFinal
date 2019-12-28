using Junko.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.ModelTranslate
{
    public class ProductTranslate
    {
        public int Id { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        [ForeignKey("Language")]
        public int LanguageId { get; set; }
        public Product Product { get; set; }
        public Language Language { get; set; }
        public string Desc { get; set; }
    }
}
