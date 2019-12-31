using Junko.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.ModelTranslate
{
    public class HomeHeaderTranslate
    {
        public int Id { get; set; }
        [ForeignKey("HomeHeader")]
        public int HomeHeaderId { get; set; }
        [ForeignKey("Language")]
        public int LanguageId { get; set; }
        public HomeHeader HomeHeader { get; set; }
        public Language Language { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
    }
}
