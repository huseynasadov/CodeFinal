using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.Models
{
    public class SettingTranslate:BaseAuditClass
    {
        [ForeignKey("Setting")]
        public int SettingId { get; set; }
        [ForeignKey("Language")]
        public int LanguageId { get; set; }
        public Setting Setting { get; set; }
        public Language Language { get; set; }

        [Required, MaxLength(300)]
        public string Address { get; set; }
        [MaxLength(200)]
        public string FAQTitle { get; set; }
        public string FAQContent { get; set; }
        [Column(TypeName ="ntext")]
        public string Privacy { get; set; }
    }
}
