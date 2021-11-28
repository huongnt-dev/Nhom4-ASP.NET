using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        public string makh { get; set; }  
        [Required(ErrorMessage ="Tên khách hàng không được để trống!")]
        public string tenkh { get; set; }
        [Required(ErrorMessage = "Số điện thoại không được bỏ trống!")]
        public int sdt { get; set; }
        [Required(ErrorMessage = "Email không được bỏ trống!")]
        public string email { get; set; }
        [Required(ErrorMessage ="Mật khẩu không được bỏ trống!")]
        public string matkhau { get; set; }
    }
}
