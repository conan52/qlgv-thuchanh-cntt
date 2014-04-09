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
using TkbThucHanhCNTT.Models.Viewer;

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
            ViewData["GiangViens"] = DataProvider<GiangVien>.GetList(gv => gv.CoThePhanCong).Select(gv => new { gv.HoVaTen, gv.MaGv });
            ViewData["Tuans"] = DataProvider<TuanHoc>.GetAll().Select(t =>new{ t.SttTuan});
            return View();

        }

        public ActionResult LayDsTuan([DataSourceRequest] DataSourceRequest request)
        {
            var dsTuan = DataProvider<TuanHoc>.GetList(t => t.NgayBatDau <= DateTime.Now.AddDays(14).Monday()).Select(t => t.SttTuan).OrderByDescending(t => t);
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
            var result = DataProvider<TkbGiangVien>.GetAll();
            return Json(result.ToDataSourceResult(request, tk => new TkbGiangVienViewModel()
            {
                MaGv = tk.MaGv,
                LopHoc = tk.LopHoc,
                TenMonHoc = tk.TenMonHoc,
                SttTuan = tk.SttTuan,
                NgayTrongTuan = tk.NgayTrongTuan,
                Phong = tk.Phong,
                TietBatDau = tk.TietBatDau,
                TietKetThuc = tk.TietKetThuc
            }));
        }
    }
}
