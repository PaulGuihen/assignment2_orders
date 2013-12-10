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
    public class Order_DetailsController : Controller
    {
        private Order_DetailsDBContext db = new Order_DetailsDBContext();

        //
        // GET: /Order_Details/

        public ActionResult Index()
        {
            return View(db.Order_DetailsDbSet.ToList());
        }

        //
        // GET: /Order_Details/Details/5

        public ActionResult Details(int id = 0)
        {
            Order_Details order_details = db.Order_DetailsDbSet.Find(id);
            if (order_details == null)
            {
                return HttpNotFound();
            }
            return View(order_details);
        }

        //
        // GET: /Order_Details/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Order_Details/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Order_Details order_details)
        {
            if (ModelState.IsValid)
            {
                db.Order_DetailsDbSet.Add(order_details);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(order_details);
        }

        //
        // GET: /Order_Details/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Order_Details order_details = db.Order_DetailsDbSet.Find(id);
            if (order_details == null)
            {
                return HttpNotFound();
            }
            return View(order_details);
        }

        //
        // POST: /Order_Details/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Order_Details order_details)
        {
            if (ModelState.IsValid)
            {
                db.Entry(order_details).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(order_details);
        }

        //
        // GET: /Order_Details/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Order_Details order_details = db.Order_DetailsDbSet.Find(id);
            if (order_details == null)
            {
                return HttpNotFound();
            }
            return View(order_details);
        }

        //
        // POST: /Order_Details/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Order_Details order_details = db.Order_DetailsDbSet.Find(id);
            db.Order_DetailsDbSet.Remove(order_details);
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