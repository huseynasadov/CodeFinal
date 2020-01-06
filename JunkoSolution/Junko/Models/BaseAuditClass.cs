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
        public int? AdminManagerId { get; set; }
        [Display(Name = "Modified At")]
        public DateTime ModifiedAt { get; set; }
        [Display(Name = "Admin")]
        public AdminManager AdminManager { get; set; }
    }
}
