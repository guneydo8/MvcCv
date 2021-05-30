using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models;

namespace MvcCv.Controllers
{
    public class HobilerController : Controller
    {
        // GET: Hobiler
        MvcCvEntities db = new MvcCvEntities();
        public ActionResult Index()
        {
            var liste = db.TblInterests.ToList();
            return View(liste);
        }

        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ekle(TblInterests x)
        {
            db.TblInterests.Add(x);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Sil(int id)
        {
            var rmv = db.TblInterests.Find(id);
            db.TblInterests.Remove(rmv);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Güncelle(int id)
        {
            var bul = db.TblInterests.Find(id);
            return View(bul);
        }
        public ActionResult Güncelle2(TblInterests x)
        {
            var Güncelle = db.TblInterests.Find(x.Id);
            Güncelle.Interest = x.Interest;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}