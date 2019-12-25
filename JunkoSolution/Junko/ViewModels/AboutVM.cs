using Junko.Models;
using Junko.ModelTranslate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.ViewModels
{
    public class AboutVM
    {
        public Breadcrumb Breadcrumb { get; set; }
        public ICollection<WhatDoTranslate> WhatDoTranslates { get; set; }
        public AboutSettingTranslate AboutSettingTranslate { get; set; }
        public ICollection<OurServiceTranslate> OurServiceTranslates { get; set; }
        public ICollection<AdminManager> AdminManagers { get; set; }
    }
}
