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

        TKBThucHanh.Models.TkbThucHanhContext db = new TKBThucHanh.Models.TkbThucHanhContext();

        [ValidateInput(false)]
        public ActionResult GridView1Partial()
        {
            var model = db.GiangViens;
            return PartialView("_GridView1Partial", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult GridView1PartialAddNew(TKBThucHanh.Models.GiangVien item)
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
            return PartialView("_GridView1Partial", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridView1PartialUpdate(TKBThucHanh.Models.GiangVien item)
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
            return PartialView("_GridView1Partial", model.ToList());
        }
        [HttpPost, ValidateInput(false)]
        public ActionResult GridView1PartialDelete(System.Int32 GiangVienId)
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
            return PartialView("_GridView1Partial", model.ToList());
        }
        TKBThucHanh.Models.TkbThucHanhContext db1 = new TKBThucHanh.Models.TkbThucHanhContext();

        [ValidateInput(false)]
        public ActionResult GridViewPartial()
        {
            var model = db1.GiangViens;
            return PartialView("_GridViewPartial", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialAddNew(TKBThucHanh.Models.GiangVien item)
        {
            var model = db1.GiangViens;
            if (ModelState.IsValid)
            {
                try
                {
                    model.Add(item);
                    db1.SaveChanges();
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
        public ActionResult GridViewPartialUpdate(TKBThucHanh.Models.GiangVien item)
        {
            var model = db1.GiangViens;
            if (ModelState.IsValid)
            {
                try
                {
                    var modelItem = model.FirstOrDefault(it => it.GiangVienId == item.GiangVienId);
                    if (modelItem != null)
                    {
                        this.UpdateModel(modelItem);
                        db1.SaveChanges();
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
            var model = db1.GiangViens;
            if (GiangVienId != null)
            {
                try
                {
                    var item = model.FirstOrDefault(it => it.GiangVienId == GiangVienId);
                    if (item != null)
                        model.Remove(item);
                    db1.SaveChanges();
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
