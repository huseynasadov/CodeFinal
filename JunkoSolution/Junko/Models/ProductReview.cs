using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.Models
{
    public class ProductReview
    {
        public int Id { get; set; }
        [Required, Column(TypeName = "ntext")]
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public Product Product { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public UserClient User { get; set; }
        [ForeignKey("User")]
        public int? UserClientId { get; set; }
        public AdminManager Admin { get; set; }
        [ForeignKey("AdminManager")]
        public int? AdminManagerId { get; set; }
    }
}
