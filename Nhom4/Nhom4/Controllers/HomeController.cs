using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyClass.Models;

namespace Nhom4.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Men()
        {
            return View();
        }
        public ActionResult Women()
        {
            return View();
        }
        public ActionResult Kid()
        {
            return View();
        }
        public ActionResult Sport()
        {
            return View();
        }
        public ActionResult Brand()
        {
            return View();
        }
    }
}