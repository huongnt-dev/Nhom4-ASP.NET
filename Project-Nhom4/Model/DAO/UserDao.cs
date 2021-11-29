using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class UserDao
    {
        ShopShoeDBContext db = null;
        public UserDao()
        {
            db = new ShopShoeDBContext();
        }
        public long Insert(User entity)
        {
            db.Users.Add(entity);
            db.SaveChanges();
            return entity.ID;
        }
        public User GetById(string userName)
        {
           return db.Users.SingleOrDefault(x=>x.UserName == userName);
        }
        public bool Login(string userName, string password)
        {
            var result = db.Users.Count(x => x.UserName == userName && x.Password == password);
            if(result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
