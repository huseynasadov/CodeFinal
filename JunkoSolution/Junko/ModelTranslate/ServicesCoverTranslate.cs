using Junko.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.ModelTranslate
{
    public class ServicesCoverTranslate
    {
        public int Id { get; set; }
        [ForeignKey("ServicesCover")]
        public int? ServicesCoverId { get; set; }
        [ForeignKey("Language")]
        public int LanguageId { get; set; }
        public ServicesCover ServicesCover { get; set; }
        public Language Language { get; set; }

        [Required, MaxLength(100)]
        public string Title { get; set; }
        [Required, MaxLength(500)]
        public string Desc { get; set; }
    }
}
