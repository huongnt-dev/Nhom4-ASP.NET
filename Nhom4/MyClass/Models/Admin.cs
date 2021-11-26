using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass.Models
{
    [Table("Admins")]
    public class Admin
    {
        [Key]
        public string matk { get; set; }
        [Required(ErrorMessage ="Tên tài khoản không được để trống")]
        public string tentk { get; set; }
        [Required(ErrorMessage ="Mật khẩu không được để trống")]
        public string matkhau { get; set; }
        [Required(ErrorMessage ="Số điện thoại không được để trống")]
        public int sdt { get; set; }
        [Required(ErrorMessage ="Email không được để trống!")]
        public string email { get; set; }
    }
}
