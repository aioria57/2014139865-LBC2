using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _2014139865_ENT.Entities;
using _2014139865_PER;

namespace _2014139865_MVC.Controllers
{
    public class CinturonsController : Controller
    {
        private EnsambladoraDbContex db = new EnsambladoraDbContex();

        // GET: Cinturons
        public ActionResult Index()
        {
            return View(db.Cinturon.ToList());
        }

        // GET: Cinturons/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cinturon cinturon = db.Cinturon.Find(id);
            if (cinturon == null)
            {
                return HttpNotFound();
            }
            return View(cinturon);
        }

        // GET: Cinturons/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cinturons/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CinturonId,NumSerie,Metraje")] Cinturon cinturon)
        {
            if (ModelState.IsValid)
            {
                db.Cinturon.Add(cinturon);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cinturon);
        }

        // GET: Cinturons/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cinturon cinturon = db.Cinturon.Find(id);
            if (cinturon == null)
            {
                return HttpNotFound();
            }
            return View(cinturon);
        }

        // POST: Cinturons/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CinturonId,NumSerie,Metraje")] Cinturon cinturon)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cinturon).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cinturon);
        }

        // GET: Cinturons/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cinturon cinturon = db.Cinturon.Find(id);
            if (cinturon == null)
            {
                return HttpNotFound();
            }
            return View(cinturon);
        }

        // POST: Cinturons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cinturon cinturon = db.Cinturon.Find(id);
            db.Cinturon.Remove(cinturon);
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
