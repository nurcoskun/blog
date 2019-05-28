using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class yazilarController : Controller
    {
        // GET: yazilar
        public ActionResult Index()
        {
            site_dbEntities2 db = new site_dbEntities2();
            YazilarViewModels viewmodel = new YazilarViewModels();
            viewmodel.YaziListesi = db.Yazilar.Where(x => x.kategori_id == 1).ToList();
            return View(viewmodel);
        }
        public ActionResult enerji()
        {
            site_dbEntities2 db = new site_dbEntities2();
            YazilarViewModels viewmodel = new YazilarViewModels();
            viewmodel.YaziListesi = db.Yazilar.Where(x => x.kategori_id == 2).ToList();
            return View(viewmodel);
        }
        public ActionResult bilim()
        {
            site_dbEntities2 db = new site_dbEntities2();
            YazilarViewModels viewmodel = new YazilarViewModels();
            viewmodel.YaziListesi = db.Yazilar.Where(x => x.kategori_id == 3).ToList();
            return View(viewmodel);
        }
        public ActionResult yazicilar()
        {
            site_dbEntities2 db = new site_dbEntities2();
            YazilarViewModels viewmodel = new YazilarViewModels();
            viewmodel.YaziListesi = db.Yazilar.Where(x => x.kategori_id == 4).ToList();
            return View(viewmodel);
        }
        public ActionResult robotlar()
        {
            site_dbEntities2 db = new site_dbEntities2();
            YazilarViewModels viewmodel = new YazilarViewModels();
            viewmodel.YaziListesi = db.Yazilar.Where(x => x.kategori_id == 5).ToList();
            return View(viewmodel);
        }
        public ActionResult YaziDetail(int id)
        {
            site_dbEntities2 db = new site_dbEntities2();
            Yazilar model = new Yazilar();
            model = db.Yazilar.Where(x => x.yazi_id == id).FirstOrDefault();
            return View(model);
        }
    }
}