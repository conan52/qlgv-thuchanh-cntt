using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using DluWebHelper;
using TKBThucHanh.Models;

namespace TKBThucHanh.Controllers
{
    public class ThoiKhoaBieuController : Controller
    {
        TkbThucHanhContext _db = new TkbThucHanhContext();

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult KiemTraTkbMoi()
        {
            var dluWeb = new DluWebRequest();
            var timeTable = dluWeb.GetCurentTimeTable();

            int tkbMoi = 0;

            if (_db.TuanHocs.Count(tuan => tuan.DaLayThongTin != null && tuan.DaLayThongTin.Value) != 0)
            {
                tkbMoi = _db.TuanHocs.Max(tuan => tuan.SttTuan);
            }
            var coTkbMoi = timeTable.CurrentWeek > tkbMoi;
            return Json(new { CoTkbMoiNhat = coTkbMoi }, JsonRequestBehavior.AllowGet);
        }

    }
}
