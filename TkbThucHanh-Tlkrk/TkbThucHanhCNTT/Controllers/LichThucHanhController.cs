using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using TkbThucHanhCNTT.Models;
using TkbThucHanhCNTT.Models.Provider;
using TkbThucHanhCNTT.Models.Ultils;

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

            IList<TuanHoc> dsTuan = DataProvider<TuanHoc>.GetAll();
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

            IList<TuanHoc> dsTuan = DataProvider<TuanHoc>.GetAll();
            ViewData["Tuans"] = dsTuan.Select(t => new { t.SttTuan });
            if (dsTuan.Any(t => t.NgayBatDau > DateTime.Now))
                ViewData["TuanMoiNhat"] = dsTuan.First(t => t.NgayBatDau > DateTime.Now).SttTuan;
            else
                ViewData["TuanMoiNhat"] = 0;

            return View();
        }

        public ActionResult LayDsTuan([DataSourceRequest] DataSourceRequest request)
        {
            IOrderedEnumerable<int> dsTuan =
                DataProvider<TuanHoc>.GetList(t => t.LichThucHanhs != null && t.LichThucHanhs.Count > 0)
                    .Select(t => t.SttTuan)
                    .OrderByDescending(t => t);
            return Json(dsTuan, JsonRequestBehavior.AllowGet);
        }

        public JsonResult AjaxReadData([DataSourceRequest] DataSourceRequest request)
        {
            IOrderedEnumerable<LichThucHanh> result = DataProvider<LichThucHanh>.GetAll(l => l.MonHoc, l => l.GiangVien1, l => l.GiangVien2, l => l.GiangVien3)
                .OrderByDescending(t => t.SttTuan)
                .ThenBy(t => t.NgayTrongTuan)
                .ThenBy(t => t.TietBatDau)
                .ThenBy(t => t.TietKetThuc);

            return Json(result.ToDataSourceResult(request, l => new
            {
                l.MaLichTh,
                l.TenLop,
                l.TenPhong,
                l.MonHocId,
                l.NgayTrongTuan,
                l.SttTuan,
                l.TietBatDau,
                l.TietKetThuc,
                l.Gvhd1,
                l.Gvhd2,
                l.Gvhd3,
                l.Gv1CoMat,
                l.Gv2CoMat,
                l.Gv3CoMat,
                l.Vang,
                l.GhiChu,
                l.MonHoc.TenThucHanh,
                TenGv1 = l.Gvhd1 != null ? l.GiangVien1.HoVaTen : null,
                TenGv2 = l.Gvhd2 != null ? l.GiangVien2.HoVaTen : null,
                TenGv3 = l.Gvhd3 != null ? l.GiangVien3.HoVaTen : null

            }));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult AjaxUpdate([DataSourceRequest] DataSourceRequest request, [Bind(Prefix = "models")] IEnumerable<LichThucHanh> ls)
        {
            var results = new List<LichThucHanh>();

            if (ls != null && ModelState.IsValid)
            {
                foreach (LichThucHanh l in ls)
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
        public ActionResult AjaxCreate([DataSourceRequest] DataSourceRequest request, [Bind(Prefix = "models")] IEnumerable<LichThucHanh> ls)
        {
            var results = new List<LichThucHanh>();

            if (ls != null && ModelState.IsValid)
            {
                foreach (LichThucHanh l in ls)
                {
                    if (l != null && ModelState.IsValid)
                    {
                        l.Gv1CoMat = l.Gv2CoMat = l.Gv3CoMat = true;
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
        public ActionResult AjaxDelete([DataSourceRequest] DataSourceRequest request, [Bind(Prefix = "models")] IEnumerable<LichThucHanh> ls)
        {
            List<LichThucHanh> results = ls.ToList();
            DataProvider<LichThucHanh>.Remove(results);
            return Json(results.ToDataSourceResult(request, ModelState));
        }


        public JsonResult DongBoLichThucHanh()
        {
            try
            {
                IList<TkbGiangVien> tkbgv = DataProvider<TkbGiangVien>.GetAll(t => t.TuanHoc);
                IList<PhongThucHanh> phongTH = DataProvider<PhongThucHanh>.GetAll();
                List<LichThucHanh> tkbth = (from tkb in tkbgv
                                            join p in phongTH on tkb.Phong equals p.TenPhong
                                            select new LichThucHanh
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

                IList<PhanCongGiangDay> phancong = DataProvider<PhanCongGiangDay>.GetAll(p => p.MonHoc);
                foreach (LichThucHanh tkb in tkbth)
                {
                    try
                    {
                        PhanCongGiangDay pc = phancong.SingleOrDefault(p => p.MonHoc.TenThucHanh.StartsWith(tkb.GhiChu, StringComparison.OrdinalIgnoreCase) && p.TenLop == tkb.TenLop);
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


        public JsonResult DiemDanhGv(int lichHocId, bool gv1, bool gv2, bool gv3)
        {
            try
            {
                var lichTh = DataProvider<LichThucHanh>.GetSingle(l => l.MaLichTh == lichHocId);
                lichTh.Gv1CoMat = gv1;
                lichTh.Gv2CoMat = gv2;
                lichTh.Gv3CoMat = gv3;

                DataProvider<LichThucHanh>.Update(lichTh);
                return Json(new { Result = "OK" });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "Fail", ex.Message });
            }
        }
    }
}