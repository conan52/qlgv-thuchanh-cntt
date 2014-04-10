using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.UI.WebControls.Expressions;
using DluWebHelper;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using TkbThucHanhCNTT.Models;
using TkbThucHanhCNTT.Models.Enums;
using TkbThucHanhCNTT.Models.Provider;
using TkbThucHanhCNTT.Models.Ultils;
using TkbThucHanhCNTT.Models.Viewer;

namespace TkbThucHanhCNTT.Controllers
{
    public class TkbGiangVienController : Controller
    {
        //
        // GET: /ThoiKhoaBieu/

        public ActionResult Index()
        {
            ViewData["GiangViens"] =
                DataProvider<GiangVien>.GetList(gv => gv.CoThePhanCong).Select(gv => new { gv.HoVaTen, gv.MaGv });
            ViewData["Tuans"] = DataProvider<TuanHoc>.GetAll().Select(t => new { t.SttTuan });
            return View();
        }

        public ActionResult LayDsTuan([DataSourceRequest] DataSourceRequest request)
        {
            var dsTuan =
                DataProvider<TuanHoc>.GetList(t => t.TkbGiangViens.Count > 0)
                    .Select(t => t.SttTuan)
                    .OrderByDescending(t => t);
            //  return Json(dsTuan.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
            return Json(dsTuan, JsonRequestBehavior.AllowGet);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult AjaxUpdate([DataSourceRequest] DataSourceRequest request, TkbGiangVien t)
        {
            // Test if gv object and modelstate is valid.
            if (t != null && ModelState.IsValid)
            {
                DataProvider<TkbGiangVien>.Update(t);
            }
            return Json(ModelState.ToDataSourceResult());
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult AjaxDelete([DataSourceRequest] DataSourceRequest request, int maTkb)
        {
            DataProvider<TkbGiangVien>.RemoveById(maTkb);
            return Json(ModelState.ToDataSourceResult());
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult AjaxCreate([DataSourceRequest] DataSourceRequest request, TkbGiangVien t)
        {
            // Test if gv object and modelstate is valid.
            if (t != null && ModelState.IsValid)
            {
                DataProvider<TkbGiangVien>.Add(t);
            }
            return Json(ModelState.ToDataSourceResult());
        }


        public JsonResult AjaxReadData([DataSourceRequest] DataSourceRequest request)
        {
            var result = DataProvider<TkbGiangVien>.GetAll()
                .OrderByDescending(t => t.SttTuan)
                .ThenBy(t => t.NgayTrongTuan)
                .ThenBy(t => t.TietBatDau)
                .ThenBy(t => t.TietKetThuc);

            return Json(result.ToDataSourceResult(request, tk => new TkbGiangVienViewModel
            {
                MaGv = tk.MaGv,
                LopHoc = tk.LopHoc,
                TenMonHoc = tk.TenMonHoc,
                SttTuan = tk.SttTuan,
                NgayTrongTuan = tk.NgayTrongTuan,
                Phong = tk.Phong,
                TietBatDau = tk.TietBatDau,
                TietKetThuc = tk.TietKetThuc,
                MaTkb = tk.MaTkb
            }));
        }

        public JsonResult LayTkbTuDong()
        {
            try
            {
                var dsTkbChuaCo = DataProvider<TuanHoc>.GetList(t => !t.DaLayThongTin && t.NgayKetThuc > DateTime.Now);
                var request = new DluWebRequest();
                var table = request.GetCurentTimeTable();
                var dsTuan = table.Weeks.Intersect(dsTkbChuaCo.Select(t => t.SttTuan)).ToList();
                var dsGv = DataProvider<GiangVien>.GetList(gv => gv.CoThePhanCong).Select(gv => gv.MaGv).ToList();
                var dsLop = DataProvider<Lop>.GetAll().Select(l => l.TenLop).ToList();

                var tm = new TimeTableManager();
                var result = tm.GetTimeFullTable(dsGv, dsLop, dsTuan);

                var tkbgv = result.Select(r => new TkbGiangVien()
                {
                    MaGv = r.TeacherCode,
                    LopHoc = r.ClassCode,
                    NgayTrongTuan = (NgayTrongTuan)(r.DayOfWeek - 1),
                    SttTuan = r.Week,
                    Phong = r.Room,
                    TenMonHoc = r.Subject,
                    TietBatDau = r.Start,
                    TietKetThuc = r.End
                });
                var rowsAffected = DataProvider<TkbGiangVien>.Add(tkbgv);

                foreach (var tuan in dsTkbChuaCo)
                    tuan.DaLayThongTin = true;
                DataProvider<TuanHoc>.Update(dsTkbChuaCo);

                return Json(new { Result = "OK", Message = rowsAffected });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "Fail", ex.Message });
            }
        }
    }
}