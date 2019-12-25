using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.Models
{
    public class WhatDo : BaseAuditClass
    {
        [MaxLength(300)]
        public string Photo { get; set; }
        public bool Status { get; set; }
        [NotMapped]
        public IFormFile PhotoUpload { get; set; }
        public ICollection<WhatDo> WhatDos { get; set; }
    }
}
