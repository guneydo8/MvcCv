using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models;

namespace MvcCv.Controllers
{
    public class YeteneklerController : Controller
    {
        // GET: Yetenekler
        MvcCvEntities db = new MvcCvEntities();
        public ActionResult Index()
        {
            var liste = db.TblSkills.ToList();

            return View(liste);
        }

        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ekle(TblSkills x)
        {
            db.TblSkills.Add(x);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Sil(int id)
        {
            var rmv = db.TblSkills.Find(id);
            db.TblSkills.Remove(rmv);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Güncelle(int id)
        {
            var bul = db.TblSkills.Find(id);

            return View(bul);
        }

        public ActionResult Güncelle2(TblSkills x)
        {
            var Güncelle = db.TblSkills.Find(x.Id);
           
            Güncelle.Skills = x.Skills;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
