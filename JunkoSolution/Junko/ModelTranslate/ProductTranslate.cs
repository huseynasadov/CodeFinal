using Junko.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.ModelTranslate
{
    public class ProductTranslate
    {
        public int Id { get; set; }
        [ForeignKey("Product")]
        [Display(Name = "Məhsul")]
        public int? ProductId { get; set; }
        [ForeignKey("Language")]
        [Display(Name = "Dil")]
        public int LanguageId { get; set; }
        public Product Product { get; set; }
        public Language Language { get; set; }
        [Display(Name = "Haqqında")]
        public string Desc { get; set; }
    }
}
