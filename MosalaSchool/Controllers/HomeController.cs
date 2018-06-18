using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MosalaSchool.DAL;
using MosalaSchool.Models;
using System.Net;
using System.Data.Entity;
using System.Web.Routing;

namespace MosalaSchool.Controllers
{
    public class HomeController : Controller
    {
        private DBContext db = new DBContext();

        public ActionResult Index()
        {
          
            return View(db.Student.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Details(int? id)
        {
            if (id != null)
            {
                Student student = db.Student.Find(id);
                if (student != null)
                {
                    return View(student);
                }
                else
                {
                    return HttpNotFound();
                }
            }
            else {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
           
        }

       
        public ActionResult Edit(int? id)
        {
            if(id !=null)
            {
                Student student = db.Student.Find(id);
                if (student != null)
                {
                    return View(student);
                }
                else
                {
                    return HttpNotFound();
                }
            }
            else
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include =" ID,FirstName,LastName,EnrollmentDate") ]Student student)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(student).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Unable to save your changes, try again later..");
              
            }
            return View(student);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

    }
}