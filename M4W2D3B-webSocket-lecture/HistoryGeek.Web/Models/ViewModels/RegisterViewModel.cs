using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HistoryGeek.Web.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "*")]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "*")]
        public string Password { get; set; }

        [Required(ErrorMessage = "*")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}