using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Model.EF;
using PagedList;
namespace Project_Nhom4.Controllers
{
    public class ProductsController : Controller
    {
        private ShopShoeDBContext db = new ShopShoeDBContext();

        // GET: Products
        public ActionResult Index(string sortOrder,string searchstring, string currentFilter, int?page)
        {
            //các biến sắp xếp
            ViewBag.CurrentSort = sortOrder;//biến lấy yêu cầu sắp xếp hiện tại
            ViewBag.saptheogiatang = sortOrder == "gia"?"":"gia";
            ViewBag.saptheogiagiam = sortOrder == "gia_desc" ? "" : "gia_desc";
            ViewBag.saptheogia100k_300k = sortOrder == "gia100_300"?"": "gia100_300";
            //ViewBag.saptheogiagiam = sortOrder == "gia_desc";

            //Lấy giá trị bộ lọc dữ liệu hiện tại
            if (searchstring != null)
            {
                page = 1;//trang đầu tiên
            }
            else
            {
                searchstring = currentFilter;
            }
            ViewBag.CurrentFilter = searchstring;

            //lấy danh sách hàng
            var product = db.Products.Select(p => p);

            //lọc theo tên hàng
            if (!String.IsNullOrEmpty(searchstring))
            {
                product = product.Where(p => p.Name.Contains(searchstring));
            }
            //sắp xếp
            switch (sortOrder)
            {
                case "gia":
                    product = product.OrderBy(s => s.Price);
                    break;
                case "gia_desc":
                    product = product.OrderByDescending(s => s.Price);
                    break;
                case "gia100_300":
                    product = product.Where(s => s.Price >= 100000 && s.Price <= 200000).OrderBy(s=> s.Name);
                    break;
                default:
                    product = product.OrderBy(s => s.ID);
                    break;
            }
            int pageSize = 5;
            int PageNumber = (page ?? 1);//nếu page bằng Null thì trả về 1
            return View(product.ToPagedList(PageNumber,pageSize));
        }

        // GET: Products/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Code,MetaTitle,Description,Image,MoreImages,Price,PromotionPrice,IncludeVAT,Quantity,CategoryID,Detail,Warranty,CreateDate,CreateBy,ModifiedDate,ModifiedBy,MetaKeywords,MetaDescriptions,Stutus,TopHot,ViewCount")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(product);
        }

        // GET: Products/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Code,MetaTitle,Description,Image,MoreImages,Price,PromotionPrice,IncludeVAT,Quantity,CategoryID,Detail,Warranty,CreateDate,CreateBy,ModifiedDate,ModifiedBy,MetaKeywords,MetaDescriptions,Stutus,TopHot,ViewCount")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        }

        // GET: Products/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Product product = db.Products.Find(id);
            db.Products.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
