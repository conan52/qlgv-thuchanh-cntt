using System;
using System.Linq;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using TkbThucHanhCNTT.Models;
using TkbThucHanhCNTT.Models.Provider;
using TkbThucHanhCNTT.Models.Viewer;

namespace TkbThucHanhCNTT.Controllers
{
    [Authorize(Roles = "AdminTeacher,Admin")]
    public class LichBanController : Controller
    {
        //
        // GET: /LichBanControler/
        public ActionResult Index()
        {
            return this.View();
        }

        public ActionResult LayDsTuan([DataSourceRequest]
                                      DataSourceRequest request)
        {
            var dsTuan =
                DataProvider<TuanHoc>.GetList(t => t.LichBans.Any())
                                     .Select(t => t.SttTuan)
                                                  .OrderByDescending(t => t);
            return this.Json(dsTuan, JsonRequestBehavior.AllowGet);
        }

        public JsonResult AjaxReadData([DataSourceRequest]
                                       DataSourceRequest request)
        {
            var result = DataProvider<LichBan>.GetAll(l => l.GiangVien)
                                              .OrderByDescending(t => t.SttTuan)
                                              .ThenBy(t => t.MaGv);

            return this.Json(result.ToDataSourceResult(request, l => new LichBanModelViewer()
            {
                LichBanId = l.LichBanId,
                TenGv = l.GiangVien.HoVaTen,
                SttTuan = l.SttTuan,
                SoBuoiBan = l.TrangThaiBan.ToCharArray().Count(c => c.Equals('1')),
                SoBuoiRanh = l.TrangThaiBan.ToCharArray().Count(c => c.Equals('0'))
            }));
        }

        public JsonResult AjaxDelete(int lichBanId)
        {
            try
            {
                DataProvider<LichBan>.RemoveById(lichBanId);
                return this.Json(new { Result = "OK" });
            }
            catch (Exception ex)
            {
                return this.Json(new { Result = "Fail", ex.Message });
            }
        }

        public ActionResult ShowEditWindow(string maLichBan)
        {
            var lichBan = DataProvider<LichBan>.GetSingle(l => l.LichBanId.ToString() == maLichBan);
            if (maLichBan == null || lichBan == null)
            {
                this.ViewData["maGv"] = null;
                var dsTuan = DataProvider<TuanHoc>.GetList(t => t.NgayKetThuc >= DateTime.Now);
                if (dsTuan.Count > 0)
                    this.ViewData["tuan"] = dsTuan.Min(l => l.SttTuan);
                else
                    this.ViewData["tuan"] = 0;
                this.ViewData["trangThai"] = "00000000000000000000000";
                this.ViewData["maLichBan"] = 0;
            }
            else
            {
                this.ViewData["maGv"] = lichBan.MaGv;
                this.ViewData["tuan"] = lichBan.SttTuan;
                this.ViewData["trangThai"] = lichBan.TrangThaiBan;
                this.ViewData["maLichBan"] = maLichBan;
            }
            this.ViewData["dsGiangVien"] = DataProvider<GiangVien>.GetList(g => g.CoThePhanCong)
                                                                  .Select(g => new { g.MaGv, g.HoVaTen });
            this.ViewData["dsTuanTuongLai"] = DataProvider<TuanHoc>.GetList(t => t.NgayKetThuc >= DateTime.Now)
                                                                   .Select(t => new { t.SttTuan });
            return this.View();
        }

        public JsonResult AjaxEdit(int lichBanId, string maGv, int SttTuan, string value)
        {
            try
            {
                var lb = DataProvider<LichBan>.GetSingle(l => l.MaGv == maGv && l.SttTuan == SttTuan || l.LichBanId == lichBanId);
                if (lichBanId == 0 && lb == null)
                    DataProvider<LichBan>.Add(new LichBan()
                    {
                        MaGv = maGv,
                        SttTuan = SttTuan,
                        TrangThaiBan = value
                    });
                else
                {
                    lb.TrangThaiBan = value;
                    DataProvider<LichBan>.Update(lb);
                }
                return this.Json(new { Result = "OK" });
            }
            catch (Exception ex)
            {
                return this.Json(new { Result = "Fail", ex.Message });
            }
        }
    }
}