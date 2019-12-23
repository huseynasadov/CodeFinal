using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.Models
{
    public class SocialActivity : BaseAuditClass
    {
        [ForeignKey("Setting")]
        public int SettingId { get; set; }
        [Required,MaxLength(50)]
        public string Name { get; set; }
        [Required, MaxLength(200)]
        public string Link { get; set; }
        public Setting Setting { get; set; }
    }
}
