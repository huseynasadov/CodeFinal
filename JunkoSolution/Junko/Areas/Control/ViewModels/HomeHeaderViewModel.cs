using Junko.Models;
using Junko.ModelTranslate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.Areas.Control.ViewModels
{
    public class HomeHeaderViewModel
    {
        public HomeHeader HomeHeader { get; set; }
        public List<HomeHeaderTranslate> HomeHeaderTranslates { get; set; }
    }
}
