using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.Models
{
    public class Color
    {
        public int Id { get; set; }
        [Required,MaxLength(40)]
        [Display(Name="Ad")]
        public string Name { get; set; }
        [Required, MaxLength(40)]
        [Display(Name = "Kod")]
        public string Code { get; set; }
        public bool Status { get; set; }
        [Display(Name = "Yaranma tarixi")]
        public DateTime CreatedAt { get; set; }
        public ICollection<ProductColor> ProductColors { get; set; }
        public ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
