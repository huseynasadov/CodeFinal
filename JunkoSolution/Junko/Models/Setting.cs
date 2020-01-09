﻿using Junko.Helpers;
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
        [Display(Name = "Loqo Adı")]
        public string Logo { get; set; }

        [MaxLength(250)]
        [FileExtension]
        [Display(Name = "Loqo Şəkli")]
        public string PhotoLogo { get; set; }
        [Required, MaxLength(20),MinLength(10)]
        [Display(Name = "Telefon")]
        public string Phone { get; set; }
        [Required,MaxLength(100)]
        [Display(Name = "Yerləşmə")]
        public string Location { get; set; }
        [Required,EmailAddress]
        [Display(Name = "E-Poçt")]
        public string Email { get; set; }
        [NotMapped]
        public IFormFile PhotoUpload { get; set; }
        public ICollection<SocialActivity> SocialActivities { get; set; }
        public ICollection<SettingTranslate> SettingTranslates { get; set; }
    }
}
