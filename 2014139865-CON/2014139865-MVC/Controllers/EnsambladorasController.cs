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
    public class EnsambladorasController : Controller
    {
        //private EnsambladoraDbContex db = new EnsambladoraDbContex();
        private UnityOfWork unityOfWork = UnityOfWork.Instance;
        // GET: Ensambladoras
        public ActionResult Index()
        {
            //var ensambladora = db.Ensambladora.Include(e => e.Carro);
            return View(unityOfWork.Ensambladoras.GetAll());
        }

        // GET: Ensambladoras/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ensambladora ensambladora = unityOfWork.Ensambladoras.Get(id);
            if (ensambladora == null)
            {
                return HttpNotFound();
            }
            return View(ensambladora);
        }

        // GET: Ensambladoras/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ensambladoras/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EnsambladoraId,TipoCarro")] Ensambladora ensambladora)
        {
            if (ModelState.IsValid)
            {
                //db.Ensambladora.Add(ensambladora);
                unityOfWork.Ensambladoras.Add(ensambladora);
                //db.SaveChanges();
                unityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }

       
            return View(ensambladora);
        }

        // GET: Ensambladoras/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ensambladora ensambladora = unityOfWork.Ensambladoras.Get(id);
            if (ensambladora == null)
            {
                return HttpNotFound();
            }
            return View(ensambladora);
        }

        // POST: Ensambladoras/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EnsambladoraId,TipoCarro")] Ensambladora ensambladora)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(ensambladora).State = EntityState.Modified;
                unityOfWork.StateModified(ensambladora);
                // db.SaveChanges();
                unityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }
            
            return View(ensambladora);
        }

        // GET: Ensambladoras/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ensambladora ensambladora = unityOfWork.Ensambladoras.Get(id);
            if (ensambladora == null)
            {
                return HttpNotFound();
            }
            return View(ensambladora);
        }

        // POST: Ensambladoras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {

            Ensambladora ensambladora = unityOfWork.Ensambladoras.Get(id);
            //db.Ensambladora.Remove(ensambladora);
            unityOfWork.Ensambladoras.Remove(ensambladora);
            //db.SaveChanges();
            unityOfWork.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                unityOfWork.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
