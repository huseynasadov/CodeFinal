using Junko.ModelTranslate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.Models
{
    public class AdminCategory
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public ICollection<AdminCategoryTranslate> AdminCategoryTranslates { get; set; }
        public ICollection<AdminManager> AdminManagers { get; set; }
    }
}
