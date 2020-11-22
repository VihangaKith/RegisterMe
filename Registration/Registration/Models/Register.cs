using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Registration.Models
{
    public class Register
    {
        [Required(ErrorMessage = "Name is required")]
        public String Name { get; set; }
        [Key]
        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress)]
        public String Email { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required")]
        public String Password { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Comfirm Password is required")]
        [Compare("Password", ErrorMessage = "Passwords are not matched")]
        public String ComfirmPassword { get; set; }
    }
}