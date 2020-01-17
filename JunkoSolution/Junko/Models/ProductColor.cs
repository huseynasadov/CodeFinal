using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.Models
{
    public class ProductColor
    {
        public int Id { get; set; }
        [ForeignKey("Product")]
        [Display(Name ="Məhsul")]
        public int ProductId { get; set; }
        [ForeignKey("Color")]
        [Display(Name = "Rəng")]
        public int ColorId { get; set; }
        [Display(Name = "Məhsul")]
        public Product Product { get; set; }
        [Display(Name = "Rəng")]
        public Color Color { get; set; }

    }
}
