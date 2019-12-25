using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.ViewModels
{
    public enum Page {Home,Shop,ShopDetail,Blog,BlogDetail,About,Service,FAQ,Privacy,Account,Wishlist,Login,Cart,Checkout }
    public class Breadcrumb
    {
        public Dictionary<string, string> Path { get; set; }
        public Page Page { get; set; }
    }
}
