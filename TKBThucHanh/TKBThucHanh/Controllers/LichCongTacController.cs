using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using MvcPaging;
using TKBThucHanh.Function;
using TKBThucHanh.Models;

namespace TKBThucHanh.Controllers
{
    public class LichCongTacController : Controller
    {
        private TkbThucHanhContext db = new TkbThucHanhContext();

        //
        // GET: /LichCongTac/

//        public ActionResult Index()
//        {
//            var lichcongtacs = db.LichCongTacs.Include(l => l.GiangVien);
//            return View(lichcongtacs.ToList());
//        }

        //
        // GET: /LichCongTac/Details/5

        public ActionResult Details(int id = 0)
        {
            var lichcongtac = db.LichCongTacs.Find(id);
            if (lichcongtac == null)
            {
                return HttpNotFound();
            }
            return View(lichcongtac);
        }

        //
        // GET: /LichCongTac/Create

        public ActionResult Create()
        {
            ViewBag.GiangVienId = new SelectList(db.GiangViens, "GiangVienId", "MaGv");
            return View();
        }

        //
        // POST: /LichCongTac/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LichCongTac lichcongtac)
        {
            if (ModelState.IsValid)
            {
                db.LichCongTacs.Add(lichcongtac);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.GiangVienId = new SelectList(db.GiangViens, "GiangVienId", "MaGv", lichcongtac.GiangVienId);
            return View(lichcongtac);
        }

        //
        // GET: /LichCongTac/Edit/5

        public ActionResult Edit(int id = 0)
        {
            var lichcongtac = db.LichCongTacs.Find(id);
            if (lichcongtac == null)
            {
                return HttpNotFound();
            }
            ViewBag.GiangVienId = new SelectList(db.GiangViens, "GiangVienId", "MaGv", lichcongtac.GiangVienId);
            return View(lichcongtac);
        }

        //
        // POST: /LichCongTac/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(LichCongTac lichcongtac)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lichcongtac).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaGiangVien = new SelectList(db.GiangViens, "MaGV", "TenDayDu", lichcongtac.GiangVienId);
            return View(lichcongtac);
        }

        //
        // GET: /LichCongTac/Delete/5
        public ActionResult Delete(int id = 0)
        {
            var lichcongtac = db.LichCongTacs.Find(id);
            if (lichcongtac == null)
            {
                return HttpNotFound();
            }
            db.LichCongTacs.Remove(lichcongtac);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        private readonly int _defaultPageSize = ContainValue.PageSize;

        public ActionResult Index(string tengiangvien, int? page)
        {
            ViewData["tengiangvien"] = tengiangvien;
            int currentPageIndex = page.HasValue ? page.Value : 1;
            IList<LichCongTac> lichCongTacs = db.LichCongTacs.Cast<LichCongTac>().ToList();

            if (string.IsNullOrWhiteSpace(tengiangvien))
            {
                lichCongTacs = lichCongTacs.ToPagedList(currentPageIndex, _defaultPageSize);
            }
            else
            {
                lichCongTacs =
                    lichCongTacs.Where(
                        p =>
                            StringUtility.LocDau(p.GiangVien.HoVaTen.ToLower())
                                .StartsWith(StringUtility.LocDau(tengiangvien.ToLower())))
                        .ToPagedList(currentPageIndex, _defaultPageSize);
            }


            //var list = 
            if (Request.IsAjaxRequest())
                return PartialView("_AjaxEmployeeList", lichCongTacs);
            return View(lichCongTacs);
        }

        public ActionResult Paging(string tengiangvien, int? page)
        {
            ViewData["tengiangvien"] = tengiangvien;
            int currentPageIndex = page.HasValue ? page.Value : 1;
            IList<LichCongTac> lichCongTacs = db.LichCongTacs.ToList();

            if (string.IsNullOrWhiteSpace(tengiangvien))
            {
                return RedirectToAction("Index");
            }
            else
            {
                lichCongTacs =
                    lichCongTacs.Where(
                        p =>
                            StringUtility.LocDau(p.GiangVien.HoVaTen.ToLower())
                                .StartsWith(StringUtility.LocDau(tengiangvien.ToLower())))
                        .ToPagedList(currentPageIndex, _defaultPageSize);
            }

            return View(lichCongTacs);
        }
    }
}