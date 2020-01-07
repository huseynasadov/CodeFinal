using Junko.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.Areas.Control.ViewModels
{
    public class SettingViewModel
    {
        public Setting Setting { get; set; }
        public List<SettingTranslate> SettingTranslates { get; set; }
    }
}
