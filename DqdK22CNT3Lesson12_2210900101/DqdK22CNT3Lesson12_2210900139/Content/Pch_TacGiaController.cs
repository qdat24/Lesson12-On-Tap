using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PchK22CNT3Lesson12_2210900101.Models;

namespace PchK22CNT3Lesson12_2210900101.Content
{
    public class Pch_TacGiaController : Controller
    {
        private PHAMCONGHIEU_2210900101Entities db = new PHAMCONGHIEU_2210900101Entities();

        // GET: Pch_TacGia
        public ActionResult Index()
        {
            return View(db.Pch_TacGia.ToList());
        }

        // GET: Pch_TacGia/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pch_TacGia pch_TacGia = db.Pch_TacGia.Find(id);
            if (pch_TacGia == null)
            {
                return HttpNotFound();
            }
            return View(pch_TacGia);
        }

        // GET: Pch_TacGia/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pch_TacGia/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Pch_MaTG,Pch_TenTacGia")] Pch_TacGia pch_TacGia)
        {
            if (ModelState.IsValid)
            {
                db.Pch_TacGia.Add(pch_TacGia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pch_TacGia);
        }

        // GET: Pch_TacGia/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pch_TacGia pch_TacGia = db.Pch_TacGia.Find(id);
            if (pch_TacGia == null)
            {
                return HttpNotFound();
            }
            return View(pch_TacGia);
        }

        // POST: Pch_TacGia/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Pch_MaTG,Pch_TenTacGia")] Pch_TacGia pch_TacGia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pch_TacGia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pch_TacGia);
        }

        // GET: Pch_TacGia/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pch_TacGia pch_TacGia = db.Pch_TacGia.Find(id);
            if (pch_TacGia == null)
            {
                return HttpNotFound();
            }
            return View(pch_TacGia);
        }

        // POST: Pch_TacGia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Pch_TacGia pch_TacGia = db.Pch_TacGia.Find(id);
            db.Pch_TacGia.Remove(pch_TacGia);
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
