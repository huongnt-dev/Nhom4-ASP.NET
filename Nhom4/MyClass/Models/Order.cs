using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        public string madh { get; set; }
        [Required]
        public int magh { get; set; }
        [Required]
        public string masp { get; set; }
        [Required]
        public string tensp { get; set; }
        [Required]
        public double slhang { get; set; }
        [Required]
        public decimal tongtien { get; set; }
        [Required]
        public string makh { get; set; }
        [Required]
        public string tenkh { get; set; }
        [Required]
        public int sdt { get; set; }
        [Required]
        public string email { get; set; }
        public string diachi { get; set; }

    }
}
