using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.Areas.Control.ViewModels
{
    public class AdminViewModel
    {
        [Required,Display(Name ="E-Poçt"),EmailAddress,MaxLength(150)]
        public string Email { get; set; }
    }
}
