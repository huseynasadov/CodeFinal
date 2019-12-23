using System;
using System.Collections.Generic;
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
        public DateTime ModifiedAt { get; set; }
        public AdminManager AdminManager { get; set; }
    }
}
