using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Map01.Models;

namespace Map01.Controllers
{
    public class LandmarksController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Landmarks
        public ActionResult Index()
        {
            return View(db.Landmarks.ToList());
        }

        // GET: Landmarks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Landmarks landmarks = db.Landmarks.Find(id);
            if (landmarks == null)
            {
                return HttpNotFound();
            }
            return View(landmarks);
        }

        // GET: Landmarks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Landmarks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Description,Lat,Long")] Landmarks landmarks)
        {
            if (ModelState.IsValid)
            {
                db.Landmarks.Add(landmarks);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(landmarks);
        }

        // GET: Landmarks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Landmarks landmarks = db.Landmarks.Find(id);
            if (landmarks == null)
            {
                return HttpNotFound();
            }
            return View(landmarks);
        }

        // POST: Landmarks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Description,Lat,Long")] Landmarks landmarks)
        {
            if (ModelState.IsValid)
            {
                db.Entry(landmarks).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(landmarks);
        }

        // GET: Landmarks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Landmarks landmarks = db.Landmarks.Find(id);
            if (landmarks == null)
            {
                return HttpNotFound();
            }
            return View(landmarks);
        }

        // POST: Landmarks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Landmarks landmarks = db.Landmarks.Find(id);
            db.Landmarks.Remove(landmarks);
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
