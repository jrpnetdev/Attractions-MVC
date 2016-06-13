using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Attractions.ViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please Enter Your UserName")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Please Enter Your Password")]
        public string Password { get; set; }
    }
}