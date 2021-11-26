using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public string masp { get; set; }
        [Required(ErrorMessage ="Tên sản phẩm không được để trống")]
        public string tensp { get; set; }
        [Required(ErrorMessage ="Mã loại không được để trống")]
        public int taloaisp { get; set; }
        [Required(ErrorMessage ="xuất xứ không được để trống")]
        public string xuatxu { get; set; }
        public decimal giaban { get; set; }
        public string thongtin { get; set; }    
        [Required(ErrorMessage ="Số lượng không được để trống")]
        public double soluong { get; set; }
    }
}
