using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TKBThucHanh.Models;
using TKBThucHanh.Models;

namespace TKBThucHanh.Controllers
{
    public class LichCongTacController : Controller
    {
        private TkbThucHanhContext db = new TkbThucHanhContext();

        //
        // GET: /LichCongTac/

        public ActionResult Index()
        {
            var lichcongtacs = db.LichCongTacs.Include(l => l.GiangVien);
            return View(lichcongtacs.ToList());
        }

        //
        // GET: /LichCongTac/Details/5

        public ActionResult Details(int id = 0)
        {
            LichCongTac lichcongtac = db.LichCongTacs.Find(id);
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
            ViewBag.MaGiangVien = new SelectList(db.GiangViens, "MaGV", "TenDayDu");
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

            ViewBag.MaGiangVien = new SelectList(db.GiangViens, "MaGV", "TenDayDu", lichcongtac.MaGiangVien);
            return View(lichcongtac);
        }

        //
        // GET: /LichCongTac/Edit/5

        public ActionResult Edit(int id = 0)
        {
            LichCongTac lichcongtac = db.LichCongTacs.Find(id);
            if (lichcongtac == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaGiangVien = new SelectList(db.GiangViens, "MaGV", "TenDayDu", lichcongtac.MaGiangVien);
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
            ViewBag.MaGiangVien = new SelectList(db.GiangViens, "MaGV", "TenDayDu", lichcongtac.MaGiangVien);
            return View(lichcongtac);
        }

        //
        // GET: /LichCongTac/Delete/5
        public ActionResult Delete(int id = 0)
        {
            LichCongTac lichcongtac = db.LichCongTacs.Find(id);
            if (lichcongtac == null)
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