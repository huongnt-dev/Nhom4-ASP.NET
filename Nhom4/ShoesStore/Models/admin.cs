namespace ShoesStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("admin")]
    public partial class admin
    {
        [Key]
        [StringLength(10)]
        public string matk { get; set; }

        [StringLength(50)]
        public string tentk { get; set; }

        [StringLength(50)]
        public string matkhau { get; set; }

        public int? sdt { get; set; }

        [StringLength(100)]
        public string email { get; set; }
    }
}
