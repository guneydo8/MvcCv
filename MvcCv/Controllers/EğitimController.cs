using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models;

namespace MvcCv.Controllers
{
    public class EğitimController : Controller
    {
        // GET: Eğitim
        MvcCvEntities db = new MvcCvEntities();
        public ActionResult Index()
        {
            var liste = db.TblEducation.ToList();

            return View(liste);
        }

        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ekle(TblEducation x)
        {
            db.TblEducation.Add(x);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Sil(int id)
        {
            var rmv = db.TblEducation.Find(id);
            db.TblEducation.Remove(rmv);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Güncelle(int id)
        {
            var bul = db.TblEducation.Find(id);
            return View("Güncelle", bul);
        }

        public ActionResult Güncelle2(TblEducation x)
        {
            var Güncelle = db.TblEducation.Find(x.Id);
            Güncelle.Title = x.Title;
            Güncelle.SubTitle = x.SubTitle;
            Güncelle.Department = x.Department;
            Güncelle.Gpa = x.Gpa;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}