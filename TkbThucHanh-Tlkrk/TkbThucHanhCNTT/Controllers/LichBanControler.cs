using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using TkbThucHanhCNTT.Models;
using TkbThucHanhCNTT.Models.Provider;
using TkbThucHanhCNTT.Models.Viewer;

namespace TkbThucHanhCNTT.Controllers
{
    public class LichBanController : Controller
    {
        //
        // GET: /LichBanControler/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult LayDsTuan([DataSourceRequest] DataSourceRequest request)
        {
            var dsTuan =
                DataProvider<TuanHoc>.GetList(t => t.LichBans.Any())
                    .Select(t => t.SttTuan)
                    .OrderByDescending(t => t);
            return Json(dsTuan, JsonRequestBehavior.AllowGet);
        }


        public JsonResult AjaxReadData([DataSourceRequest] DataSourceRequest request)
        {
            var result = DataProvider<LichBan>.GetAll(l => l.GiangVien)
                .OrderByDescending(t => t.SttTuan)
                .ThenBy(t => t.MaGv);

            return Json(result.ToDataSourceResult(request, l => new LichBanModelViewer()
            {
                LichBanId = l.LichBanId,
                TenGv = l.GiangVien.HoVaTen,
                SttTuan = l.SttTuan,
                SoBuoiBan = l.TrangThaiBan.ToCharArray().Count(c => c.Equals('1')),
                SoBuoiRanh = l.TrangThaiBan.ToCharArray().Count(c => c.Equals('0'))
            }));
        }

        public JsonResult AjaxDelete(int LichBanId)
        {
            try
            {
                DataProvider<LichBan>.RemoveById(LichBanId);
                return Json(new { Result = "OK" });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "Fail", ex.Message });
            }
        }

        public ActionResult ShowEditWindow(string maLichBan)
        {
            var lichBan = DataProvider<LichBan>.GetSingle(l => l.LichBanId.ToString() == maLichBan);
            if (maLichBan == null || lichBan == null)
            {
                ViewData["maGv"] = null;
                ViewData["tuan"] = DataProvider<TuanHoc>.GetList(t => t.NgayKetThuc >= DateTime.Now).Min(l => l.SttTuan);
                ViewData["trangThai"] = "00000000000000000000000";
                ViewData["maLichBan"] = 0;
            }
            else
            {
                ViewData["maGv"] = lichBan.MaGv;
                ViewData["tuan"] = lichBan.SttTuan;
                ViewData["trangThai"] = lichBan.TrangThaiBan;
                ViewData["maLichBan"] = maLichBan;
            }
            ViewData["dsGiangVien"] = DataProvider<GiangVien>.GetList(g => g.CoThePhanCong)
                .Select(g => new { g.MaGv, g.HoVaTen });
            ViewData["dsTuanTuongLai"] = DataProvider<TuanHoc>.GetList(t => t.NgayKetThuc >= DateTime.Now)
                .Select(t => new { t.SttTuan });
            return View();
        }

        public JsonResult AjaxEdit(int lichBanId, string maGv, int SttTuan, string value)
        {
            try
            {
                var lb = DataProvider<LichBan>.GetSingle(l => l.MaGv == maGv && l.SttTuan == SttTuan || l.LichBanId == lichBanId);
                if (lichBanId == 0 && lb == null)
                {
                    DataProvider<LichBan>.Add(new LichBan() { MaGv = maGv, SttTuan = SttTuan, TrangThaiBan = value });
                }
                else
                {
                    lb.TrangThaiBan = value;
                    DataProvider<LichBan>.Update(lb);
                }
                return Json(new { Result = "OK" });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "Fail", ex.Message });
            }
        }
    }
}
