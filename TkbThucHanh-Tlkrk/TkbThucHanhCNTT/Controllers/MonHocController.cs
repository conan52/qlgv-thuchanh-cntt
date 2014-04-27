using System;
using System.Linq;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using TkbThucHanhCNTT.Models;
using TkbThucHanhCNTT.Models.Enums;
using TkbThucHanhCNTT.Models.Provider;

namespace TkbThucHanhCNTT.Controllers
{
    [Authorize(Roles = "AdminTeacher,Admin")]
    public class MonHocController : Controller
    {
        //
        // GET: /MonHoc/

        public ActionResult Index()
        {
            ViewData["TrinhDos"] = EnumUltils.GetDescriptions_TrinhDo();
            ViewData["ChuyenNganhs"] = EnumUltils.GetDescriptions_ChuyenNganh();
            return View();
        }


        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult AjaxDelete([DataSourceRequest] DataSourceRequest request, MonHoc mamh)
        {
            // Test if gv object and modelstate is valid.
            if (mamh != null && ModelState.IsValid)
            {
                DataProvider<MonHoc>.Remove(mamh);
            }
            return Json(ModelState.ToDataSourceResult());
        }


        public JsonResult AjaxReadData([DataSourceRequest] DataSourceRequest request)
        {
            var result =
                DataProvider<MonHoc>.GetAll(l => l.PhanCongGiangDays)
                    .Select(
                        x => new {x.MaMonHoc, x.MonHocId, x.TenMonHoc, x.SoTinChi, x.TrinhDo, x.ChuyenNganh, x.BatBuoc});
            return Json(result.ToDataSourceResult(request));
        }


        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult AjaxCreate([DataSourceRequest] DataSourceRequest request, MonHoc mh)
        {
            if (mh != null && ModelState.IsValid)
            {
                if (DataProvider<MonHoc>.GetAll().Any(x => x.MaMonHoc.Equals(mh.MaMonHoc, StringComparison.OrdinalIgnoreCase)))
                {
                    ModelState.AddModelError("", "Mã môn học đã tồn tại");
                    return Json(new[] {mh}.ToDataSourceResult(request, ModelState));
                }
                try
                {
                    DataProvider<MonHoc>.Add(mh);
                }
                catch (Exception)
                {
                }
            }

            return Json(new[] {mh}.ToDataSourceResult(request, ModelState));
        }


        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Ajax_Update([DataSourceRequest] DataSourceRequest request, MonHoc mh)
        {
            // Test if gv object and modelstate is valid.
            if (mh != null && ModelState.IsValid)
            {
                DataProvider<MonHoc>.Update(mh);
            }
            return Json(ModelState.ToDataSourceResult());
        }
    }
}