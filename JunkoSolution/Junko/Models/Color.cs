using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.Models
{
    public class Color
    {
        public int Id { get; set; }
        [Required,MaxLength(40)]
        public string Name { get; set; }
        [Required, MaxLength(40)]
        public string Code { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public ICollection<Color> Colors { get; set; }
    }
}
