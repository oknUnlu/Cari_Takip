using CariTakip.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using NHibernate.Linq;
using CariTakip.Models;
namespace CariTakip.Controllers
{
    public class AuthController : Controller
    {
        // GET: /Auth/
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(AuthLogin form, string returnurl)
        {
          
            if (!ModelState.IsValid)
            {
                return View(form);
            }
            var kullanicilar = Database.Session.Query<Kullanici>().FirstOrDefault(x => x.Adi == form.Adi);
            if (kullanicilar==null)
            {
                //fakehash
            }
            //if (kullanicilar==null || kullanicilar.Sifre!=form.Sifre)
            //{
            //    ModelState.AddModelError("Kullanıcı Adı", "Kullanıcı Adı veya sifre hatalı!");
            //    return View(form);
            //}
            FormsAuthentication.SetAuthCookie(form.Adi, true);
            if (!string.IsNullOrWhiteSpace(returnurl))
            {
                return Redirect(returnurl);
            }
            else
            {
                return RedirectToRoute("Anasayfa");
            }
        
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToRoute("Login");
        }
	}
}