using Junko.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.ModelTranslate
{
    public class BlogTranslate
    {
        public int Id { get; set; }
        [Display(Name = "Xəbər")]
        public int? BlogId { get; set; }
        [Display(Name = "Dil")]
        public int LanguageId { get; set; }
        [Display(Name = "Xəbər")]
        public Blog Blog { get; set; }
        [Display(Name = "Dil")]
        public Language Language { get; set; }
        [Required, MaxLength(200)]
        [Display(Name = "Başlıq")]
        public string Title { get; set; }
        [Required, MaxLength(300)]
        public string Slug { get; set; }
        [Required, MaxLength(700)]
        [Display(Name = "Qısa məzmun")]
        public string Desc { get; set; }
        [Required,Column(TypeName = "ntext")]
        [Display(Name = "Məzmun")]
        public string Content { get; set; }
    }
}
