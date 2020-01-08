using Junko.Models;
using Junko.ModelTranslate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.ViewModels
{
    public class BlogDetailVM
    {

        public BlogTranslate Blog { get; set; }
        public ICollection<BlogCategory> BlogCategories { get; set; }
        public BlogVM BlogVM { get; set; }
        public int? UserClientId { get; set; }
        public int? AdminId { get; set; }
    }
}
