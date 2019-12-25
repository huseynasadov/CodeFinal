using Junko.Models;
using Junko.ModelTranslate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.ViewModels
{
    public class BlogVM
    {
        public Breadcrumb Breadcrumb { get; set; }
        public Pagination Pagination { get; set; }
        public ICollection<BlogTranslate> Blogs { get; set; }
        public ICollection<BlogTranslate> ArchiveBlogs { get; set; }
        public ICollection<BlogCategoryTranslate> Categories { get; set; }
    }
}
