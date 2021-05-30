using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models;
namespace MvcCv.Controllers
{
    public class SertifikalarController : Controller
    {
        // GET: Setifikalar
        MvcCvEntities db = new MvcCvEntities();
        public ActionResult Index()
        {
            var liste = db.TblCertificates.ToList();
            return View(liste);
        }

        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ekle(TblCertificates x)
        {
            db.TblCertificates.Add(x);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Sil(int id)
        {
            var rmv = db.TblCertificates.Find(id);
            db.TblCertificates.Remove(rmv);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Güncelle(int id)
        {
            var bul = db.TblCertificates.Find(id);
            return View("Güncelle",bul);
        }
        public ActionResult Güncelle2(TblCertificates x)
        {
            var Güncelle = db.TblCertificates.Find(x.Id);
            Güncelle.Certificate = x.Certificate;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}