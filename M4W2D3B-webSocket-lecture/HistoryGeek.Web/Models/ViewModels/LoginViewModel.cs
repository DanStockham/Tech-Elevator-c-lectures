using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HistoryGeek.Web.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "*")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "*")]
        public string Password { get; set; }
    }
}