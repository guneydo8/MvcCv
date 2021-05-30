using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models;
using MvcCv.Sınıf; 

namespace MvcCv.Controllers
{
    public class KullanıcıController : Controller
    {
        MvcCvEntities db = new MvcCvEntities();
        // GET: Kullanıcı
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            cs.hakkımda = db.TblAbout.ToList();
            cs.deneyimler = db.TblExperience.ToList();
            cs.eğitim = db.TblEducation.ToList();
            cs.yetenek = db.TblSkills.ToList();
            cs.hobi = db.TblInterests.ToList();
            cs.sertifika = db.TblCertificates.ToList();
            return View(cs);
            
            //var liste = db.TblAbout.ToList();
            //return View(liste);
        }
    }
}