using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
using DluWebHelper;
using TkbThucHanh.Models;
using TkbThucHanh.Models.Provider;

namespace TkbThucHanh.Controllers
{
    public class LichPhanCongThucHanhController : Controller
    {
        //
        // GET: /LichPhanCongThucHanh/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CapNhatTuLichGv()
        {
            var tkbgv = db.TkbGangViens.ToList();
            var tuans = db.TuanHocs.ToList();
            var result = (from tgv in tkbgv
                          join tuanHoc in tuans on tgv.TuanHoc equals tuanHoc.SttTuan
                          where tuanHoc.DaXepLichThucHanh == false
                          && tgv.TenMonHoc.StartsWith("TH")
                          select tgv).ToList();
            if (result.Count > 0)
            {
                var data = from t in result
                           select new LichThucHanh()
                           {
                               GhiChu = "",
                               GvVang = "",
                               TietBatDau = t.TietBatDau,
                               TietKetThuc = t.TietKetThuc,
                               NgayHoc = t.NgayHoc,
                               TuanHoc = t.TuanHoc,
                               TenMonHoc = t.TenMonHoc,
                               Phong = t.Phong,
                               MaGv1 = t.MaGv,
                               MaGv2 = "",
                               MaGv3 = "",
                               LopHoc = t.LopHoc
                           };
                DataProvider<LichThucHanh>.Add(data);
                return Json(new { Status = 1, Result = result.Count }, JsonRequestBehavior.AllowGet);
            }
            return Json(new { Status = 0 }, JsonRequestBehavior.AllowGet);
        }



        TkbThucHanhContext db = new TkbThucHanhContext();

        [ValidateInput(false)]
        public ActionResult GridViewPartial()
        {
            var model = db.LichThucHanhs;
            return PartialView("_GridViewPartial", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialAddNew(LichThucHanh item)
        {
            var model = db.LichThucHanhs;
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
        public ActionResult GridViewPartialUpdate(LichThucHanh item)
        {
            var model = db.LichThucHanhs;
            if (ModelState.IsValid)
            {
                try
                {
                    var modelItem = model.FirstOrDefault(it => it.TuanHoc == item.TuanHoc);
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
        public ActionResult GridViewPartialDelete(Int32 TuanHoc)
        {
            var model = db.LichThucHanhs;
            if (TuanHoc != null)
            {
                try
                {
                    var item = model.FirstOrDefault(it => it.TuanHoc == TuanHoc);
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
