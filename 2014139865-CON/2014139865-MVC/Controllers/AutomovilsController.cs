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
    public class AutomovilsController : Controller
    {
        private EnsambladoraDbContex db = new EnsambladoraDbContex();

        // GET: Automovils
        public ActionResult Index()
        {
            var carro = db.Carro.Include(a => a.Parabrisas).Include(a => a.Propietario).Include(a => a.Volante);
            return View(carro.ToList());
        }

        // GET: Automovils/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Automovil automovil = db.Carro.Find(id);
            if (automovil == null)
            {
                return HttpNotFound();
            }
            return View(automovil);
        }

        // GET: Automovils/Create
        public ActionResult Create()
        {
            ViewBag.ParabrisasId = new SelectList(db.Parabrisas, "ParabrisasId", "NumSerie");
            ViewBag.PropietarioId = new SelectList(db.Propietario, "PropietarioId", "DNI");
            ViewBag.VolanteId = new SelectList(db.Volante, "VolanteId", "NumSerie");
            return View();
        }

        // POST: Automovils/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CarroId,EnsambladoraId,TipoCarro,NumSerieMotor,NumSerieChasis,VolanteId,ParabrisasId,PropietarioId,TipoAuto")] Automovil automovil)
        {
            if (ModelState.IsValid)
            {
                db.Carro.Add(automovil);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ParabrisasId = new SelectList(db.Parabrisas, "ParabrisasId", "NumSerie", automovil.ParabrisasId);
            ViewBag.PropietarioId = new SelectList(db.Propietario, "PropietarioId", "DNI", automovil.PropietarioId);
            ViewBag.VolanteId = new SelectList(db.Volante, "VolanteId", "NumSerie", automovil.VolanteId);
            return View(automovil);
        }

        // GET: Automovils/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Automovil automovil = db.Carro.Find(id);
            if (automovil == null)
            {
                return HttpNotFound();
            }
            ViewBag.ParabrisasId = new SelectList(db.Parabrisas, "ParabrisasId", "NumSerie", automovil.ParabrisasId);
            ViewBag.PropietarioId = new SelectList(db.Propietario, "PropietarioId", "DNI", automovil.PropietarioId);
            ViewBag.VolanteId = new SelectList(db.Volante, "VolanteId", "NumSerie", automovil.VolanteId);
            return View(automovil);
        }

        // POST: Automovils/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CarroId,EnsambladoraId,TipoCarro,NumSerieMotor,NumSerieChasis,VolanteId,ParabrisasId,PropietarioId,TipoAuto")] Automovil automovil)
        {
            if (ModelState.IsValid)
            {
                db.Entry(automovil).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ParabrisasId = new SelectList(db.Parabrisas, "ParabrisasId", "NumSerie", automovil.ParabrisasId);
            ViewBag.PropietarioId = new SelectList(db.Propietario, "PropietarioId", "DNI", automovil.PropietarioId);
            ViewBag.VolanteId = new SelectList(db.Volante, "VolanteId", "NumSerie", automovil.VolanteId);
            return View(automovil);
        }

        // GET: Automovils/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Automovil automovil = db.Carro.Find(id);
            if (automovil == null)
            {
                return HttpNotFound();
            }
            return View(automovil);
        }

        // POST: Automovils/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Automovil automovil = db.Carro.Find(id);
            db.Carro.Remove(automovil);
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
