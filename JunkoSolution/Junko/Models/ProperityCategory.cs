using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.Models
{
    public class ProperityCategory
    {
        public int Id { get; set; }
        [ForeignKey("Properity")]
        public int ProperityId { get; set; }
        [ForeignKey("ProductSubCategory")]
        public int ProductSubCategoryId { get; set; }
        public Properity Properity { get; set; }
        public ProductSubCategory ProductSubCategory { get; set; }
    }
}
