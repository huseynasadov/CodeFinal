﻿using Junko.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.ModelTranslate
{
    public class ProductCategoryTranslate
    {
        public int Id { get; set; }
        [ForeignKey("ProductCategory")]
        public int ProductCategoryId { get; set; }
        [ForeignKey("Language")]
        public int LanguageId { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public Language Language { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(150)]
        public string Slug { get; set; }
    }
}
