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
    public class EmployeesController : Controller
    {
        private EmployeesDBContext db = new EmployeesDBContext();

        //
        // GET: /Employees/

        public ActionResult Index()
        {
            return View(db.EmployeesDbSet.ToList());
        }

        //
        // GET: /Employees/Details/5

        public ActionResult Details(string id = null)
        {
            Employees employees = db.EmployeesDbSet.Find(id);
            if (employees == null)
            {
                return HttpNotFound();
            }
            return View(employees);
        }

        //
        // GET: /Employees/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Employees/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employees employees)
        {
            if (ModelState.IsValid)
            {
                db.EmployeesDbSet.Add(employees);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employees);
        }

        //
        // GET: /Employees/Edit/5

        public ActionResult Edit(string id = null)
        {
            Employees employees = db.EmployeesDbSet.Find(id);
            if (employees == null)
            {
                return HttpNotFound();
            }
            return View(employees);
        }

        //
        // POST: /Employees/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employees employees)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employees).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employees);
        }

        //
        // GET: /Employees/Delete/5

        public ActionResult Delete(string id = null)
        {
            Employees employees = db.EmployeesDbSet.Find(id);
            if (employees == null)
            {
                return HttpNotFound();
            }
            return View(employees);
        }

        //
        // POST: /Employees/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Employees employees = db.EmployeesDbSet.Find(id);
            db.EmployeesDbSet.Remove(employees);
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