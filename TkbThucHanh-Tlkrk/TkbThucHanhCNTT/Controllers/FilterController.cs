using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kendo.Mvc.UI;
using TkbThucHanhCNTT.Models;
using TkbThucHanhCNTT.Models.Provider;

namespace TkbThucHanhCNTT.Controllers
{
    public class FilterController : Controller
    {
        public JsonResult LayMonHocDuocPhanCong(string tenLop)
        {
            var result = DataProvider<MonHoc>.GetAll().Select(t => new { t.TenMonHoc, t.MaMonHoc, t.TenThucHanh, t.MonHocId });
            return Json(result, JsonRequestBehavior.AllowGet);
        }

    }
}
