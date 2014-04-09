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
        public ActionResult AjaxDelete([DataSourceRequest] DataSourceRequest request, string mamh)
        {
            // Test if gv object and modelstate is valid.
            if (mamh != null && ModelState.IsValid)
            {
                DataProvider<MonHoc>.RemoveById(mamh);
            }
            return Json(ModelState.ToDataSourceResult());
        }


        public JsonResult AjaxReadData([DataSourceRequest] DataSourceRequest request)
        {
            var result = DataProvider<LichCongTac>.GetAll();
            return Json(result.ToDataSourceResult(request));
        }


        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult AjaxCreate([DataSourceRequest] DataSourceRequest request, LichCongTac lct)
        {
            if (lct != null && ModelState.IsValid)
            {
                DataProvider<LichCongTac>.Add(lct);
            }

            return Json(new[] { lct }.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Ajax_Update([DataSourceRequest] DataSourceRequest request, LichCongTac lct)
        {
            // Test if gv object and modelstate is valid.
            if (lct != null && ModelState.IsValid)
            {
                DataProvider<LichCongTac>.Update(lct);
            }
            return Json(ModelState.ToDataSourceResult());
        }

    }
}
