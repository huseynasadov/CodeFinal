using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.Models
{
    public enum Gender
    {
        Male,
        Female
    }
    public class UserClient 
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        [Display(Name ="Ad")]
        public string Firstname { get; set; }
        [Required, MaxLength(50)]
        [Display(Name = "Soyad")]
        public string Lastname { get; set; }
        [Required, EmailAddress]
        [Display(Name = "E-Poçt")]
        public string Email { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Doğum tarixi")]
        public DateTime Birthday { get; set; }
        [Required, MaxLength(250)]
        [DataType(DataType.Password)]
        [Display(Name = "Parol")]
        public string Password { get; set; }
        [Display(Name = "Ünvan")]
        public string Address { get; set; }
        [Display(Name = "Cinsiyyət")]
        public Gender Gender { get; set; }
        [MaxLength(400)]
        public string Token { get; set; }
        [Display(Name = "Qeydiyyat tarixi")]
        public DateTime CreatedAt { get; set; }
        public ICollection<BlogReview> BlogReviews { get; set; }
        public ICollection<OrderProduct> OrderProducts { get; set; }
        public ICollection<ProductReview> ProductReviews { get; set; }
    }
}
