using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Business.Models;
using Services.DAL;

namespace SGCS.Controllers
{
    public class SeguradorasController : Controller
    {
        private SGCSContext db = new SGCSContext();

        // GET: /Seguradoras/
        public ActionResult Index()
        {
            return View(db.Seguradoras.ToList());
        }

        // GET: /Seguradoras/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Seguradora seguradora = db.Seguradoras.Find(id);
            if (seguradora == null)
            {
                return HttpNotFound();
            }
            return View(seguradora);
        }

        // GET: /Seguradoras/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Seguradoras/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,Nome,Descricao")] Seguradora seguradora)
        {
            if (ModelState.IsValid)
            {
                db.Seguradoras.Add(seguradora);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(seguradora);
        }

        // GET: /Seguradoras/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Seguradora seguradora = db.Seguradoras.Find(id);
            if (seguradora == null)
            {
                return HttpNotFound();
            }
            return View(seguradora);
        }

        // POST: /Seguradoras/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,Nome,Descricao")] Seguradora seguradora)
        {
            if (ModelState.IsValid)
            {
                db.Entry(seguradora).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(seguradora);
        }

        // GET: /Seguradoras/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Seguradora seguradora = db.Seguradoras.Find(id);
            if (seguradora == null)
            {
                return HttpNotFound();
            }
            return View(seguradora);
        }

        // POST: /Seguradoras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Seguradora seguradora = db.Seguradoras.Find(id);
            db.Seguradoras.Remove(seguradora);
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
