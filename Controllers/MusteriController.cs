using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using OtoYikamaMusteriTakibi.Models;

namespace OtoYikamaMusteriTakibi.Controllers
{
    public class MusteriController : Controller
    {
        private OtoYikamaContext db = new OtoYikamaContext();

        // Müşteri Listesi
        public ActionResult Index()
        {
            var musteriler = db.Musteriler.ToList();
            return View(musteriler);
        }

        // Detay
        public ActionResult Detay(int id)
        {
            var musteri = db.Musteriler.Find(id);
            if (musteri == null) return HttpNotFound();
            return View(musteri);
        }

        // Yeni Müşteri
        public ActionResult Yeni()
        {
            var musteri = new Musteri();
            return View(musteri);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Yeni(Musteri musteri)
        {
            if (ModelState.IsValid)
            {
                db.Musteriler.Add(musteri);
                db.SaveChanges();           
                return RedirectToAction("Index");
            }
            return View(musteri);
        }


        // Düzenle
        public ActionResult Duzenle(int id)
        {
            var musteri = db.Musteriler.Find(id);
            if (musteri == null) return HttpNotFound();
            return View(musteri);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Duzenle(Musteri musteri)
        {
            if (ModelState.IsValid)
            {
                using (var context = new OtoYikamaContext())
                {
                    context.Entry(musteri).State = EntityState.Modified;
                    context.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            return View(musteri);
        }

        // Müşteri Sil
        public ActionResult Sil(int id)
        {
            var musteri = db.Musteriler.Find(id);
            if (musteri == null) return HttpNotFound();
            return View(musteri);
        }

        [HttpPost, ActionName("Sil")]
        [ValidateAntiForgeryToken]
        public ActionResult SilConfirmed(int id)
        {
            var musteri = db.Musteriler.Find(id);
            if (musteri != null)
            {
                db.Musteriler.Remove(musteri);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    }
}
