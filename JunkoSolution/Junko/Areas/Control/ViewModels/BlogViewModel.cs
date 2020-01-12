using Junko.Models;
using Junko.ModelTranslate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.Areas.Control.ViewModels
{
    public class BlogViewModel
    {
        public Blog Blog { get; set; }
        public List<BlogTranslate> BlogTranslates { get; set; }
    }
}
