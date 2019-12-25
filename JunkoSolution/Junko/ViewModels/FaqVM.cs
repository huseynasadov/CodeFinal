using Junko.Models;
using Junko.ModelTranslate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.ViewModels
{
    public class FaqVM
    {
        public SettingTranslate Setting { get; set; }
        public Breadcrumb Breadcrumb { get; set; }
        public ICollection<FaqTranslate> FaqTranslates { get; set; }
    }
}
