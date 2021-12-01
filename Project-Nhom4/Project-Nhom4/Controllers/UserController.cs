using Model.DAO;
using Model.EF;
using Project_Nhom4.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_Nhom4.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(UserRegister model )
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                if (dao.checkUserName (model.UserName))
                {
                    ModelState.AddModelError("", "Tên đăng nhập đã tồn tại");
                }
                else if (dao.checkEmail(model.Email))
                {
                    ModelState.AddModelError("", "Email đã tồn tại");
                }
                else
                {
                    var user = new User();
                    user.Name = model.Name;
                    user.Password = Encrytor.MD5Hash(model.Password);
                    user.Phone = model.Phone;
                    user.Email = model.Email;
                    user.Address = model.Address;
                    user.CreateDate = DateTime.Now;
                    user.Status = true;
                    var result = dao.Insert(user);
                    if (result > 0)
                    {
                        ViewBag.Success = "Successfully";
                        model = new UserRegister();
                    }
                    else
                    {
                        ModelState.AddModelError("", "Register fail");
                    }

                }
            }
            return View(model);
        }
      
    }
}