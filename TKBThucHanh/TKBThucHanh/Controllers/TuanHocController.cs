using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using MvcPaging;
using TKBThucHanh.Function;
using TKBThucHanh.Models;

namespace TKBThucHanh.Controllers
{
    public class TuanHocController : Controller
    {
        TkbThucHanhContext _db = new TkbThucHanhContext();

        private readonly int _defaultPageSize = ContainValue.PageSize;
        
        public ActionResult Index()
        {
            return View(_db.TuanHocs);
        }


        [HttpGet]
        //[OutputCache]
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


        public ActionResult Delete(int id)
        {
            try
            {
                var tuanHoc = _db.TuanHocs.Find(id);
                _db.TuanHocs.Remove(tuanHoc);
                _db.SaveChanges();
                return Json(new { Result = "OK" });
            }
            catch (Exception e)
            {
                return Json(new { Result = "Fail", e.Message });
            }
        }

        public ActionResult Index(int tuanhoc, int? page)
        {
            ViewData["tuanhoc"] = tuanhoc;
            int currentPageIndex = page.HasValue ? page.Value : 1;
            IList<TuanHoc> tuanHocs = _db.TuanHocs.Cast<TuanHoc>().ToList();

            if (tuanhoc==0)
            {
                tuanHocs = tuanHocs.ToPagedList(currentPageIndex, _defaultPageSize);
            }
            else
            {
                tuanHocs =
                    tuanHocs.Where(
                        p =>
                            p.SttTuan==tuanhoc)
                        .ToPagedList(currentPageIndex, _defaultPageSize);
            }


            //var list = 
            if (Request.IsAjaxRequest())
                return PartialView("_AjaxEmployeeList", tuanHocs);
            return View(tuanHocs);
        }

        public ActionResult Paging(int tuanhoc, int? page)
        {
            ViewData["tuanhoc"] = tuanhoc;
            int currentPageIndex = page.HasValue ? page.Value : 1;
            IList<TuanHoc> tuanHocs = _db.TuanHocs.ToList();

            if (tuanhoc==0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                tuanHocs =
                    tuanHocs.Where(
                        p =>
                            p.SttTuan==tuanhoc)
                        .ToPagedList(currentPageIndex, _defaultPageSize);
            }

            return View(tuanHocs);
        }

    }
}
