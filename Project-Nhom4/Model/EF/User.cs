namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [Key]
        public long ID { get; set; }

        [Required(ErrorMessage ="Tên đăng nhập không được bỏ trống!")]
        [StringLength(50)]
        [DisplayName("Tên tài khoản")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Mật khẩu không được bỏ trống!")]
        [StringLength(32)]
        [DisplayName("Mật khẩu")]
        public string Password { get; set; }

        [Required(ErrorMessage ="Tên người dùng không được bỏ trống")]
        [StringLength(50)]
        [DisplayName("Tên người dùng")]
        public string Name { get; set; }

        
        [StringLength(50)]
        [DisplayName("Địa chỉ")]
        public string Address { get; set; }

        [Required(ErrorMessage ="Email không được để trống")]
        [StringLength(50)]
        public string Email { get; set; }

        [Required(ErrorMessage ="Số điện thoại không được để trống!")]
        [StringLength(50)]
        [DisplayName("Số điện thoại")]
        public string Phone { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string CreateBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        [DisplayName("Trạng thái")]
        public bool? Status { get; set; }
    }
}
