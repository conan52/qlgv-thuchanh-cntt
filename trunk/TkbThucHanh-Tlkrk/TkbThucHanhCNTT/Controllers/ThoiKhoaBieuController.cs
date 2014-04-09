using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using TkbThucHanhCNTT.Models;
using TkbThucHanhCNTT.Models.Provider;
using TkbThucHanhCNTT.Models.Ultils;

namespace TkbThucHanhCNTT.Controllers
{
    public class ThoiKhoaBieuController : Controller
    {
        //
        // GET: /ThoiKhoaBieu/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TkbGiangVien()
        {
            return View();
        }

        public ActionResult LayDsTuan([DataSourceRequest] DataSourceRequest request)
        {
            var dsTuan = DataProvider<TuanHoc>.GetList(t=>t.NgayBatDau<=DateTime.Now.AddDays(14).Monday()).Select(t => t.SttTuan).OrderByDescending(t=>t);
          //  return Json(dsTuan.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
            return Json(dsTuan, JsonRequestBehavior.AllowGet);
        }

    }
}
