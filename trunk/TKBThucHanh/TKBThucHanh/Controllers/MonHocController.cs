using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using TKBThucHanh.Models;

namespace TKBThucHanh.Controllers
{
    public class MonHocController : Controller
    {
        private TkbThucHanhContext db = new TkbThucHanhContext();

        //
        // GET: /MonHoc/

        public ActionResult Index()
        {
            return View(db.MonHocs.ToList());
        }

        //
        // GET: /MonHoc/Details/5

        public ActionResult Details(string id = null)
        {
            var monhoc = db.MonHocs.Find(id);
            if (monhoc == null)
            {
                return HttpNotFound();
            }
            return View(monhoc);
        }

        //
        // GET: /MonHoc/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /MonHoc/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MonHoc monhoc)
        {
            if (ModelState.IsValid)
            {
                db.MonHocs.Add(monhoc);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(monhoc);
        }

        //
        // GET: /MonHoc/Edit/5

        public ActionResult Edit(string id = null)
        {
            var monhoc = db.MonHocs.FirstOrDefault(x => x.TenMonHoc == id);
            if (monhoc == null)
            {
                return HttpNotFound();
            }
            return View(monhoc);
        }

        //
        // POST: /MonHoc/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(MonHoc monhoc)
        {
            if (ModelState.IsValid)
            {
                db.Entry(monhoc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(monhoc);
        }

        //
        // GET: /MonHoc/Delete/5

        public ActionResult Delete(string id = null)
        {
            //chua hoan thien phan xoa tât cả các modun
            var monhoc = db.MonHocs.FirstOrDefault(x => x.TenMonHoc == id);
            if (monhoc == null)
            {
                return HttpNotFound();
            }
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}