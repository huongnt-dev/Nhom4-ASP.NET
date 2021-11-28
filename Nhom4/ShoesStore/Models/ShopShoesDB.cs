using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ShoesStore.Models
{
    public partial class ShopShoesDB : DbContext
    {
        public ShopShoesDB()
            : base("name=ShopShoesDB")
        {
        }

        public virtual DbSet<admin> admins { get; set; }
        public virtual DbSet<giohang> giohangs { get; set; }
        public virtual DbSet<loaisp> loaisps { get; set; }
        public virtual DbSet<sanpham> sanphams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<admin>()
                .Property(e => e.matk)
                .IsFixedLength();

            modelBuilder.Entity<giohang>()
                .Property(e => e.magiohang)
                .IsFixedLength();

            modelBuilder.Entity<giohang>()
                .Property(e => e.masp)
                .IsFixedLength();

            modelBuilder.Entity<giohang>()
                .Property(e => e.tongtien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<loaisp>()
                .Property(e => e.maloaisp)
                .IsFixedLength();

            modelBuilder.Entity<sanpham>()
                .Property(e => e.masp)
                .IsFixedLength();

            modelBuilder.Entity<sanpham>()
                .Property(e => e.loaisp)
                .IsFixedLength();

            modelBuilder.Entity<sanpham>()
                .Property(e => e.giaban)
                .HasPrecision(19, 4);

            modelBuilder.Entity<sanpham>()
                .Property(e => e.gianhap)
                .HasPrecision(19, 4);
        }
    }
}
