using Junko.Models;
using Junko.ModelTranslate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.ViewModels
{
    public class ShopDetailVM
    {
        public Breadcrumb Breadcrumb { get; set; }
        public Product Product { get; set; }
        public ICollection<Product> LikeProducts { get; set; }
        public ICollection<Product> MostSaledProducts { get; set; }
        public int LanguageId { get; set; }
        public int? UserId { get; set; }
        public int? AdminId { get; set; }
    }
}
