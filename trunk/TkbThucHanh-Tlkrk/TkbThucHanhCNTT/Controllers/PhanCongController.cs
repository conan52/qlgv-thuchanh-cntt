using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using TkbThucHanhCNTT.Models;
using TkbThucHanhCNTT.Models.Provider;
using TkbThucHanhCNTT.Models.Viewer;

namespace TkbThucHanhCNTT.Controllers
{
    public class PhanCongController : Controller
    {
        //
        // GET: /PhanCong/

        public ActionResult Index()
        {
            ViewData["GiaoViens"] = DataProvider<GiangVien>.GetAll().Select(gv => new { gv.MaGv, gv.HoVaTen });
            ViewData["MonHocs"] = DataProvider<MonHoc>.GetAll().Select(m => new { m.MonHocId, m.TenMonHoc });
            return View();
        }


        public JsonResult AjaxReadData([DataSourceRequest] DataSourceRequest request)
        {
            var result = DataProvider<PhanCongGiangDay>.GetAll(pc => pc.MonHoc, pc => pc.GiangVien);
            return Json(result.ToDataSourceResult(request, pc => new { pc.MaGv, pc.MonHocId, pc.TenLop, pc.IdPhanCong }));
        }




        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult AjaxDelete([DataSourceRequest] DataSourceRequest request, GiangVien gv)
        {
            // Test if gv object and modelstate is valid.
            if (gv != null && ModelState.IsValid)
            {
                DataProvider<GiangVien>.Remove(gv);
            }
            return Json(ModelState.ToDataSourceResult());
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult AjaxCreate([DataSourceRequest] DataSourceRequest request, PhanCongGiangDay pc)
        {
            if (pc != null && ModelState.IsValid)
            {
                ///
                var p = new PhanCongGiangDay()
                {
                    
                };
                DataProvider<PhanCongGiangDay>.Add(p);
            }

            return Json(new[] { pc }.ToDataSourceResult(request, ModelState));
        }
    }
}
