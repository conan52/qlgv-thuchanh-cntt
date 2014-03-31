using System.Data;
using System.Linq;
using System.Web.Mvc;
using TKBThucHanh.Models;

namespace TKBThucHanh.Controllers
{
    public class PhongHocController : Controller
    {
        private TkbThucHanhContext db = new TkbThucHanhContext();

        //
        // GET: /Phong/

        public ActionResult Index()
        {
            return View(db.PhongThucHanhs.ToList());
        }

//        //
//        // GET: /Phong/Details/5
//
//        public ActionResult Details(string id = null)
//        {
//            PhongThucHanh phong = db.PhongThucHanhs.Find(id);
//            if (phong == null)
//            {
//                return HttpNotFound();
//            }
//            return View(phong);
//        }

        //
        // GET: /Phong/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Phong/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PhongThucHanh phong)
        {
            if (ModelState.IsValid)
            {
                db.PhongThucHanhs.Add(phong);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(phong);
        }

        //
        // GET: /Phong/Edit/5

        public ActionResult Edit(int id = 0)
        {
            PhongThucHanh phong = db.PhongThucHanhs.Find(id);
            if (phong == null)
            {
                return HttpNotFound();
            }
            return View(phong);
        }

        //
        // POST: /Phong/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PhongThucHanh phong)
        {
            if (ModelState.IsValid)
            {
                db.Entry(phong).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(phong);
        }

        //
        // GET: /Phong/Delete/5

        public ActionResult Delete(int id = 0)
        {
            PhongThucHanh phong = db.PhongThucHanhs.Find(id);
            if (phong == null)
            {
                return HttpNotFound();
            }
            db.PhongThucHanhs.Remove(phong);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
