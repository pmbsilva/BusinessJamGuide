using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BusinessJamGuide.Models;

namespace BusinessJamGuide.Controllers
{
    public class ServicosController : Controller
    {
        private JamDb db = new JamDb();

        // GET: Servicos
        public async Task<ActionResult> Index()
        {
            return View(await db.Servicos.ToListAsync());
        }

        // GET: Servicos/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Servicos servicos = await db.Servicos.FindAsync(id);
            if (servicos == null)
            {
                return HttpNotFound();
            }
            return View(servicos);
        }

        // GET: Servicos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Servicos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Nome,Area")] Servicos servicos)
        {
            if (ModelState.IsValid)
            {
                db.Servicos.Add(servicos);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(servicos);
        }

        // GET: Servicos/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Servicos servicos = await db.Servicos.FindAsync(id);
            if (servicos == null)
            {
                return HttpNotFound();
            }
            return View(servicos);
        }

        // POST: Servicos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Nome,Area")] Servicos servicos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(servicos).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(servicos);
        }

        // GET: Servicos/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Servicos servicos = await db.Servicos.FindAsync(id);
            if (servicos == null)
            {
                return HttpNotFound();
            }
            return View(servicos);
        }

        // POST: Servicos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Servicos servicos = await db.Servicos.FindAsync(id);
            db.Servicos.Remove(servicos);
            await db.SaveChangesAsync();
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
