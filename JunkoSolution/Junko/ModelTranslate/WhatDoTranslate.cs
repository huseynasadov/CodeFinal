using Junko.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.ModelTranslate
{
    public class WhatDoTranslate
    {
        public int Id { get; set; }
        [ForeignKey("WhatDo")]
        public int? WhatDoId { get; set; }
        [ForeignKey("Language")]
        public int LanguageId { get; set; }
        public WhatDo WhatDo { get; set; }
        public Language Language { get; set; }
        [Required, MaxLength(200)]
        public string Title { get; set; }
        [Required, MaxLength(600)]
        public string Desc { get; set; }
    }
}
