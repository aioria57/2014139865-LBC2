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
    public class LlantasController : Controller
    {
        private EnsambladoraDbContex db = new EnsambladoraDbContex();

        // GET: Llantas
        public ActionResult Index()
        {
            return View(db.Llanta.ToList());
        }

        // GET: Llantas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Llanta llanta = db.Llanta.Find(id);
            if (llanta == null)
            {
                return HttpNotFound();
            }
            return View(llanta);
        }

        // GET: Llantas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Llantas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LlantaId,CarroId,NumSerie")] Llanta llanta)
        {
            if (ModelState.IsValid)
            {
                db.Llanta.Add(llanta);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(llanta);
        }

        // GET: Llantas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Llanta llanta = db.Llanta.Find(id);
            if (llanta == null)
            {
                return HttpNotFound();
            }
            return View(llanta);
        }

        // POST: Llantas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LlantaId,CarroId,NumSerie")] Llanta llanta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(llanta).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(llanta);
        }

        // GET: Llantas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Llanta llanta = db.Llanta.Find(id);
            if (llanta == null)
            {
                return HttpNotFound();
            }
            return View(llanta);
        }

        // POST: Llantas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Llanta llanta = db.Llanta.Find(id);
            db.Llanta.Remove(llanta);
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
