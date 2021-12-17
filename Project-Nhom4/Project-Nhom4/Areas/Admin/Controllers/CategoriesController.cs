using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Model.EF;
using Model.DAO;
using Project_Nhom4.Library;

namespace Project_Nhom4.Areas.Admin.Controllers
{
    public class CategoriesController : Controller
    {
        private ShopShoeDBContext db = new ShopShoeDBContext();
        CategoryDao categoryDao = new CategoryDao();

        // GET: Admin/Categories
        public ActionResult Index()
        {
            return View(categoryDao.getList("Index"));
        }

        // GET: Admin/Categories/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category category = categoryDao.getRow(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }

        // GET: Admin/Categories/Create
        public ActionResult Create()
        {
            ViewBag.ListCat = new SelectList(categoryDao.getList("Index"), "Id", "Name",0);
            ViewBag.ListOrder = new SelectList(categoryDao.getList("Index"), "DisplayOrder", "Name",0);
            return View();
        }

        // POST: Admin/Categories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                //Xử lý thêm thông tin
                category.MetaTitle = XString.str_MetaTitle(category.Name);
                if(category.ParentID == null)
                {
                    category.ParentID = 0;
                }
                if(category.DisplayOrder == null)
                {
                    category.DisplayOrder = 1;
                }
                else
                {
                    category.DisplayOrder += 1;
                }
                categoryDao.Insert(category);
                return RedirectToAction("Index");
            }
            ViewBag.ListCat = new SelectList(categoryDao.getList("Index"), "Id", "Name", 0);
            ViewBag.ListOrder = new SelectList(categoryDao.getList("Index"), "DisplayOrder", "Name", 0);
            return View(category);
        }

        // GET: Admin/Categories/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category category = categoryDao.getRow(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }

        // POST: Admin/Categories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,MetaTitle,ParentID,DisplayOrder,SeoTitle,CreateDate,CreateBy,ModifiedDate,ModifiedBy,MetaKeywords,MetaDescriptions,Stutus,ShowOnHome")] Category category)
        {
            if (ModelState.IsValid)
            {
                categoryDao.Update(category);
                return RedirectToAction("Index");
            }
            return View(category);
        }

        // GET: Admin/Categories/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category category = categoryDao.getRow(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }

        // POST: Admin/Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Category category = categoryDao.getRow(id);
            categoryDao.Delete(category);
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
