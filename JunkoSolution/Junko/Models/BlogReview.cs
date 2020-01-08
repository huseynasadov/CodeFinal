using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.Models
{
    public class BlogReview
    {
        public int Id { get; set; }
        [Required,Column(TypeName ="ntext")]
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public Blog Blog { get; set; }
        [ForeignKey("Blog")]
        public int BlogId { get; set; }
        public UserClient User { get; set; }
        [ForeignKey("User")]
        public int? UserClientId { get; set; }
        public AdminManager Admin { get; set; }
        [ForeignKey("AdminManager")]
        public int? AdminManagerId { get; set; }
    }
}
