using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;

namespace MvcCv.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        // GET: Default
        DbCvEntities db = new DbCvEntities();
        public ActionResult Index()
        {
            var degerler = db.Tbl_Hakkimda.ToList();
            return View(degerler);
        }
        public PartialViewResult SosyalMedya()
        {
            var sosyalmedya = db.Tbl_SosyalMedya.Where(x=>x.Durum==true).ToList();
            return PartialView(sosyalmedya);
        }
        public PartialViewResult Deneyim()
        {
            var deneyimler = db.Tbl_Deneyimler.ToList();
            return PartialView(deneyimler);
        }
        public PartialViewResult Egitimler()
        {
            var egitimler = db.Tbl_Egitimler.ToList();
            return PartialView(egitimler);
        }
        public PartialViewResult Yetenekler()
        {
            var yetenekler = db.Tbl_Yetenekler.ToList();
            return PartialView(yetenekler);
        }
        public PartialViewResult Hobilerim()
        {
            var hobilerim = db.Tbl_Hobiler.ToList();
            return PartialView(hobilerim);
        }
        public PartialViewResult Sertifikalar()
        {
            var sertifikalar = db.Tbl_Sertifikalar.ToList();
            return PartialView(sertifikalar);
        }
        [HttpGet]
        public PartialViewResult iletisim()
        {         
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult iletisim(Tbl_iletisim t)
        {
            t.Tarih=DateTime.Parse(DateTime.Now.ToShortDateString());
            db.Tbl_iletisim.Add(t);
            db.SaveChanges();
            return PartialView();
        }
    }
}