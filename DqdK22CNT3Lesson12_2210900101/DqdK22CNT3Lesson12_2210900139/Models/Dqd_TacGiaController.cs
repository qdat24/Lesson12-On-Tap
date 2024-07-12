using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace DqdK22CNT3Lesson12_2210900139.Models
{
    public class Dqd_TacGiaController : Controller
    {
        private DINHUQOCDAT_2210900139Entities db = new DINHUQOCDAT_2210900139Entities();

        // GET: Dqd_TacGia
        public ActionResult DqdIndex()
        {
            return View(db.Dqd_TacGia.ToList());
        }

        // GET: Dqd_TacGia/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dqd_TacGia Dqd_TacGia = db.Dqd_TacGia.Find(id);
            if (Dqd_TacGia == null)
            {
                return HttpNotFound();
            }
            return View(Dqd_TacGia);
        }

        // GET: Dqd_TacGia/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dqd_TacGia/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Dqd_MaTG,Dqd_TenTacGia")] Dqd_TacGia Dqd_TacGia)
        {
            if (ModelState.IsValid)
            {
                db.Dqd_TacGia.Add(Dqd_TacGia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(Dqd_TacGia);
        }

        // GET: Dqd_TacGia/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dqd_TacGia Dqd_TacGia = db.Dqd_TacGia.Find(id);
            if (Dqd_TacGia == null)
            {
                return HttpNotFound();
            }
            return View(Dqd_TacGia);
        }

        // POST: Dqd_TacGia/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Dqd_MaTG,Dqd_TenTacGia")] Dqd_TacGia Dqd_TacGia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(Dqd_TacGia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Dqd_TacGia);
        }

        // GET: Dqd_TacGia/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dqd_TacGia Dqd_TacGia = db.Dqd_TacGia.Find(id);
            if (Dqd_TacGia == null)
            {
                return HttpNotFound();
            }
            return View(Dqd_TacGia);
        }

        // POST: Dqd_TacGia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Dqd_TacGia Dqd_TacGia = db.Dqd_TacGia.Find(id);
            db.Dqd_TacGia.Remove(Dqd_TacGia);
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
