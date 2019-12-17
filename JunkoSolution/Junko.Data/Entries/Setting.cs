using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Junko.Data.Entries
{
   public class Setting : BaseAuditClass
    {
        public string Logo { get; set; }
        public string  PhotoLogo { get; set; }
        public string Address { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        [NotMapped]
        public  IFormFile PhotoUpload { get; set; }
    }
}
