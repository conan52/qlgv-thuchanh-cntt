using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace TkbThucHanh.Controllers
{
    public class GiangVienController : Controller
    {
        //
        // GET: /GiangVien/

        public ActionResult Index()
        {
            return View();
        }

        TkbThucHanh.Models.TkbThucHanhContext db = new TkbThucHanh.Models.TkbThucHanhContext();

        [ValidateInput(false)]
        public ActionResult GridViewPartial()
        {
            var model = db.GiangViens;
            return PartialView("_GridViewPartial", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialAddNew(TkbThucHanh.Models.GiangVien item)
        {
            var model = db.GiangViens;
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
        public ActionResult GridViewPartialUpdate(TkbThucHanh.Models.GiangVien item)
        {
            var model = db.GiangViens;
            if (ModelState.IsValid)
            {
                try
                {
                    var modelItem = model.FirstOrDefault(it => it.GiangVienId == item.GiangVienId);
                    if (modelItem != null)
                    {
                        this.UpdateModel(modelItem);
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
        public ActionResult GridViewPartialDelete(System.Int32 GiangVienId)
        {
            var model = db.GiangViens;
            if (GiangVienId != null)
            {
                try
                {
                    var item = model.FirstOrDefault(it => it.GiangVienId == GiangVienId);
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
