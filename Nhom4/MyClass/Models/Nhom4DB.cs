using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MyClass.Models
{
    public  class Nhom4DB: DbContext
    {
        public Nhom4DB(): base("name= StrConnect") { }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Config> Configs { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
