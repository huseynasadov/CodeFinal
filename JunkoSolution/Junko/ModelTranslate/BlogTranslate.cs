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
        public int BlogId { get; set; }
        public int LanguageId { get; set; }
        public Blog Blog { get; set; }
        public Language Language { get; set; }
        [Required, MaxLength(200)]
        public string Title { get; set; }

        [Required, MaxLength(300)]
        public string Slug { get; set; }
        [Required, MaxLength(700)]
        public string Desc { get; set; }
        [Required,Column(TypeName = "ntext")]
        public string Content { get; set; }
    }
}
