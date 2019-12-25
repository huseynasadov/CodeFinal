using Junko.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.ModelTranslate
{
    public class AboutSettingTranslate
    {
        public int Id { get; set; }
        [ForeignKey("AboutSetting")]
        public int AboutSettingId { get; set; }
        [ForeignKey("Language")]
        public int LanguageId { get; set; }
        public AboutSetting AboutSetting { get; set; }
        public Language Language { get; set; }
        [Required, MaxLength(150)]
        public string Title { get; set; }
        [Required, MaxLength(600)]
        public string Desc { get; set; }
    }
}
