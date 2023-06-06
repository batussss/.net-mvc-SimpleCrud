using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using OgrenciDenemeCodeFirst.Models.Sınıflar;

namespace OgrenciDenemeCodeFirst.Controllers
{
    public class MainController : Controller
    {
        context c = new context();
        // GET: Main
        public ActionResult Index()
        {
            var ogrenciler = c.Ogrencilers.ToList();


            return View(ogrenciler);
        }


        public ActionResult sil(int id)
        {
            var ogrenciler = c.Ogrencilers.Find(id);
            c.Ogrencilers.Remove(ogrenciler);
            c.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult ekle(Ogrenciler o)
        {
            var not1 = Convert.ToInt32(o.OgrenciNot1);
            var not2 = Convert.ToInt32(o.OgrenciNot2);

            var sonuc = not1 + not2;
            o.OgrenciOrtalama = Convert.ToString(sonuc / 2);
            c.Ogrencilers.Add(o);
            c.SaveChanges();
            return View();
        }

        [HttpGet]
        public ActionResult ekle()
        {

            return View();
        }

        [HttpGet]
        public ActionResult Degistir(int id)
        {
            var deger = c.Ogrencilers.Find(id);


            return View("Degistir",deger);
        }

        [HttpPost]
        public ActionResult Degistir(Ogrenciler y)
        {

            var x = c.Ogrencilers.Find(y.ID);
            x.OgrenciAd = y.OgrenciAd;
            x.OgrenciSoyad = y.OgrenciSoyad;
            x.OgrenciNot1 = y.OgrenciNot1;
            x.OgrenciNot2 = y.OgrenciNot2;

            var not1 = Convert.ToInt32(y.OgrenciNot1);

            var not2 = Convert.ToInt32(y.OgrenciNot2);
            var sonuc= not1 + not2;
            x.OgrenciOrtalama =Convert.ToString(sonuc/2);
            c.SaveChanges();

            return RedirectToAction("Index");
        }


    }
}