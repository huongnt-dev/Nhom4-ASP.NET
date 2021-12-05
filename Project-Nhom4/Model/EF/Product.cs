namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [Key]
        public long ID { get; set; }

        [Required(ErrorMessage ="Tên sản phẩm không được để trống!")]
        [StringLength(250)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Mã không được để trống!")]
        [StringLength(10)]
        public string Code { get; set; }

        [StringLength(250)]
        public string MetaTitle { get; set; }

        [Required(ErrorMessage = "Thông tin sản phẩm không được để trống!")]
        [StringLength(250)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Ảnh sản phẩm không được để trống!")]
        [StringLength(250)]
        public string Image { get; set; }

        [Column(TypeName = "xml")]
        public string MoreImages { get; set; }

        [Required(ErrorMessage = "Giá sản phẩm không được để trống!")]
        public decimal? Price { get; set; }

        public decimal? PromotionPrice { get; set; }

        public bool? IncludeVAT { get; set; }

        [Required(ErrorMessage = "Số lượng sản phẩm không được để trống!")]
        public int? Quantity { get; set; }

        [Required(ErrorMessage = "Mã loại sản phẩm không được để trống!")]
        public long? CategoryID { get; set; }

        [Column(TypeName = "ntext")]
        public string Detail { get; set; }

        public int? Warranty { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string CreateBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        [StringLength(250)]
        public string MetaKeywords { get; set; }

        [StringLength(250)]
        public string MetaDescriptions { get; set; }

        public bool? Stutus { get; set; }

        public DateTime? TopHot { get; set; }

        public int? ViewCount { get; set; }
    }
}
