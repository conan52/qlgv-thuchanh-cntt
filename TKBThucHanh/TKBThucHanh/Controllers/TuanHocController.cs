using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using TKBThucHanh.Models;

namespace TKBThucHanh.Controllers
{
    public class TuanHocController : Controller
    {
        TkbThucHanhContext _db = new TkbThucHanhContext();

        public ActionResult Index()
        {
            return View(_db.TuanHocs);
        }


        [HttpGet]
        [OutputCache]
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public JsonResult Create(TuanHoc tuanHoc)
        {
            try
            {
                if (_db.TuanHocs.Any(t => t.SttTuan == tuanHoc.SttTuan))
                    throw new Exception("Tuần này đã tồn tại trong CSDL");
                _db.TuanHocs.Add(tuanHoc);
                _db.SaveChanges();
                return Json(new { Result = "OK" });
            }
            catch (Exception e)
            {
                return Json(new { Result = "Fail", e.Message });
            }

        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var tuanHoc = _db.TuanHocs.Find(id);
            return View(tuanHoc);
        }

        [HttpPost]
        public ActionResult Edit(TuanHoc tuanHoc)
        {
            try
            {
                _db.TuanHocs.AddOrUpdate(tuanHoc);
                _db.SaveChanges();
                return Json(new { Result = "OK" });
            }
            catch (Exception e)
            {
                return Json(new { Result = "Fail", e.Message });
            }
        }
    }
}
