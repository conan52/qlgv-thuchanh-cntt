using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using TkbThucHanhCNTT.Models;
using TkbThucHanhCNTT.Models.Provider;
using TkbThucHanhCNTT.Models.Viewer;

namespace TkbThucHanhCNTT.Controllers
{
    [Authorize(Roles = "AdminTeacher")]
    public class PhanCongGiangDayController : Controller
    {
        //
        // GET: /PhanCongGiangDay/

        public ActionResult Index()
        {
            ViewData["GiangViens"] =
                DataProvider<GiangVien>.GetList(gv => gv.CoThePhanCong).Select(gv => new { gv.HoVaTen, gv.MaGv });
            ViewData["MonHocs"] = DataProvider<MonHoc>.GetAll().Select(m => new { m.MonHocId, m.TenMonHoc,m.MaMonHoc });
            ViewData["Lops"] = DataProvider<Lop>.GetAll().Select(m => new { m.TenLop });
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult AjaxDelete([DataSourceRequest] DataSourceRequest request, PhanCongGiangDay idpc)
        {
            // Test if gv object and modelstate is valid.
            if (idpc != null && ModelState.IsValid)
            {
                DataProvider<PhanCongGiangDay>.Remove(idpc);
            }
            return Json(ModelState.ToDataSourceResult());
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult AjaxCreate([DataSourceRequest] DataSourceRequest request, PhanCongGiangDay pc)
        {
            if (pc != null && ModelState.IsValid)
            {
                try
                {
                    DataProvider<PhanCongGiangDay>.Add(pc);
                }
                catch (Exception)
                {

                }

            }

            return Json(new[] { pc }.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult AjaxUpdate([DataSourceRequest] DataSourceRequest request, PhanCongGiangDay pc)
        {
            // Test if gv object and modelstate is valid.
            if (pc != null && ModelState.IsValid)
            {
                DataProvider<PhanCongGiangDay>.Update(pc);
            }
            return Json(ModelState.ToDataSourceResult());
        }

        public JsonResult AjaxReadData([DataSourceRequest] DataSourceRequest request)
        {
            var result =
                DataProvider<PhanCongGiangDay>.GetAll()
                    .Select(x => new {x.NamHoc, x.HocKy, x.MonHocId, x.MaGv, x.TenLop, x.IdPhanCong});
            return Json(result.ToDataSourceResult(request));
        }
    }
}