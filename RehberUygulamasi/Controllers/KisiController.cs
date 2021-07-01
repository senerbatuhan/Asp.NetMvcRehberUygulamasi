using Microsoft.AspNetCore.Mvc;
using RehberUygulamasi.Models.Context;
using RehberUygulamasi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RehberUygulamasi.Controllers
{
    public class KisiController : Controller
    {
        //veritabanı bağlantısı oluşturduk.
        MvcRehberContext db = new MvcRehberContext();
        public IActionResult Index(string ara)
        {
            var kisiler = from kisi in db.Kisiler orderby kisi.Ad select kisi;
            if(!string.IsNullOrEmpty(ara))
            {
                kisiler = kisiler.Where(k => k.Ad.Contains(ara) || k.Soyad.Contains(ara) || k.Telefon.Contains(ara)).OrderBy(k => k.Ad);
            }
            return View(kisiler.ToList());


            //Veritabanindan kisileri liste olarak cekip index sayfasına gonderdik
            //var kisiler = db.Kisiler.ToList();
            //return View(kisiler);
        }
        [HttpGet]
        public IActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Ekle(Kisi kisi)
        {
            try
            {
                //veritabanina gelen kisi verisini ekledik
                db.Kisiler.Add(kisi);
                //degisiklikleri veritabanina gonderdik
                db.SaveChanges();
                TempData["BasariliMesaj"] = "Ekleme işlemi başarıyla gerçekleşti...";
            }
            catch (Exception)
            {
                TempData["HataliMesaj"] = "Ekleme işlemi BAŞARISIZ!!!";
                throw;
            }




            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Guncelle(int id)
        {
            var kisi = db.Kisiler.Find(id);
            if (kisi == null)
            {
                TempData["HataliMesaj"] = "Güncellenmek istenen kayıt bulunamadı...";
                return RedirectToAction("Index");
            }

            return View(kisi);
        }

        [HttpPost]
        public ActionResult Guncelle(Kisi kisi)
        {
            //Guncellenecek kisiyi getirdik.
            var eskiKisi = db.Kisiler.Find(kisi.Id);
            //varlığını kontrol ettik.
            if (eskiKisi == null)
            {
                TempData["HataliMesaj"] = "Güncellenmek istenen kayıt bulunamadı...";
                return RedirectToAction("Index");
            }
            //varsa eski kisinin adını aldığımız veriyle değiştirip savechanges ile db'ye kaydettik.
            eskiKisi.Ad = kisi.Ad;
            eskiKisi.Soyad = kisi.Soyad;
            eskiKisi.Telefon = kisi.Telefon;
            db.SaveChanges();
            TempData["BasariliMesaj"] = "Güncelleme işlemi başarıyla gerçekleşti...";
            return RedirectToAction("Index");
        }

        public ActionResult Sil(int id) 
        {
            var kisi = db.Kisiler.Find(id);
            if (kisi == null)
            {
                TempData["HataliMesaj"] = "Silinmek istenen kayıt bulunamadı...";
                return RedirectToAction("Index");
            }
            db.Kisiler.Remove(kisi);
            db.SaveChanges();
            TempData["BasariliMesaj"] = "Silme işlemi başarıyla gerçekleşti...";
            return RedirectToAction("Index");
        }
    }
}
