using Junko.Models;
using Junko.ModelTranslate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.ViewModels
{
    public class ServiceVM
    {
        public Breadcrumb Breadcrumb { get; set; }
        public ICollection<OurServiceTranslate> OurServiceTranslates { get; set; }
        public ICollection<ServicesCoverTranslate> ServicesCoverTranslates { get; set; }
    }
}
