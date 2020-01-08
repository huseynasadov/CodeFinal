using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Junko.Models
{
    public class User
    {
        [Required,MaxLength(150)]
        public string Firstname { get; set; }
        [Required, MaxLength(150)]
        public string Lastname { get; set; }
        [Required,EmailAddress]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public User()
        {

        }
        public User(AppAdmin appAdmin)
        {
            Firstname = appAdmin.Firstname;
            Lastname = appAdmin.Lastname;
            Email = appAdmin.Email;
            Password = appAdmin.PasswordHash;
        }
    }
}
