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
    public class PropostasController : Controller
    {
        private SGCSContext db = new SGCSContext();

        // GET: Propostas
        public ActionResult Index()
        {
            return View(db.Propostas.ToList());
        }

        // GET: Propostas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Proposta proposta = db.Propostas.Find(id);
            if (proposta == null)
            {
                return HttpNotFound();
            }
            return View(proposta);
        }

        // GET: Propostas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Propostas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,DataInicioVigencia,DataFimVigencia,NumeroEndosso,DataEmissaoApolice,DataBaixaProposta,NumeroPropostaSeguradora,Entrada,NumeroPrestacoes,ValorPrestacoes,DataPrimeiroVencimento")] Proposta proposta)
        {
            if (ModelState.IsValid)
            {
                db.Propostas.Add(proposta);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(proposta);
        }

        // GET: Propostas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Proposta proposta = db.Propostas.Find(id);
            if (proposta == null)
            {
                return HttpNotFound();
            }
            return View(proposta);
        }

        // POST: Propostas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,DataInicioVigencia,DataFimVigencia,NumeroEndosso,DataEmissaoApolice,DataBaixaProposta,NumeroPropostaSeguradora,Entrada,NumeroPrestacoes,ValorPrestacoes,DataPrimeiroVencimento")] Proposta proposta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(proposta).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(proposta);
        }

        // GET: Propostas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Proposta proposta = db.Propostas.Find(id);
            if (proposta == null)
            {
                return HttpNotFound();
            }
            return View(proposta);
        }

        // POST: Propostas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Proposta proposta = db.Propostas.Find(id);
            db.Propostas.Remove(proposta);
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
