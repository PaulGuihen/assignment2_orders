using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using orders.Models;

namespace orders.Controllers
{
    public class ShippersController : Controller
    {
        private ShippersDBContext db = new ShippersDBContext();

        //
        // GET: /Shippers/

        public ActionResult Index()
        {
            return View(db.ShippersDbSet.ToList());
        }

        //
        // GET: /Shippers/Details/5

        public ActionResult Details(int id = 0)
        {
            Shippers shippers = db.ShippersDbSet.Find(id);
            if (shippers == null)
            {
                return HttpNotFound();
            }
            return View(shippers);
        }

        //
        // GET: /Shippers/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Shippers/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Shippers shippers)
        {
            if (ModelState.IsValid)
            {
                db.ShippersDbSet.Add(shippers);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(shippers);
        }

        //
        // GET: /Shippers/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Shippers shippers = db.ShippersDbSet.Find(id);
            if (shippers == null)
            {
                return HttpNotFound();
            }
            return View(shippers);
        }

        //
        // POST: /Shippers/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Shippers shippers)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shippers).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(shippers);
        }

        //
        // GET: /Shippers/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Shippers shippers = db.ShippersDbSet.Find(id);
            if (shippers == null)
            {
                return HttpNotFound();
            }
            return View(shippers);
        }

        //
        // POST: /Shippers/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Shippers shippers = db.ShippersDbSet.Find(id);
            db.ShippersDbSet.Remove(shippers);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}