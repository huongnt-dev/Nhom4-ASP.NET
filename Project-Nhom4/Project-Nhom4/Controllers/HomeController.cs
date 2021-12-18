using Model.EF;
using Project_Nhom4.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_Nhom4.Controllers
{
    public class HomeController : Controller
    {
        private ShopShoeDBContext db = new ShopShoeDBContext();
        public ActionResult Index()
        {
            
            var listproductnew = db.Products.OrderByDescending(p => p.ID).Take(5).ToList();
            var listbestselling = db.Products.OrderByDescending(p => p.ViewCount).Take(5).ToList();
            var topsp = new TopProduct();

            topsp.ProductNew = listproductnew;
            topsp.Best_sellingProduct = listbestselling;
            return View(topsp);
        }
        
        

    }
}
/*var model = db.Products.Select(p => p);
            ViewBag.spmoi = top == "spmoi";
            ViewBag.spuachuong = top == "spuachuong";
            switch (top)
            {
                case "spmoi":
                    model=model.OrderByDescending(p => p.ID).Take(5);
                    break;
                case "spuachuong":
                    model = model.OrderByDescending(p => p.ViewCount).Take(5);
                    break;
            }*/