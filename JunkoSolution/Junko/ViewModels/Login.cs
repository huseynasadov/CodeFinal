using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.ViewModels
{
    public class Login
    {
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, MaxLength(250)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
