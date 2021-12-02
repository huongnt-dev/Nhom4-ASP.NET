using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagedList;

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

        public IEnumerable<User> ListAllPaging(int page, int pageSize)
        {
            return db.Users.OrderByDescending(x=>x.CreateDate).ToPagedList(page, pageSize);
        }

        public User GetById(string userName)
        {
           return db.Users.SingleOrDefault(x=>x.UserName == userName);
        }
        public int Login(string userName, string password)
        {
            var result = db.Users.SingleOrDefault(x => x.UserName == userName);
            if(result  == null)
            {
                return 0;
            }
            else
            {
                if(result.Status == false)
                {
                    return -1;
                }
                else
                {
                    if (result.Password == password)
                        return 1;
                    else
                        return -2;
                }
            }
        }

        public bool checkUserName(string userName)
        {
            return db.Users.Count(x => x.UserName == userName) > 0;//trả về true( =0 trả về false)
        }
        public bool checkEmail(string email)
        {
            return db.Users.Count(x => x.Email == email) > 0;//trả về true( =0 trả về false)
        }
    }
}
