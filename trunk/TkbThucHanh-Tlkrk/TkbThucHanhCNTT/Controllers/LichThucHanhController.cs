using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DluWebHelper;
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
        public ActionResult Test()
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
            var result = DataProvider<LichThucHanh>.GetAll()
                .OrderByDescending(t => t.SttTuan)
                .ThenBy(t => t.NgayTrongTuan)
                .ThenBy(t => t.TietBatDau)
                .ThenBy(t => t.TietKetThuc);

            return Json(result.ToDataSourceResult(request));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult AjaxUpdate([DataSourceRequest] DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<LichThucHanh> ls)
        {
            var results = new List<LichThucHanh>();

            if (ls != null && ModelState.IsValid)
            {
                foreach (var l in ls)
                {
                    if (l != null && ModelState.IsValid)
                    {
                        if (l.Gvhd2 != null && l.Gvhd2.Length <= 2)
                            l.Gvhd2 = null;
                        if (l.Gvhd3 != null && l.Gvhd3.Length <= 2)
                            l.Gvhd3 = null;
                        results.Add(l);
                    }
                }
            }
            DataProvider<LichThucHanh>.Update(results);
            return Json(results.ToDataSourceResult(request, ModelState));
        }


        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult AjaxCreate([DataSourceRequest] DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<LichThucHanh> ls)
        {
            var results = new List<LichThucHanh>();

            if (ls != null && ModelState.IsValid)
            {
                foreach (var l in ls)
                {
                    if (l != null && ModelState.IsValid)
                    {
                        if (l.Gvhd2 != null && l.Gvhd2.Length <= 2)
                            l.Gvhd2 = null;
                        if (l.Gvhd3 != null && l.Gvhd3.Length <= 2)
                            l.Gvhd3 = null;
                        results.Add(l);
                    }
                }
            }
            DataProvider<LichThucHanh>.Add(results);
            return Json(results.ToDataSourceResult(request, ModelState));
        }



        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult AjaxDelete([DataSourceRequest] DataSourceRequest request, [Bind(Prefix = "models")]IEnumerable<LichThucHanh> ls)
        {
            var results = ls.ToList();
            DataProvider<LichThucHanh>.Remove(results);
            return Json(results.ToDataSourceResult(request, ModelState));
        }



        public JsonResult DongBoLichThucHanh()
        {
            try
            {
                var tkbgv = DataProvider<TkbGiangVien>.GetAll(t => t.TuanHoc);
                var phongTH = DataProvider<PhongThucHanh>.GetAll();
                var tkbth = (from tkb in tkbgv
                             join p in phongTH on tkb.Phong equals p.TenPhong
                             select new LichThucHanh()
                             {
                                 SttTuan = tkb.SttTuan,
                                 NgayTrongTuan = tkb.NgayTrongTuan,
                                 TenLop = tkb.LopHoc,
                                 TietBatDau = tkb.TietBatDau,
                                 TietKetThuc = tkb.TietKetThuc,
                                 Gvhd1 = tkb.MaGv,
                                 GhiChu = tkb.TenMonHoc,
                                 TenPhong = tkb.Phong
                             }).ToList();

                var phancong = DataProvider<PhanCongGiangDay>.GetAll(p => p.MonHoc);
                foreach (var tkb in tkbth)
                {
                    try
                    {
                        var pc = phancong.SingleOrDefault(p => p.MonHoc.TenThucHanh.StartsWith(tkb.GhiChu, StringComparison.OrdinalIgnoreCase) && p.TenLop == tkb.TenLop);
                        if (tkb.GhiChu.Contains("Web"))
                            tkb.GhiChu = "";
                        if (pc != null)
                            tkb.MonHocId = pc.MonHocId;
                        else
                            throw new Exception();
                        tkb.GhiChu = "";
                        DataProvider<LichThucHanh>.Add(tkb);
                    }
                    catch (Exception)
                    {
                        Console.Beep();
                    }
                }


                return Json(new { Result = "OK", Message = tkbth.Count });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "Fail", ex.Message });
            }
        }


    }
}
