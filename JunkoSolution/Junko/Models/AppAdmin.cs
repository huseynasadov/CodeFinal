using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.Models
{
    public class AppAdmin:IdentityUser
    {
        public string AppAdminId { get; set; }
        public string Ocupation { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}
