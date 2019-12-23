using Junko.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.ModelTranslate
{
    public class AdminCategoryTranslate
    {
        public int Id { get; set; }
        public int AdminCategoryId { get; set; }
        public int LanguageId { get; set; }
        public AdminCategory AdminCategory { get; set; }
        public Language Language { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }
    }
}
