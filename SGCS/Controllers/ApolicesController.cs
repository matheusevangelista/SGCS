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
    public class ApolicesController : Controller
    {
        private SGCSContext db = new SGCSContext();

        // GET: /Apolices/
        public ActionResult Index()
        {
            var apolices = db.Apolices.Include(a => a.Cliente).Include(a => a.Filial).Include(a => a.Produto).Include(a => a.Seguradora);
            return View(apolices.ToList());
        }

        // GET: /Apolices/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Apolice apolice = db.Apolices.Find(id);
            if (apolice == null)
            {
                return HttpNotFound();
            }
            return View(apolice);
        }

        // GET: /Apolices/Create
        public ActionResult Create()
        {
            ViewBag.ClienteId = new SelectList(db.Clientes, "Id", "Nome");
            ViewBag.FilialId = new SelectList(db.Filial, "Id", "Nome");
            ViewBag.ProdutoId = new SelectList(db.Produtos, "Id", "Nome");
            ViewBag.SeguradoraId = new SelectList(db.Seguradoras, "Id", "Nome");
            return View();
        }

        // POST: /Apolices/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,SeguradoraId,ProdutoId,ClienteId,Indicacao,FilialId,SituacaoDaApolice")] Apolice apolice)
        {
            if (ModelState.IsValid)
            {
                db.Apolices.Add(apolice);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ClienteId = new SelectList(db.Clientes, "Id", "Nome", apolice.ClienteId);
            ViewBag.FilialId = new SelectList(db.Filial, "Id", "Nome", apolice.FilialId);
            ViewBag.ProdutoId = new SelectList(db.Produtos, "Id", "Nome", apolice.ProdutoId);
            ViewBag.SeguradoraId = new SelectList(db.Seguradoras, "Id", "Nome", apolice.SeguradoraId);
            return View(apolice);
        }

        // GET: /Apolices/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Apolice apolice = db.Apolices.Find(id);
            if (apolice == null)
            {
                return HttpNotFound();
            }
            ViewBag.ClienteId = new SelectList(db.Clientes, "Id", "Nome", apolice.ClienteId);
            ViewBag.FilialId = new SelectList(db.Filial, "Id", "Nome", apolice.FilialId);
            ViewBag.ProdutoId = new SelectList(db.Produtos, "Id", "Nome", apolice.ProdutoId);
            ViewBag.SeguradoraId = new SelectList(db.Seguradoras, "Id", "Nome", apolice.SeguradoraId);
            return View(apolice);
        }

        // POST: /Apolices/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,SeguradoraId,ProdutoId,ClienteId,Indicacao,FilialId,SituacaoDaApolice")] Apolice apolice)
        {
            if (ModelState.IsValid)
            {
                db.Entry(apolice).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ClienteId = new SelectList(db.Clientes, "Id", "Nome", apolice.ClienteId);
            ViewBag.FilialId = new SelectList(db.Filial, "Id", "Nome", apolice.FilialId);
            ViewBag.ProdutoId = new SelectList(db.Produtos, "Id", "Nome", apolice.ProdutoId);
            ViewBag.SeguradoraId = new SelectList(db.Seguradoras, "Id", "Nome", apolice.SeguradoraId);
            return View(apolice);
        }

        // GET: /Apolices/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Apolice apolice = db.Apolices.Find(id);
            if (apolice == null)
            {
                return HttpNotFound();
            }
            return View(apolice);
        }

        // POST: /Apolices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Apolice apolice = db.Apolices.Find(id);
            db.Apolices.Remove(apolice);
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
