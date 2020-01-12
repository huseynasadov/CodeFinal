using Junko.Models;
using Junko.ModelTranslate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.Areas.Control.ViewModels
{
    public class ProperityViewModel
    {
        public Properity Properity { get; set; }
        public IList<ProperityTranslate> ProperityTranslates { get; set; }
    }
}
