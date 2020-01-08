using Junko.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.ViewModels
{
    public class SettingVM
    {
        public Setting Setting { get; set; }
        public SettingTranslate SettingTranslate { get; set; }
        public ICollection<ProductCategory> ProductCategories{ get; set; }
        public UserClient User { get; set; }
    }
}
