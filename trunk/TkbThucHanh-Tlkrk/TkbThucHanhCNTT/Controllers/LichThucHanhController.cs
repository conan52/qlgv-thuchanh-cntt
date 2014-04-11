using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using TkbThucHanhCNTT.Models;
using TkbThucHanhCNTT.Models.Enums;
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
            ViewData["Phongs"] = DataProvider<PhongThucHanh>.GetAll().Select(p => new { p.TenPhong });

            var dsTuan = DataProvider<TuanHoc>.GetAll();
            ViewData["Tuans"] = dsTuan.Select(t => new { t.SttTuan });
            if (dsTuan.Any(t => t.NgayBatDau > DateTime.Now))
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
            var result = DataProvider<LichThucHanh>.GetAll(l => l.PhanCongThucHanhs)
                .OrderByDescending(t => t.SttTuan)
                .ThenBy(t => t.NgayTrongTuan)
                .ThenBy(t => t.TietBatDau)
                .ThenBy(t => t.TietKetThuc);

            return Json(result.ToDataSourceResult(request, tk => new LichThucHanhViewModel
            {
                GhiChu = "",
                SttTuan = tk.SttTuan,
                MonHocId = tk.MonHocId,
                NgayTrongTuan = tk.NgayTrongTuan,
                TenLop = tk.TenLop,
                MaLichTh = tk.MaLichTh,
                TenPhong = tk.TenPhong,
                Gvhd1 = tk.PhanCongThucHanhs.First().MaGv,
                TietBatDau=tk.TietBatDau,
                TietKetThuc = tk.TietKetThuc,
            }));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult AjaxCreate([DataSourceRequest] DataSourceRequest request, LichThucHanhViewModel l)
        {
            if (l != null && ModelState.IsValid)
            {
                var th = new LichThucHanh
                {
                    MonHocId = l.MonHocId,
                    SttTuan = l.SttTuan,
                    TietBatDau = l.TietBatDau,
                    TietKetThuc = l.TietKetThuc,
                    NgayTrongTuan = l.NgayTrongTuan,
                    TenLop = l.TenLop,
                    TenPhong = l.TenPhong,
                    GhiChu = l.GhiChu
                };
                if (l.Gvhd1 != null)
                    th.PhanCongThucHanhs.Add(new PhanCongThucHanh { MaGv = l.Gvhd1, TrangThai = TrangThaiHuongDanTh.CoMat });
                if (l.Gvhd2 != null)
                    th.PhanCongThucHanhs.Add(new PhanCongThucHanh { MaGv = l.Gvhd2, TrangThai = TrangThaiHuongDanTh.CoMat });
                if (l.Gvhd3 != null)
                    th.PhanCongThucHanhs.Add(new PhanCongThucHanh { MaGv = l.Gvhd3, TrangThai = TrangThaiHuongDanTh.CoMat });

                DataProvider<LichThucHanh>.Add(th);
            }

            return Json(new[] { l }.ToDataSourceResult(request, ModelState));
        }
    }
}
