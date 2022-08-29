using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EMS.MODEL.Models
{
    public class AuthRequestModel
    {
        [Required(ErrorMessage ="Please enter username")]
        [EmailAddress(ErrorMessage ="please enter valid email address")]
        [Display(Name ="Username")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter password")]
        [Display(Name ="Password")]
        public string Password { get; set; }
    }
}
