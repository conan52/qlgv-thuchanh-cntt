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

namespace TkbThucHanhCNTT.Controllers
{
    [Authorize(Roles = "AdminTeacher")]
    public class LichCongTacController : Controller
    {
        //
        // GET: /LichCongTac/

        public ActionResult Index()
        {
            ViewData["GiangViens"] = DataProvider<GiangVien>.GetAll().Select(gv => new { gv.HoVaTen, gv.MaGv });
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult AjaxDelete([DataSourceRequest] DataSourceRequest request, LichCongTac lct)
        {
            // Test if gv object and modelstate is valid.
            if (lct != null)
            {
                DataProvider<LichCongTac>.Remove(lct);
            }
            return Json(ModelState.ToDataSourceResult());
        }


        public JsonResult AjaxReadData([DataSourceRequest] DataSourceRequest request)
        {
            var result = DataProvider<LichCongTac>.GetAll().Select(ct=>new {ct.MaGv,ct.ThoiGianBd, ct.ThoiGianKt, ct.LyDo, ct.LichCongTacId});
            return Json(result.ToDataSourceResult(request));
        }


        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult AjaxCreate([DataSourceRequest] DataSourceRequest request, int LichCongTacId, string MaGv, string LyDo, string ThoiGianBd, string ThoiGianKt)
        {
            var lct = new LichCongTac()
            {
                LyDo=LyDo,
                MaGv=MaGv    ,
                ThoiGianBd=getDateTime(ThoiGianBd),
                ThoiGianKt = getDateTime(ThoiGianKt)
            };

                DataProvider<LichCongTac>.Add(lct);

            return Json(new[] { lct }.ToDataSourceResult(request, ModelState));
         
        }

        DateTime getDateTime(string d)
        {
            string s = d.Substring(0, 10);
            return DateTime.ParseExact(s, "dd/MM/yyyy", null);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Ajax_Update([DataSourceRequest] DataSourceRequest request, int LichCongTacId, string MaGv, string LyDo, string ThoiGianBd, string ThoiGianKt)
        {

            var lct = new LichCongTac()
            {
                LichCongTacId=LichCongTacId,
                LyDo = LyDo,
                MaGv = MaGv,
                ThoiGianBd = getDateTime(ThoiGianBd),
                ThoiGianKt = getDateTime(ThoiGianKt)
            };

            DataProvider<LichCongTac>.Update(lct);

            return Json(new[] { lct }.ToDataSourceResult(request, ModelState));
        }

    }
}
