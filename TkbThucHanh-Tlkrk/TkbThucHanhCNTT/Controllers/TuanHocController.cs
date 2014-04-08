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
    public class TuanHocController : Controller
    {
        //
        // GET: /TuanHoc/

        public ActionResult Index()
        {
            return View();
        }


        public JsonResult AjaxReadData([DataSourceRequest] DataSourceRequest request)
        {
            var result = DataProvider<TuanHoc>.GetAll().OrderBy(t => t.SttTuan);
            return Json(result.ToDataSourceResult(request));
        }

        public JsonResult AjaxInitWeek(int week, string dateOfWeek)
        {
            var tuan = DataProvider<TuanHoc>.GetAll();
            DataProvider.Remove(tuan);
            return Json(new { Result = "OK" });
        }

    }
}
