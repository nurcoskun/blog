using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class anasayfaController : Controller
    {
        // GET: anasayfa
        public ActionResult Index()
        {
            site_dbEntities2 db = new site_dbEntities2();
            YazilarViewModels viewmodel = new YazilarViewModels();
            viewmodel.YaziListesi = db.Yazilar.Select(x => x).ToList();
            return View(viewmodel);
        }
        public ActionResult Delete(int id)
        {
            site_dbEntities2 db = new site_dbEntities2();
            YazilarViewModels viewmodel = new YazilarViewModels();
            var yazilar = db.Yazilar.Select(x => x).Where(y => y.yazi_id == id).FirstOrDefault();
            db.Yazilar.Remove(yazilar);
            db.SaveChanges();
            return Redirect("/Home/Index");
        }
    }
}
