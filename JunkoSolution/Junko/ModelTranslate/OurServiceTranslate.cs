using Junko.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.ModelTranslate
{
    public class OurServiceTranslate
    {
        public int Id { get; set; }
        [ForeignKey("OurService")]
        public int OurServiceId { get; set; }
        [ForeignKey("Language")]
        public int LanguageId { get; set; }
        public OurService OurService { get; set; }
        public Language Language { get; set; }
        [Required,MaxLength(200)]
        public string Title { get; set; }
        [Required, MaxLength(300)]
        public string Desc { get; set; }
    }
}
