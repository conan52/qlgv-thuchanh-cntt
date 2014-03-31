using System;
using System.Collections.Generic;
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



        public ActionResult _Model()
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


    }
}
