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
        [Display(Name ="Məzmun")]
        public string Content { get; set; }
        [Display(Name = "Yazılma tarixi")]
        public DateTime CreatedAt { get; set; }
        [Display(Name = "Məhsul")]
        public Product Product { get; set; }
        [ForeignKey("Product")]
        [Display(Name = "Məhsul")]
        public int ProductId { get; set; }
        [Display(Name = "İstifadəçi")]
        public UserClient User { get; set; }
        [ForeignKey("User")]
        [Display(Name = "İstifadəçi")]
        public int? UserClientId { get; set; }
        public AdminManager Admin { get; set; }
        [ForeignKey("AdminManager")]
        public int? AdminManagerId { get; set; }
    }
}
