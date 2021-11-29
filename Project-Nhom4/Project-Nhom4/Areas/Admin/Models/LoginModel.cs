using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project_Nhom4.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage ="Moi nhap user name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Moi nhap user password")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}