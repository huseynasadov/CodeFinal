using Junko.ModelTranslate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.Models
{
    public class Language
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LanguageCode { get; set; }
        public ICollection<SettingTranslate> SettingTranslates { get; set; }
        public ICollection<BlogCategoryTranslate> BlogCategoryTranslates { get; set; }
        public ICollection<AdminCategoryTranslate> AdminCategoryTranslates { get; set; }
        public ICollection<BlogTranslate> BlogTranslates { get; set; }

    }
}
