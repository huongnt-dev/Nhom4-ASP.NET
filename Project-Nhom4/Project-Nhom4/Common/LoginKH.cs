using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project_Nhom4.Common
{
    public class LoginKH
    {
        [Key]
        [Required(ErrorMessage ="Không được để trống")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        public string Password { get; set; }
    }
}