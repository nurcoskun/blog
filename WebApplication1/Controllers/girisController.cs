using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace WebApplication1.Controllers
{
    public class girisController : Controller
    {
        // GET: giris
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult giris(Yazarlar mg)
        {
            site_dbEntities2 db = new site_dbEntities2();
            var login = db.Yazarlar.Where(m => m.mail == mg.mail && m.sifre == mg.sifre).FirstOrDefault();
            if (login != null)
            {
                Session["mail"] = login.mail;
                Session["sifre"] = login.sifre;
                return Redirect("/yazar/Index");
            }
            else
            {
                ViewBag.Uyari = "Kullanıcı Adı veya Şifreyi Kontrol Ediniz / Yeni Kayıt Olduysanız ONAY Verilmesini Beklemelisiniz!";
                return View();
            }

        }
        [HttpGet]
        public ActionResult giris()
        {
            Yazarlar model = new Yazarlar();

            return View(model);

        }
      
    }

 
}