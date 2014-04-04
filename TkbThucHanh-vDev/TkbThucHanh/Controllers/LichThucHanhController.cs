using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
using DevExpress.XtraReports.Data;
using TkbThucHanh.Models;
using TkbThucHanh.Models.Provider;
using TkbThucHanh.Models.Viewer;

namespace TkbThucHanh.Controllers
{
    [Authorize(Roles = "AdminTeacher,Admin")]
    public class LichThucHanhController : Controller
    {
        //
        // GET: /ThoiKhoaBieuThucHanh/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CapNhatLichThucHanh()
        {
            var tuans = ThoiKhoaBieuProvider.LayTuanChuaXepLichThucHanh();

            if (tuans.Count > 0)
            {
                var tkbgv = DataProvider<TkbGiangVien>.GetAll();
                var dsPhongTh = DataProvider<PhongThucHanh>.GetAll();

                var tkb = from t in tkbgv
                          join phongThucHanh in dsPhongTh on t.Phong equals phongThucHanh.TenPhong
                          join tuanHoc in tuans on t.TuanHoc equals tuanHoc.SttTuan
                          select t;
                

                return Json(new { Status = 1, Result = 0 }, JsonRequestBehavior.AllowGet);
            }
            return Json(new { Status = 0 }, JsonRequestBehavior.AllowGet);
        }




        TkbThucHanhContext db = new TkbThucHanhContext();

        [ValidateInput(false)]
        public ActionResult GridViewPartial()
        {
            var model = LichThucHanhProvider.LayDsTongQuan();
            return PartialView("_GridViewPartial", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialAddNew(LichThucHanhTongQuan item)
        {
            var model = LichThucHanhProvider.LayDsTongQuan();
            if (ModelState.IsValid)
            {
                try
                {
                    model.Add(item);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("_GridViewPartial", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialUpdate(LichThucHanhTongQuan item)
        {
            var model = LichThucHanhProvider.LayDsTongQuan();
            if (ModelState.IsValid)
            {
                try
                {
                    var modelItem = model.FirstOrDefault(it => it.TkbThucHanhId == item.TkbThucHanhId);
                    if (modelItem != null)
                    {
                        UpdateModel(modelItem);
                        db.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            else
                ViewData["EditError"] = "Please, correct all errors.";
            return PartialView("_GridViewPartial", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialDelete(Int32 TkbThucHanhId)
        {
            var model = LichThucHanhProvider.LayDsTongQuan();
            if (TkbThucHanhId != null)
            {
                try
                {
                    var item = model.FirstOrDefault(it => it.TkbThucHanhId == TkbThucHanhId);
                    if (item != null)
                        model.Remove(item);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    ViewData["EditError"] = e.Message;
                }
            }
            return PartialView("_GridViewPartial", model.ToList());
        }
    }
}
