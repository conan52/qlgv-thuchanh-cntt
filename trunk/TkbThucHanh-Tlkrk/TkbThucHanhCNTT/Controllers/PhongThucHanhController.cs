using System;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using TkbThucHanhCNTT.Models;
using TkbThucHanhCNTT.Models.Provider;

namespace TkbThucHanhCNTT.Controllers
{
//    [Authorize(Roles = "AdminTeacher")]
    public class PhongThucHanhController : Controller
    {
        //
        // GET: /PhongThucHanh/

        public ActionResult Index()
        {
            return View();
        }


        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult AjaxDelete([DataSourceRequest] DataSourceRequest request, string tenphong)
        {
            // Test if gv object and modelstate is valid.
            if (tenphong != null && ModelState.IsValid)
            {
                DataProvider<PhongThucHanh>.RemoveById(tenphong);
            }
            return Json(ModelState.ToDataSourceResult());
        }


        public JsonResult AjaxReadData([DataSourceRequest] DataSourceRequest request)
        {
            var result = DataProvider<PhongThucHanh>.GetAll();
            return Json(result.ToDataSourceResult(request));
        }


        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult AjaxCreate([DataSourceRequest] DataSourceRequest request, PhongThucHanh phongth)
        {
            if (phongth != null && ModelState.IsValid)
            {
                try
                {
                    DataProvider<PhongThucHanh>.Add(phongth);
                }
                catch (Exception)
                {

                }

            }

            return Json(new[] { phongth }.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Ajax_Update([DataSourceRequest] DataSourceRequest request, PhongThucHanh phongth)
        {
            //ko sua phong thuc hanh
            // Test if gv object and modelstate is valid.
            if (phongth != null && ModelState.IsValid)
            {
                DataProvider<PhongThucHanh>.Update(phongth);
            }
            return Json(ModelState.ToDataSourceResult());
        }

    }
}
