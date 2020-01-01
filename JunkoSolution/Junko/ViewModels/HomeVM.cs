using Junko.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.ViewModels
{
    public class HomeVM
    {
        public ICollection<HomeHeader> HomeHeaders  { get; set; }
        public ICollection<Product> MostSaleds { get; set; }
        public ICollection<Product> NewProducts { get; set; }
        public ICollection<Product> SaledProducts { get; set; }
        public ICollection<Product> MostFollowProducts { get; set; }
        public ICollection<ProductCategory> BestCategory { get; set; }
        public ICollection<ProductCategory> NewProductsCategory { get; set; }
        public Product BestFollow { get; set; }
        public ICollection<Partner> Partners { get; set; }
        public int LanguageId { get; set; }
    }
}
