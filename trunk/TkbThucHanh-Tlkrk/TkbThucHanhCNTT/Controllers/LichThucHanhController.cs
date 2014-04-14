using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using TkbThucHanhCNTT.Models;
using TkbThucHanhCNTT.Models.Enums;
using TkbThucHanhCNTT.Models.Provider;

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
            ViewData["TuanCoTkb"] = DataProvider<TuanHoc>.GetList(t => t.LichThucHanhs.Any(), t => t.LichThucHanhs).Select(t => t.SttTuan);
            ViewData["TuanChuaCoTkb"] = DataProvider<TuanHoc>.GetList(t => !t.LichThucHanhs.Any() && t.NgayKetThuc >= DateTime.Now, t => t.LichThucHanhs).Select(t => t.SttTuan);



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
            var result = DataProvider<LichThucHanh>.GetAll(l => l.MonHoc, l => l.GiangVien1, l => l.GiangVien2, l => l.GiangVien3)
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
                foreach (var l in ls)
                {
                    if (l != null && ModelState.IsValid)
                    {
                        if (l.Gvhd2 != null && (l.Gvhd2.Length <= 2 || l.Gvhd2.Contains("]")))
                            l.Gvhd2 = null;
                        if (l.Gvhd3 != null && (l.Gvhd3.Length <= 2 || l.Gvhd3.Contains("]")))
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
                foreach (var l in ls)
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
            var results = ls.ToList();
            DataProvider<LichThucHanh>.Remove(results);
            return Json(results.ToDataSourceResult(request, ModelState));
        }


        public JsonResult DongBoLichThucHanh()
        {
            try
            {
                var phancong = DataProvider<PhanCongGiangDay>.GetAll(p => p.MonHoc);
                var phongTh = DataProvider<PhongThucHanh>.GetAll();
                var tkbgv = DataProvider<TkbGiangVien>.GetList(t => !t.TuanHoc.DaXepLichThucHanh && phongTh.Any(p => p.TenPhong == t.Phong), t => t.TuanHoc);

                int n = 0;
                foreach (var tkb in tkbgv)
                {
                    try
                    {
                        var lichTh = new LichThucHanh
                        {
                            SttTuan = tkb.SttTuan,
                            NgayTrongTuan = tkb.NgayTrongTuan,
                            TenLop = tkb.LopHoc,
                            TietBatDau = tkb.TietBatDau,
                            TietKetThuc = tkb.TietKetThuc,
                            Gvhd1 = tkb.MaGv,
                            GhiChu = tkb.TenMonHoc,
                            TenPhong = tkb.Phong,
                            Gv1CoMat = true,
                            Gv2CoMat = true,
                            Gv3CoMat = true
                        };
                        var pc = phancong.SingleOrDefault(p => p.MonHoc.TenThucHanh.StartsWith(tkb.TenMonHoc, StringComparison.OrdinalIgnoreCase) && p.TenLop == tkb.LopHoc);
                        if (pc != null)
                        {

                            lichTh.MonHocId = pc.MonHocId;

                            DataProvider<LichThucHanh>.Add(lichTh);
                            DataProvider<TkbGiangVien>.Remove(tkb);
                            n++;
                        }

                        else
                        {
                            System.Diagnostics.Debug.WriteLine("{0}\t{1}\t{2}", tkb.TenMonHoc, tkb.MaGv, tkb.LopHoc);
                            throw new FormatException("Không nhận dạng được môn học hoặc không có trong phân công");
                        }

                    }

                    catch (FormatException)
                    {
                        Console.Beep();
                    }
                    catch (Exception)
                    {

                    }
                }



                return Json(new { Result = "OK", Message = n });
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

        public JsonResult SaoChepLich(int tuTuan, int denTuan)
        {
            try
            {
                var dsLichCanChep = DataProvider<LichThucHanh>.GetList(l => l.SttTuan == tuTuan);
                var result = new List<LichThucHanh>();

                foreach (var lth in dsLichCanChep)
                {
                    LichThucHanh l = new LichThucHanh()
                    {
                        Gv1CoMat = true,
                        Gv2CoMat = true,
                        Gv3CoMat = true,
                        Gvhd1 = lth.Gvhd1,
                        Gvhd2 = lth.Gvhd2,
                        Gvhd3 = lth.Gvhd3,
                        MonHocId = lth.MonHocId,
                        NgayTrongTuan = lth.NgayTrongTuan,
                        SttTuan = denTuan,
                        TenLop = lth.TenLop,
                        TenPhong = lth.TenPhong,
                        TietBatDau = lth.TietBatDau,
                        TietKetThuc = lth.TietKetThuc
                    };
                    result.Add(l);
                }
                DataProvider<LichThucHanh>.Add(result);

                return Json(new { Result = "OK", Message = result.Count });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "Fail", ex.Message });
            }
        }
        public JsonResult TuPhanCong(int chonTuan)
        {
            try
            {
                var all = DataProvider<LichThucHanh>.GetAll();
                var dsLichCanChep = all.Where(l => l.SttTuan == chonTuan).ToList();
                foreach (var lth in dsLichCanChep)
                {
                    if (lth.Gvhd1 == null)
                    {
                        var lt = all.FirstOrDefault(l => l.MonHocId == lth.MonHocId && l.TenLop == lth.TenLop && l.Gvhd1 != null);
                        if (lt != null) lth.Gvhd1 = lt.Gvhd1;
                    }
                    if (lth.Gvhd2 == null)
                    {
                        var lt = all.FirstOrDefault(l => l.MonHocId == lth.MonHocId && l.TenLop == lth.TenLop && l.Gvhd2 != null);
                        if (lt != null) lth.Gvhd2 = lt.Gvhd2;
                    }
                    if (lth.Gvhd3 == null)
                    {
                        var lt = all.FirstOrDefault(l => l.MonHocId == lth.MonHocId && l.TenLop == lth.TenLop && l.Gvhd3 != null);
                        if (lt != null) lth.Gvhd3 = lt.Gvhd3;
                    }
                }
                DataProvider<LichThucHanh>.Update(dsLichCanChep);


                return Json(new { Result = "OK", Message = dsLichCanChep.Count });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "Fail", ex.Message });
            }
        }
    }
}