﻿using System;
using System.Linq;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using TkbThucHanhCNTT.Models;
using TkbThucHanhCNTT.Models.Provider;

namespace TkbThucHanhCNTT.Controllers
{
    //  [Authorize(Roles = "AdminTeacher,Admin")]
    public class PhanCongController : Controller
    {
        //
        // GET: /PhanCong/

        public ActionResult Index()
        {
            ViewData["GiangViens"] =
                DataProvider<GiangVien>.GetList(gv => gv.CoThePhanCong).Select(gv => new { gv.HoVaTen, gv.MaGv });
            ViewData["MonHocs"] = DataProvider<MonHoc>.GetAll().Select(m => new { m.MonHocId, m.TenMonHoc, m.MaMonHoc });
            ViewData["Lops"] = DataProvider<Lop>.GetAll().Select(m => new { m.TenLop });
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult AjaxDelete([DataSourceRequest] DataSourceRequest request, PhanCong idpc)
        {
            // Test if gv object and modelstate is valid.
            if (idpc != null && ModelState.IsValid)
            {
                DataProvider<PhanCong>.Remove(idpc);
            }
            return Json(ModelState.ToDataSourceResult());
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult AjaxCreate([DataSourceRequest] DataSourceRequest request, PhanCong pc)
        {
            if (pc != null && ModelState.IsValid)
            {
                try
                {
                    DataProvider<PhanCong>.Add(pc);
                }
                catch (Exception)
                {
                }
            }

            return Json(new[] { pc }.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult AjaxUpdate([DataSourceRequest] DataSourceRequest request, PhanCong pc)
        {
            // Test if gv object and modelstate is valid.
            if (pc != null && ModelState.IsValid)
            {
                DataProvider<PhanCong>.Update(pc);
            }
            return Json(ModelState.ToDataSourceResult());
        }

        public JsonResult AjaxReadData([DataSourceRequest] DataSourceRequest request)
        {
            var result =
                DataProvider<PhanCong>.GetAll()
                    .Select(x => new { x.NamHoc, x.HocKy, x.MonHocId, x.SoLuongGiangVien, x.TenLop, x.IdPhanCong });
            return Json(result.ToDataSourceResult(request));
        }

        public ActionResult ChinhSuaPhanCong(string idPhanCong)
        {
            ViewData["IdPhanCong"] = idPhanCong;
            var dsGv = DataProvider<GiangVien>.GetList(gv => gv.CoThePhanCong).Select(gv => new { gv.HoVaTen, gv.MaGv });

            var jsonSerialiser = new JavaScriptSerializer();
            ViewData["GiangViens"] = jsonSerialiser.Serialize(dsGv);

            return View();

        }
    }
}