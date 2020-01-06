using Junko.Helpers;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.Models
{
    public class Setting:BaseAuditClass
    {
        [Required,MaxLength(50)]
        public string Logo { get; set; }

        [MaxLength(250)]
        [FileExtension]
        [Display(Name = "Logo Image")]
        public string PhotoLogo { get; set; }
        [Required, MaxLength(20),MinLength(10)]
        public string Phone { get; set; }
        [Required,MaxLength(100)]
        public string Location { get; set; }
        [Required,EmailAddress]
        public string Email { get; set; }
        [NotMapped]
        public IFormFile PhotoUpload { get; set; }
        public ICollection<SocialActivity> SocialActivities { get; set; }
        public ICollection<SettingTranslate> SettingTranslates { get; set; }
    }
}
