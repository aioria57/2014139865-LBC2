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
    public class BusesController : Controller
    {
        private EnsambladoraDbContex db = new EnsambladoraDbContex();

        // GET: Buses
        public ActionResult Index()
        {
            var carro = db.Carro.Include(b => b.Parabrisas).Include(b => b.Propietario).Include(b => b.Volante);
            return View(carro.ToList());
        }

        // GET: Buses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bus bus = db.Carro.Find(id);
            if (bus == null)
            {
                return HttpNotFound();
            }
            return View(bus);
        }

        // GET: Buses/Create
        public ActionResult Create()
        {
            ViewBag.ParabrisasId = new SelectList(db.Parabrisas, "ParabrisasId", "NumSerie");
            ViewBag.PropietarioId = new SelectList(db.Propietario, "PropietarioId", "DNI");
            ViewBag.VolanteId = new SelectList(db.Volante, "VolanteId", "NumSerie");
            return View();
        }

        // POST: Buses/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CarroId,EnsambladoraId,TipoCarro,NumSerieMotor,NumSerieChasis,VolanteId,ParabrisasId,PropietarioId,TipoBus")] Bus bus)
        {
            if (ModelState.IsValid)
            {
                db.Carro.Add(bus);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ParabrisasId = new SelectList(db.Parabrisas, "ParabrisasId", "NumSerie", bus.ParabrisasId);
            ViewBag.PropietarioId = new SelectList(db.Propietario, "PropietarioId", "DNI", bus.PropietarioId);
            ViewBag.VolanteId = new SelectList(db.Volante, "VolanteId", "NumSerie", bus.VolanteId);
            return View(bus);
        }

        // GET: Buses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bus bus = db.Carro.Find(id);
            if (bus == null)
            {
                return HttpNotFound();
            }
            ViewBag.ParabrisasId = new SelectList(db.Parabrisas, "ParabrisasId", "NumSerie", bus.ParabrisasId);
            ViewBag.PropietarioId = new SelectList(db.Propietario, "PropietarioId", "DNI", bus.PropietarioId);
            ViewBag.VolanteId = new SelectList(db.Volante, "VolanteId", "NumSerie", bus.VolanteId);
            return View(bus);
        }

        // POST: Buses/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CarroId,EnsambladoraId,TipoCarro,NumSerieMotor,NumSerieChasis,VolanteId,ParabrisasId,PropietarioId,TipoBus")] Bus bus)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bus).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ParabrisasId = new SelectList(db.Parabrisas, "ParabrisasId", "NumSerie", bus.ParabrisasId);
            ViewBag.PropietarioId = new SelectList(db.Propietario, "PropietarioId", "DNI", bus.PropietarioId);
            ViewBag.VolanteId = new SelectList(db.Volante, "VolanteId", "NumSerie", bus.VolanteId);
            return View(bus);
        }

        // GET: Buses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bus bus = db.Carro.Find(id);
            if (bus == null)
            {
                return HttpNotFound();
            }
            return View(bus);
        }

        // POST: Buses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Bus bus = db.Carro.Find(id);
            db.Carro.Remove(bus);
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
