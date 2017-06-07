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
using _2014139865_PER.Repositories;

namespace _2014139865_MVC.Controllers
{
    public class AsientoesController : Controller
    {
        //private EnsambladoraDbContex db = new EnsambladoraDbContex();
        private UnityOfWork unityOfWork = UnityOfWork.Instance;
        // GET: Asientoes
        public ActionResult Index()
        {
            //var asiento = db.Asiento.Include(a => a.Cinturon);
            return View(unityOfWork.Asientos.GetAll());
        }

        // GET: Asientoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Asiento asiento = unityOfWork.Asientos.Get(id);
            if (asiento == null)
            {
                return HttpNotFound();
            }
            return View(asiento);
        }

        // GET: Asientoes/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: Asientoes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AsientoId,CarroId,NumSerie,CinturonId")] Asiento asiento)
        {
            if (ModelState.IsValid)
            {
                //db.Asiento.Add(asiento);
                unityOfWork.Asientos.Add(asiento);
                //db.SaveChanges();
                unityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(asiento);
        }

        // GET: Asientoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Asiento asiento = unityOfWork.Asientos.Get(id);
            if (asiento == null)
            {
                return HttpNotFound();
            }
            
            return View(asiento);
        }

        // POST: Asientoes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AsientoId,CarroId,NumSerie,CinturonId")] Asiento asiento)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(asiento).State = EntityState.Modified;
                unityOfWork.StateModified(asiento);
                //db.SaveChanges();
                unityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
    
            return View(asiento);
        }

        // GET: Asientoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Asiento asiento = db.Asiento.Find(id);
            Asiento asiento = unityOfWork.Asientos.Get(id);
            if (asiento == null)
            {
                return HttpNotFound();
            }
            return View(asiento);
        }

        // POST: Asientoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //Asiento asiento = db.Asiento.Find(id);
            Asiento asiento = unityOfWork.Asientos.Get(id);
            //db.Asiento.Remove(asiento);
            unityOfWork.Asientos.Remove(asiento);
            //db.SaveChanges();
            unityOfWork.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                //db.Dispose();
                unityOfWork.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
