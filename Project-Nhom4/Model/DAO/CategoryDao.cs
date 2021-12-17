using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;

namespace Model.DAO
{
    public class CategoryDao
    {
        ShopShoeDBContext db = null;
        public CategoryDao()
        {
            db = new ShopShoeDBContext();
        }

        public List<Category> ListAll()
        {
            return db.Categories.Where(x => x.Stutus == true).ToList();

        }
        // tra ve danh sach
        public List<Category> getList(string status = "All")
        {
            List<Category> list = null;
            switch (status)
            {
                case "Index": {
                        list = db.Categories.Where(m => m.Stutus != false).ToList();
                        break;
                    }
                case "Trash":
                    {
                        list = db.Categories.Where(m=>m.Stutus == false).ToList();
                        break;
                    }
                default:
                    {
                        list = db.Categories.ToList();
                        break;
                    }
            }
            return list;
        }
        // tra ve mo mau tin
        public Category getRow(long? id)
        {
            if(id == null)
            {
                return null;
            }
            else
            {
                return db.Categories.Find(id);
            }
        }

        // Thêm mẩu tin
        public int Insert(Category row)
        {
            db.Categories.Add(row);
            return db.SaveChanges();
        }

        // Cập nhật dữ liệu
        public int Update(Category row)
        {
            db.Entry(row).State = EntityState.Modified;
            
            return db.SaveChanges(); ;
        }
        public int Delete(Category row)
        {
            db.Categories.Remove(row);
            return db.SaveChanges(); ;
        }
    }
}
