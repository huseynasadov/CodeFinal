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
        public int ProperityId { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public Properity Properity { get; set; }
        [Required, MaxLength(400)]
        public string Key { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
