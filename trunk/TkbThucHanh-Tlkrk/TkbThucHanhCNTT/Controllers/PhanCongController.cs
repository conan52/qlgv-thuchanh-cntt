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

    }
}
