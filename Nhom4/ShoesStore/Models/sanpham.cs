namespace ShoesStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sanpham")]
    public partial class sanpham
    {
        [Key]
        [StringLength(10)]
        public string masp { get; set; }

        [StringLength(200)]
        [Required(ErrorMessage ="khong duoc de trong!")]
        [DisplayName("Ten sp")]
        public string tensp { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "khong duoc de trong!")]
        [DisplayName("loai sp")]
        public string loaisp { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "khong duoc de trong!")]
        [DisplayName("Xuat xu")]
        public string xuatxu { get; set; }

        [Required(ErrorMessage = "khong duoc de trong!")]
        [Column(TypeName = "money")]
        [DisplayName("gia ban sp")]
        public decimal? giaban { get; set; }

        [Required(ErrorMessage = "khong duoc de trong!")]
        [DisplayName("gia nhap sp")]
        [Column(TypeName = "money")]
        public decimal? gianhap { get; set; }

        [Required(ErrorMessage = "khong duoc de trong!")]
        [DisplayName("so luong sp")]
        public int? soluong { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "khong duoc de trong!")]
        [DisplayName("hinh anh sp")]
        public string hinhanh { get; set; }
    }
}
