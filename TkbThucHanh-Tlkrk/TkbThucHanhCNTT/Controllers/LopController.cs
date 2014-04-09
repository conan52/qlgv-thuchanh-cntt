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
using TkbThucHanhCNTT.Models.Viewer;

namespace TkbThucHanhCNTT.Controllers
{
    public class LopController : Controller
    {
        //
        // GET: /Lop/

        //        public ActionResult Index()
        //        {
        //            return View();
        //        }

        public ActionResult Index()
        {
            ViewData["TrinhDos"] = EnumUltils.GetDescriptions_TrinhDo();
            return View();

        }

        public JsonResult GetGv()
        {
            var result = DataProvider<GiangVien>.GetAll().Select(gv => new { gv.HoVaTen, gv.MaGv });

            return this.Json(result);
        }



        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult AjaxDelete([DataSourceRequest] DataSourceRequest request, int? maLop)
        {
            // Test if gv object and modelstate is valid.
            if (maLop != null && ModelState.IsValid)
            {
                DataProvider<Lop>.RemoveById(maLop);
            }
            return Json(ModelState.ToDataSourceResult());
        }


        public JsonResult AjaxReadData([DataSourceRequest] DataSourceRequest request)
        {
            //            ViewData["TrinhDos"] = EnumUltils.GetDescriptions_TrinhDo();
            var result = DataProvider<Lop>.GetAll(l => l.PhanCongGiang);
            return Json(result.ToDataSourceResult(request));
        }


        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult AjaxCreate([DataSourceRequest] DataSourceRequest request, Lop lop)
        {

            if (lop != null && ModelState.IsValid)
            {
                try
                {
                    DataProvider<Lop>.Add(lop);
                }
                catch (Exception)
                {

                }

            }

            return Json(new[] { lop }.ToDataSourceResult(request, ModelState));
        }

        public ActionResult CheckKeyUnique(string malop)
        {
            return Json(DataProvider<Lop>.GetAll().Any(x => x.TenLop == malop), JsonRequestBehavior.AllowGet);
        }

    }
}
