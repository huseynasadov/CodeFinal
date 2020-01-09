using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.Models
{
    public class BaseAuditClass
    {
        public int Id { get; set; }
        [ForeignKey("AdminManager")]
        [Display(Name = "Admin")]
        public int? AdminManagerId { get; set; }
        [Display(Name = "Yeniləmə tarixi")]
        public DateTime ModifiedAt { get; set; }
        [Display(Name = "Admin")]
        public AdminManager AdminManager { get; set; }
    }
}
