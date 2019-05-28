using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class YaziController : Controller
    {
        // GET: Yazi
        public ActionResult Index()
        {
            return View();
        }
        //[HttpGet]
        //public ActionResult Add()
        //{
        //    Yazi model = new Yazi();
        //    return View(model);
        //}

        //[HttpPost]
        //public ActionResult Add(Yazi model)
        //{
        //    DbHaberEntities1 db = new DbHaberEntities1();
        //    model.EklenmeTarihi = DateTime.Now;
        //    model.EkleyenKisiId = 1;
        //    db.Menu.Add(model);
        //    db.SaveChanges();

        //    return View();
        //}
    }
}