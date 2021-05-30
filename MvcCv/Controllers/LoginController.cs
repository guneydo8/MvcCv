using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models;
using System.Web.Security;

namespace MvcCv.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        MvcCvEntities db = new MvcCvEntities();

        
        public ActionResult Giriş()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Giriş(TblAdmin x)
        {
            var giriş = db.TblAdmin.FirstOrDefault(y => y.KullanıcıAd == x.KullanıcıAd && y.Şifre == x.Şifre);
                if (giriş != null)
            {
                FormsAuthentication.SetAuthCookie(giriş.KullanıcıAd, false);
                return RedirectToAction("Index", "Hakkımda");
            }

            else
            {
                return View();
            }

        }
    }
}