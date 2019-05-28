using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class yazarController : Controller
    {
        // GET: yazar
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult yazarAdd()
        {
            Yazarlar model = new Yazarlar();

            return View(model);
        }
        [HttpPost]
        public ActionResult yazarAdd(Yazarlar model)
        {
           site_dbEntities2 db = new site_dbEntities2();

            db.Yazarlar.Add(model);
            
            db.SaveChanges();
            return View();
        }
        [HttpGet]
        public ActionResult yaziAdd()
        {
            Yazilar model = new Yazilar();
            model.tarih = DateTime.Now;
           
            return View(model);
        }
        [HttpPost]
        public ActionResult yaziAdd(Yazilar model)
        {
            site_dbEntities2 db = new site_dbEntities2();
            model.tarih = DateTime.Now;
            db.Yazilar.Add(model);

            db.SaveChanges();
            return View();
        }
        [HttpGet]
        public ActionResult kategoriAdd()
        {
            Kategori model = new Kategori();

            return View(model);
        }
        [HttpPost]
        public ActionResult kategoriAdd(Kategori model)
        {
            site_dbEntities2 db = new site_dbEntities2();
   
            db.Kategori.Add(model);

            db.SaveChanges();
            return View();
        }
    }
}