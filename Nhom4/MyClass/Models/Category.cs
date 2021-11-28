using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass.Models
{
    [Table("Categorys")]
    public class Category
    {
        [Key]
        public string maloaisp{ get; set; }
        [Required(ErrorMessage ="Tên loại sản phẩm không để trống")]
        public string Name { get; set; }

        public string Slug { get; set; }
        public int? ParentId { get; set; }//int? => có thể là null
        public int? Orders { get; set; }

        [Required(ErrorMessage ="Từ khóa SEO không để trống")]
        public string MetaDesc { get; set; }

        [Required]
        public string MetaKey { get; set; } 
        public int? CreatedBy { get; set; }   
        public DateTime? CreatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int Status { get; set; }

    }
}
