using System;
using System.Collections.Generic;
using System.Text;

namespace Junko.Data.Entries
{
  public  class BaseAuditClass
    {
        public int Id { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
