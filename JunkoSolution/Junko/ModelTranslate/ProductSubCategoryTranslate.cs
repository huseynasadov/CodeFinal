﻿using Junko.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.ModelTranslate
{
    public class ProductSubCategoryTranslate
    {
        public int Id { get; set; }
        [ForeignKey("ProductSubCategory")]
        [Display(Name = "Alt kateqoriya")]
        public int? ProductSubCategoryId { get; set; }
        [ForeignKey("Language")]
        [Display(Name = "Dil")]
        public int LanguageId { get; set; }
        public ProductSubCategory ProductSubCategory { get; set; }
        public Language Language { get; set; }
        [Required, MaxLength(100)]
        [Display(Name = "Ad")]
        public string Name { get; set; }
    }
}
