using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project_Nhom4.Common
{
    public class UserRegister
    {
        [Key]
        public long ID { get; set; }
        [Display(Name ="Tên đăng nhập")]
        [Required(ErrorMessage ="Không được để trống")]
        public string UserName { get; set; }
        [Display(Name = "Tên người dùng")]
        [Required(ErrorMessage = "Không được để trống")]
        public string Name { get; set; }
        [Display(Name = "Mật khẩu")]
        [Required(ErrorMessage = "Không được để trống")]
        [StringLength(50,MinimumLength =6,ErrorMessage ="Mật khẩu phải có ít nhất 6 kí tự")]
        public string Password { get; set; }
        [Display(Name = "Nhập lại Mật khẩu")]
        [Required(ErrorMessage = "Không được để trống")]
        [Compare("Password",ErrorMessage ="Mật khẩu không giống nhau")]
        public string ConfirmPassword { get; set; }
        [Display(Name = "Địa chỉ")]
        [Required(ErrorMessage = "Không được để trống")]
        public string Address { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Không được để trống")]
        public string Email { get; set; }
        [Display(Name = "Số điện thoại")]
        [Required(ErrorMessage = "Không được để trống")]
        public string Phone { get; set; }
        
        


    }
}