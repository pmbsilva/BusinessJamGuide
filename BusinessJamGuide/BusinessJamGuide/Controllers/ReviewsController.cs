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
    public class ReviewsController : Controller
    {
        private JamDb db = new JamDb();

        // GET: Reviews
        public async Task<ActionResult> Index()
        {
            var reviews = db.Reviews.Include(r => r.Empresa).Include(r => r.Utilizador);
            return View(await reviews.ToListAsync());
        }

        // GET: Reviews/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reviews reviews = await db.Reviews.FindAsync(id);
            if (reviews == null)
            {
                return HttpNotFound();
            }
            return View(reviews);
        }

        // GET: Reviews/Create
        public ActionResult Create()
        {
            ViewBag.EmpresaFK = new SelectList(db.Empresas, "Id", "Nome");
            ViewBag.UtlizadorFK = new SelectList(db.Utilizadores, "Id", "Nome");
            return View();
        }

        // POST: Reviews/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Review,DataReview,Rating,UtlizadorFK,EmpresaFK")] Reviews reviews)
        {
            if (ModelState.IsValid)
            {
                db.Reviews.Add(reviews);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.EmpresaFK = new SelectList(db.Empresas, "Id", "Nome", reviews.EmpresaFK);
            ViewBag.UtlizadorFK = new SelectList(db.Utilizadores, "Id", "Nome", reviews.UtlizadorFK);
            return View(reviews);
        }

        // GET: Reviews/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reviews reviews = await db.Reviews.FindAsync(id);
            if (reviews == null)
            {
                return HttpNotFound();
            }
            ViewBag.EmpresaFK = new SelectList(db.Empresas, "Id", "Nome", reviews.EmpresaFK);
            ViewBag.UtlizadorFK = new SelectList(db.Utilizadores, "Id", "Nome", reviews.UtlizadorFK);
            return View(reviews);
        }

        // POST: Reviews/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Review,DataReview,Rating,UtlizadorFK,EmpresaFK")] Reviews reviews)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reviews).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.EmpresaFK = new SelectList(db.Empresas, "Id", "Nome", reviews.EmpresaFK);
            ViewBag.UtlizadorFK = new SelectList(db.Utilizadores, "Id", "Nome", reviews.UtlizadorFK);
            return View(reviews);
        }

        // GET: Reviews/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reviews reviews = await db.Reviews.FindAsync(id);
            if (reviews == null)
            {
                return HttpNotFound();
            }
            return View(reviews);
        }

        // POST: Reviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Reviews reviews = await db.Reviews.FindAsync(id);
            db.Reviews.Remove(reviews);
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
