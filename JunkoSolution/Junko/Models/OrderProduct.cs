using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Display(Name="Istifadəçi")]
        public int UserClientId { get; set; }
        [ForeignKey("Product")]
        [Display(Name = "Məhsul")]
        public int ProductId { get; set; }
        [Display(Name = "Istifadəçi")]
        public UserClient User { get; set; }
        [Display(Name = "Məhsul")]
        public Product Product { get; set; }
        [Display(Name = "Qiymət")]
        public decimal Price { get; set; }
        [Display(Name = "Say")]
        public int Quantity { get; set; }
        [Display(Name = "Tarix")]
        public DateTime CreatedAt { get; set; }
        [Display(Name = "Vəziyyət")]
        public Complete Complete { get; set; }
        public bool Status { get; set; }
    }
}
