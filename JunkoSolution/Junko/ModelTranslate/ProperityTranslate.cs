using Junko.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.ModelTranslate
{
    public class ProperityTranslate
    {
        public int Id { get; set; }
        [ForeignKey("Properity")]
        [Display(Name = "Xüsusiyyət")]
        public int? ProperityId { get; set; }
        [ForeignKey("Language")]
        [Display(Name = "Dil")]
        public int LanguageId { get; set; }
        public Properity Properity { get; set; }
        public Language Language { get; set; }
        [Required, MaxLength(100)]
        [Display(Name="Ad")]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Slug { get; set; }
    }
}
