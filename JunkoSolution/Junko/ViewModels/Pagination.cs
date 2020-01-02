using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.ViewModels
{
    public class Pagination
    {
        public int PageCount { get; set; }
        public int CurrentPage { get; set; }
        public Page Page { get; set; }
        public int? CategoryId { get; set; }
        public int? OrderBy { get; set; }
        public int? BrandId { get; set; }
    }
}
