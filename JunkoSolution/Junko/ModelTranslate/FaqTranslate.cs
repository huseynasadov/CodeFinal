using Junko.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.ModelTranslate
{
    public class FaqTranslate
    {
        public int Id { get; set; }
        [ForeignKey("Faq")]
        public int FaqId { get; set; }
        [ForeignKey("Language")]
        public int LanguageeId { get; set; }
        public Faq Faq { get; set; }
        public Language Language { get; set; }
        [Required,MaxLength(100)]
        public string Question { get; set; }
        [Required, MaxLength(500)]
        public string Answer { get; set; }
    }
}
