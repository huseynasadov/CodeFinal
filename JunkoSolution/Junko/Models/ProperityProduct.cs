using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.Models
{
    public class ProperityProduct
    {
        public int Id { get; set; }
        [ForeignKey("Properity")]
        [Display(Name ="Xüsusiyyət")]
        public int ProperityId { get; set; }
        [ForeignKey("Product")]
        [Display(Name = "Məhsul")]
        public int ProductId { get; set; }
        [Display(Name = "Məhsul")]
        public Product Product { get; set; }
        [Display(Name = "Xüsusiyyət")]
        public Properity Properity { get; set; }
        [Required, MaxLength(400)]
        [Display(Name = "Göstərici")]
        public string Key { get; set; }
        [Display(Name = "Yaranma tarixi")]
        public DateTime CreatedAt { get; set; }
    }
}
