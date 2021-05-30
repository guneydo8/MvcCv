using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models;
using MvcCv.Sınıf;

namespace MvcCv.Controllers
{
    public class HakkımdaController : Controller
    {
        MvcCvEntities db = new MvcCvEntities();
        // GET: Hakkımda
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            cs.hakkımda = db.TblAbout.ToList();
            
          
            return View(cs.hakkımda);
        }

        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ekle(TblAbout yeni)
        {
            db.TblAbout.Add(yeni);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Sil(int id)
        {
            var rmv = db.TblAbout.Find(id);
            db.TblAbout.Remove(rmv);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Güncelle(int id)
        {
            var bul = db.TblAbout.Find(id);
            return View("Güncelle", bul);
        }
        public ActionResult Güncelle2(TblAbout x)
        {
            var güncelle = db.TblAbout.Find(x.Id);
            güncelle.Name = x.Name;
            güncelle.Surname = x.Surname;
            güncelle.Mail = x.Mail;
            güncelle.About = x.About;
            güncelle.Address = x.Address;
            güncelle.Phone = x.Phone;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}