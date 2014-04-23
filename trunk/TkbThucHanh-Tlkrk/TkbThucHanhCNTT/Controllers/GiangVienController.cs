﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Helpers;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.Ajax.Utilities;
using TkbThucHanhCNTT.Filters;
using TkbThucHanhCNTT.Models;
using TkbThucHanhCNTT.Models.Enums;
using TkbThucHanhCNTT.Models.Provider;
using TkbThucHanhCNTT.Models.Ultils;
using TkbThucHanhCNTT.Models.Viewer;
using WebMatrix.WebData;

namespace TkbThucHanhCNTT.Controllers
{
    [Authorize(Roles = "AdminTeacher,Admin")]
    public class GiangVienController : Controller
    {
        public ActionResult Index()
        {
            ViewData["ChuyenNganhs"] = EnumUltils.GetDescriptions_ChuyenNganh();
            return View();

        }

        
        public JsonResult GetGv()
        {
            var result = DataProvider<GiangVien>.GetAll();
            return this.Json(result, JsonRequestBehavior.AllowGet);
        }

        
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult AjaxDelete([DataSourceRequest] DataSourceRequest request, string magv)
        {
            // Test if gv object and modelstate is valid.
            if (magv != null && ModelState.IsValid)
            {
                DataProvider<GiangVien>.RemoveById(magv);
            }
            return Json(ModelState.ToDataSourceResult());
        }

        
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Ajax_Update([DataSourceRequest] DataSourceRequest request, GiangVienViewModel gvmd)
        {
            // Test if gv object and modelstate is valid.
            if (gvmd != null && ModelState.IsValid)
            {
                GiangVien gv = new GiangVien()
                {
                    MaGv = gvmd.MaGv,
                    ChuyenNganh = gvmd.ChuyenNganh,
                    CoThePhanCong = gvmd.CoThePhanCong,
                    HoVaTen = gvmd.HoVaTen,
                    //chua co tai khoan
                };
                DataProvider<GiangVien>.Update(gv);
            }
            return Json(ModelState.ToDataSourceResult());
        }

        public JsonResult AjaxReadData([DataSourceRequest] DataSourceRequest request)
        {
            var result = DataProvider<GiangVien>.GetAll(x => x.UserProfile);
            return Json(result.ToDataSourceResult(request, gv => new GiangVienViewModel()
            {
                ChuyenNganh = gv.ChuyenNganh,
                CoThePhanCong = gv.CoThePhanCong,
                MaGv = gv.MaGv,
                HoVaTen = gv.HoVaTen,
                TaiKhoan = gv.UserProfile != null ? gv.UserProfile.UserName : null,
            }));
        }

        
        [AcceptVerbs(HttpVerbs.Post)]
        [InitializeSimpleMembership]
        public ActionResult AjaxCreate([DataSourceRequest] DataSourceRequest request, GiangVienViewModel gv)
        {
            if (gv != null && ModelState.IsValid)
            {
                string userName = StaticUltils.GetUsername(gv.HoVaTen);
                if (DataProvider<UserProfile>.GetAll().Any(x => x.UserName == userName))
                {
                    ModelState.AddModelError("", "Tên đăng nhập đã tồn tại");
                    return Json(new[] { gv }.ToDataSourceResult(request, ModelState));
                }
                if (AccountController.TaoTaiKhoan(new RegisterModel()
                    {
                        UserName = userName,
                        Password = "123456",
                        Roles = "Teacher",
                        MaGv = gv.MaGv
                    }))
                {
                    var g = new GiangVien()
                    {
                        ChuyenNganh = gv.ChuyenNganh,
                        CoThePhanCong = gv.CoThePhanCong,
                        MaGv = gv.MaGv.ToUpper(),
                        HoVaTen = gv.HoVaTen,
                    };
                    DataProvider<GiangVien>.Add(g);
                    var up = DataProvider<UserProfile>.GetSingle(x => x.MaGv == gv.MaGv);
                    g.UserProfile = up;
                    g.UserProfileId = up.UserId;
                    DataProvider<GiangVien>.Update(g);
                }
            }
            return Json(new[] { gv }.ToDataSourceResult(request, ModelState));
        }
    }
}
