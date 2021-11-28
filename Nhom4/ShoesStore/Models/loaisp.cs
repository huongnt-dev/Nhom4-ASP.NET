namespace ShoesStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("loaisp")]
    public partial class loaisp
    {
        [Key]
        [StringLength(100)]
        [DisplayName("Mã loại sản phẩm")]
        public string maloaisp { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage ="Không được để trống")]
        [DisplayName("Tên loại sản phẩm")]
        public string tenloaisp { get; set; }
    }
}
