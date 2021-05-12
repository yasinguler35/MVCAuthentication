using MVCAuthentication.DAL;
using MVCAuthentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVCAuthentication.Controllers
{
    [AllowAnonymous]
    public class SecurityController : Controller
    {
        AUTContext db = new AUTContext();
        // GET: Security
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            //veritabanından şifre kullanıcı adı kontrol ediliyor
            var userInDb = db.User.FirstOrDefault(u => u.userName == user.userName && u.password == user.password);
            if (userInDb != null)
            {
                FormsAuthentication.SetAuthCookie(user.userName, false);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Mesaj = "Geçersiz Kullanıcı,şifre veya kullanıcı adı hatalı";
                return View();
            }

        }
    }
}