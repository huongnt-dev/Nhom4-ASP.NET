namespace ShoesStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("giohang")]
    public partial class giohang
    {
        [Key]
        [StringLength(10)]
        public string magiohang { get; set; }

        [StringLength(10)]
        public string masp { get; set; }

        [StringLength(100)]
        public string tensp { get; set; }

        public int? soluonghang { get; set; }

        [Column(TypeName = "money")]
        public decimal? tongtien { get; set; }
    }
}
