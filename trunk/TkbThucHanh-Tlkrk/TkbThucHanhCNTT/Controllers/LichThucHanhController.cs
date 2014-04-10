using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using TkbThucHanhCNTT.Models;
using TkbThucHanhCNTT.Models.Provider;
using TkbThucHanhCNTT.Models.Viewer;

namespace TkbThucHanhCNTT.Controllers
{
    public class LichThucHanhController : Controller
    {
        //
        // GET: /LichThucHanh/

        public ActionResult Index()
        {

            ViewData["GiangViens"] = DataProvider<GiangVien>.GetList(gv => gv.CoThePhanCong).Select(gv => new { gv.HoVaTen, gv.MaGv });
            ViewData["MonHocs"] = DataProvider<MonHoc>.GetAll().Select(t => new { t.TenMonHoc, t.MaMonHoc, t.TenThucHanh, t.MonHocId });
            ViewData["Lops"] = DataProvider<Lop>.GetAll().Select(l => new { l.TenLop });

            var dsTuan = DataProvider<TuanHoc>.GetAll();
            ViewData["Tuans"] = dsTuan.Select(t => new { t.SttTuan });
            if (dsTuan.Any())
                ViewData["TuanMoiNhat"] = dsTuan.First(t => t.NgayBatDau > DateTime.Now).SttTuan;
            else
                ViewData["TuanMoiNhat"] = 0;


            return View();
        }

        public ActionResult LayDsTuan([DataSourceRequest] DataSourceRequest request)
        {
            var dsTuan =
                DataProvider<TuanHoc>.GetList(t => t.LichThucHanhs != null && t.LichThucHanhs.Count > 0)
                    .Select(t => t.SttTuan)
                    .OrderByDescending(t => t);
            return Json(dsTuan, JsonRequestBehavior.AllowGet);
        }

        public JsonResult AjaxReadData([DataSourceRequest] DataSourceRequest request)
        {
            var result = DataProvider<LichThucHanh>.GetAll()
                .OrderByDescending(t => t.SttTuan)
                .ThenBy(t => t.NgayTrongTuan)
                .ThenBy(t => t.TietBatDau)
                .ThenBy(t => t.TietKetThuc);

            return Json(result.ToDataSourceResult(request, tk => new LichThucHanhViewModel()
            {
                GhiChu = "",
                SttTuan = tk.SttTuan,

            }));
        }
    }
}
