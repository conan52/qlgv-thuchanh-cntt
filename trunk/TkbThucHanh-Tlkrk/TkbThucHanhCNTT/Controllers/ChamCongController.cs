using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using TkbThucHanhCNTT.Models.Provider;
using TkbThucHanhCNTT.Models.Viewer;

namespace TkbThucHanhCNTT.Controllers
{
    [Authorize(Roles = "AdminTeacher")]
    public class ChamCongController : Controller
    {
        //
        // GET: /ChamCong/

        public ActionResult ChamCongTheoGv()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Read([DataSourceRequest] DataSourceRequest request)
        {
            var models = ChamCongProvider.GetAll();
            var result = models.GroupBy(m => new { m.MonHocId, m.TenMonHoc, m.TenLop, m.MaGv, m.TenGv })
                .Select(g => new ChamCongGrouped()
                {
                    Nhom = string.Format("{0} - {1}", g.Key.TenMonHoc, g.Key.TenLop),
                    TenGv = g.Key.TenGv,
                    TongSoTiet = g.Sum(t => t.SoTiet)
                });

            return Json(result.ToDataSourceResult(request));
        }
    }
}
