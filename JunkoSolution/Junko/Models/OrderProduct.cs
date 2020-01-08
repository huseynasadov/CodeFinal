using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.Models
{
    public enum Complete {
    Completed,
    Processsing
    }
    public class OrderProduct
    {
        public int Id { get; set; }
        [ForeignKey("User")]
        public int UserClientId { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public UserClient User { get; set; }
        public Product Product { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedAt { get; set; }
        public Complete Complete { get; set; }
        public bool Status { get; set; }
    }
}
