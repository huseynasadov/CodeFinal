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
    public class User 
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string Firstname { get; set; }
        [Required, MaxLength(50)]
        public string Lastname { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
        [Required, MaxLength(250)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string Address { get; set; }
        public Gender Gender { get; set; }
        [MaxLength(400)]
        public string Token { get; set; }
        public DateTime CreatedAt { get; set; }
        public ICollection<BlogReview> BlogReviews { get; set; }
        public ICollection<OrderProduct> OrderProducts { get; set; }
        public ICollection<ProductReview> ProductReviews { get; set; }
    }
}
