using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using DluWebHelper;
using Kendo.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using TkbThucHanhCNTT.Models;
using TkbThucHanhCNTT.Models.Enums;
using TkbThucHanhCNTT.Models.Provider;
using TkbThucHanhCNTT.Models.Viewer;

namespace TkbThucHanhCNTT.Controllers
{
    [Authorize(Roles = "AdminTeacher,Admin")]
    public class TkbGiangVienController : Controller
    {
        //
        // GET: /ThoiKhoaBieu/

        public ActionResult Index()
        {
            ViewData["GiangViens"] =
                DataProvider<GiangVien>.GetList(gv => gv.CoThePhanCong).Select(gv => new {gv.HoVaTen, gv.MaGv});
            ViewData["Tuans"] = DataProvider<TuanHoc>.GetAll().Select(t => new {t.SttTuan});
            ViewData["TuanGanNhat"] = LayTuanGanNhat();
            return View();
        }

        private int LayTuanGanNhat()
        {
            IOrderedEnumerable<TuanHoc> dsTuan =
                DataProvider<TuanHoc>.GetList(t => t.TkbGiangViens.Any())
                    .OrderBy(t => Math.Abs((DateTime.Now - t.NgayBatDau).TotalHours));

            if (dsTuan.Any())
                return dsTuan.First().SttTuan;
            return 0;
        }

        public ActionResult LayDsTuan([DataSourceRequest] DataSourceRequest request)
        {
            IOrderedEnumerable<int> dsTuan =
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
            if (!request.Filters.Any())
            {
                request.Filters.Add(new FilterDescriptor("SttTuan", FilterOperator.IsEqualTo, LayTuanGanNhat()));
            }


            IOrderedEnumerable<TkbGiangVien> result = DataProvider<TkbGiangVien>.GetAll()
                .OrderByDescending(t => t.SttTuan)
                .ThenBy(t => t.NgayTrongTuan)
                .ThenBy(t => t.TietBatDau)
                .ThenBy(t => t.TietKetThuc)
                .ThenBy(t => t.MaGv);

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
                IList<TuanHoc> dsTkbChuaCo =
                    DataProvider<TuanHoc>.GetList(t => !t.DaLayThongTin && t.NgayKetThuc > DateTime.Now);

                // var dsTkbChuaCo = DataProvider<TuanHoc>.GetList(t => t.SttTuan==37);
                var request = new DluWebRequest();
                TimeTableWebResult table = request.GetCurentTimeTable();
                List<int> dsTuan = table.Weeks.Intersect(dsTkbChuaCo.Select(t => t.SttTuan)).ToList();
                List<string> dsGv =
                    DataProvider<GiangVien>.GetList(gv => gv.CoThePhanCong).Select(gv => gv.MaGv).ToList();
                List<string> dsLop = DataProvider<Lop>.GetAll().Select(l => l.TenLop).ToList();

                var tm = new TimeTableManager();
                List<Lesson> result = tm.GetTimeFullTable(dsGv, dsLop, dsTuan);

                IEnumerable<TkbGiangVien> tkbgv = result.Select(r => new TkbGiangVien
                {
                    MaGv = r.TeacherCode,
                    LopHoc = r.ClassCode,
                    NgayTrongTuan = (NgayTrongTuan) (r.DayOfWeek - 1),
                    SttTuan = r.Week,
                    Phong = r.Room,
                    TenMonHoc = r.Subject,
                    TietBatDau = r.Start,
                    TietKetThuc = r.End
                });
                int rowsAffected = DataProvider<TkbGiangVien>.Add(tkbgv);

                IEnumerable<TuanHoc> dsTuanDaLay = dsTkbChuaCo.Where(t => tkbgv.Any(tgv => tgv.SttTuan == t.SttTuan));

                foreach (TuanHoc tuan in dsTuanDaLay)
                    tuan.DaLayThongTin = true;
                DataProvider<TuanHoc>.Update(dsTkbChuaCo);

                return Json(new {Result = "OK", Message = rowsAffected});
            }
            catch (Exception ex)
            {
                return Json(new {Result = "Fail", ex.Message});
            }
        }
    }
}