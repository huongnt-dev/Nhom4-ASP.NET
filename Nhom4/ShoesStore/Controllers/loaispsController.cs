using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ShoesStore.Models;

namespace ShoesStore.Controllers
{
    public class loaispsController : Controller
    {
        private ShopShoesDB db = new ShopShoesDB();

        // GET: loaisps
        public ActionResult Index()
        {
            return View(db.loaisps.ToList());
        }

        // GET: loaisps/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            loaisp loaisp = db.loaisps.Find(id);
            if (loaisp == null)
            {
                return HttpNotFound();
            }
            return View(loaisp);
        }

        // GET: loaisps/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: loaisps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "maloaisp,tenloaisp")] loaisp loaisp)
        {
            if (ModelState.IsValid)
            {
                db.loaisps.Add(loaisp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(loaisp);
        }

        // GET: loaisps/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            loaisp loaisp = db.loaisps.Find(id);
            if (loaisp == null)
            {
                return HttpNotFound();
            }
            return View(loaisp);
        }

        // POST: loaisps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "maloaisp,tenloaisp")] loaisp loaisp)
        {
            if (ModelState.IsValid)
            {
                db.Entry(loaisp).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(loaisp);
        }

        // GET: loaisps/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            loaisp loaisp = db.loaisps.Find(id);
            if (loaisp == null)
            {
                return HttpNotFound();
            }
            return View(loaisp);
        }

        // POST: loaisps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            loaisp loaisp = db.loaisps.Find(id);
            db.loaisps.Remove(loaisp);
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
