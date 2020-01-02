using Junko.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.ViewModels
{
    public class LoginVM
    {
        public Breadcrumb Breadcrumb { get; set; }
        public Login Login { get; set; }
        public string ReturnUrl { get; set; }
    }
}
