using System;
using System.Collections.Generic;
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
    }
}
