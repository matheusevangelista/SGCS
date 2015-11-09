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
    public class FilialController : Controller
    {
        private SGCSContext db = new SGCSContext();

        // GET: Filial
        public ActionResult Index()
        {
            return View(db.Filial.ToList());
        }

        // GET: Filial/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Filial filial = db.Filial.Find(id);
            if (filial == null)
            {
                return HttpNotFound();
            }
            return View(filial);
        }

        // GET: Filial/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Filial/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,Rua,Numero,Bairro,Cidade,Cep,Estado,Telefone")] Filial filial)
        {
            if (ModelState.IsValid)
            {
                db.Filial.Add(filial);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(filial);
        }

        // GET: Filial/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Filial filial = db.Filial.Find(id);
            if (filial == null)
            {
                return HttpNotFound();
            }
            return View(filial);
        }

        // POST: Filial/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Rua,Numero,Bairro,Cidade,Cep,Estado,Telefone")] Filial filial)
        {
            if (ModelState.IsValid)
            {
                db.Entry(filial).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(filial);
        }

        // GET: Filial/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Filial filial = db.Filial.Find(id);
            if (filial == null)
            {
                return HttpNotFound();
            }
            return View(filial);
        }

        // POST: Filial/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Filial filial = db.Filial.Find(id);
            db.Filial.Remove(filial);
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
