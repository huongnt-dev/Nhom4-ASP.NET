using Model.EF;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class ProductDao
    {
        ShopShoeDBContext db = null;
        public ProductDao()
        {
            db = new ShopShoeDBContext();
        }
       
        public IEnumerable<Product> ListAllPaging(int page, int pageSize)
        {
            return db.Products.OrderByDescending(x => x.CreateDate).ToPagedList(page, pageSize);
        }

    }
}
