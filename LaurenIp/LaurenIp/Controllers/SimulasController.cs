using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LaurenIp.Data;
using LaurenIp.Models;

namespace LaurenIp.Controllers
{
    public class SimulasController : Controller
    {
        private LaurenIpContext db = new LaurenIpContext();

        // GET: Simulas
        public ActionResult Index()
        {
            
            return View(db.Simulas.ToList());
        }

        // GET: Simulas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Simula simula = db.Simulas.Find(id);
            if (simula == null)
            {
                return HttpNotFound();
            }
            return View(simula);
        }

        // GET: Simulas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Simulas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdCodigo,NomeProjeto,DataInico,DataFinal,ValorProjeto,RiscoEnum,Participantes")] Simula simula)
        {
            if (ModelState.IsValid)
            {
                db.Simulas.Add(simula);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(simula);
        }

        // GET: Simulas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Simula simula = db.Simulas.Find(id);
            if (simula == null)
            {
                return HttpNotFound();
            }
            return View(simula);
        }

        // POST: Simulas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdCodigo,NomeProjeto,DataInico,DataFinal,ValorProjeto,RiscoEnum,Participantes")] Simula simula)
        {
            if (ModelState.IsValid)
            {
                db.Entry(simula).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(simula);
        }

        // GET: Simulas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Simula simula = db.Simulas.Find(id);
            if (simula == null)
            {
                return HttpNotFound();
            }
            return View(simula);
        }

        // POST: Simulas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Simula simula = db.Simulas.Find(id);
            db.Simulas.Remove(simula);
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
        public ActionResult Simula()
        {
            return View(db.Simulas.ToList());
        }
    }
}
