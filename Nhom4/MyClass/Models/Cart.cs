using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass.Models
{
    [Table("Carts")]
    public class Cart
    {
        [Key]
        public string magh { get; set; }
        [Required]
        public string tensp { get; set; }
        [Required]
        public double slhang { get; set; }
        [Required]
        public decimal tongtien { get; set; }
    }
}
