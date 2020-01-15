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
        [Display(Name ="E-Poçt")]
        public string Email { get; set; }
        [Required, MaxLength(250)]
        [Display(Name = "Parol")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
