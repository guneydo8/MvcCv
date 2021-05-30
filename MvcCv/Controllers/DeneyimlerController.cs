using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models;

namespace MvcCv.Controllers
{
    public class DeneyimlerController : Controller
    {
        // GET: Deneyimler
        MvcCvEntities db = new MvcCvEntities();
        public ActionResult Index()
        {
            var liste = db.TblExperience.ToList();

            return View(liste);
        }

        [HttpGet]
        public ActionResult Ekle()
        {
            return View();

        }

        [HttpPost]
        public ActionResult Ekle(TblExperience x)
        {
            db.TblExperience.Add(x);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult Sil(int id)
        {
            var rmv = db.TblExperience.Find(id);
            db.TblExperience.Remove(rmv);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult Güncelle(int id)
        {
            var bul = db.TblExperience.Find(id);
            return View("Güncelle",bul);
        }

        public ActionResult Güncelle2(TblExperience x)
        {
            var Güncelle = db.TblExperience.Find(x.Id);
            Güncelle.Title = x.Title;
            Güncelle.SubTitle = x.SubTitle;
            Güncelle.Date = x.Date;
            Güncelle.Details = x.Details;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}