using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using GENCPA_MAIN2.Models.Entity;
namespace GENCPA_MAIN2.Controllers
{
    public class GuvenlikController : Controller
    {
        // GET: Guvenlik
        loginEntities db = new loginEntities();
        public ActionResult GirisYap()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GirisYap(GIRIS t)
        {
            var bilgiler = db.GIRIS.FirstOrDefault(x => x.KULLANICI == t.KULLANICI && x.SIFRE == t.SIFRE);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.KULLANICI,false);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }

            
        }
    }
}