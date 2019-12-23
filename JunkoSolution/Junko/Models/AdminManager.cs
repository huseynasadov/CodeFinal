using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.Models
{
    public class AdminManager
    {
        public int Id { get; set; }
        public int AdminCategoryId { get; set; }
        [Required,MaxLength(50)]
        public string Firstname { get; set; }
        [Required, MaxLength(50)]
        public string Lastname { get; set; }
        [Required,MaxLength(250),MinLength(8)]
        public string Password { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, MaxLength(20),MinLength(10)]
        public string Phone { get; set; }
        [MaxLength(300)]
        public string Photo { get; set; }
        [NotMapped]
        public IFormFile PhotoUpload { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? DeadLineAt { get; set; }
        [MaxLength(400)]
        public string Token { get; set; }
        public AdminCategory Category { get; set; }
        public ICollection<Blog> Blogs { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}
