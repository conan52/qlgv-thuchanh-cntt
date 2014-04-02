using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace TkbThucHanh.Controllers
{
    public class LichCongTacController : Controller
    {
        //
        // GET: /LichCongTac/

        public ActionResult Index()
        {
            return View();
        }

        TkbThucHanh.Models.TkbThucHanhContext db = new TkbThucHanh.Models.TkbThucHanhContext();

        [ValidateInput(false)]
        public ActionResult GridViewPartial()
        {
            var model = db.LichCongTacs;
            return PartialView("_GridViewPartial", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialAddNew(TkbThucHanh.Models.LichCongTac item)
        {
            var model = db.LichCongTacs;
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
        public ActionResult GridViewPartialUpdate(TkbThucHanh.Models.LichCongTac item)
        {
            var model = db.LichCongTacs;
            if (ModelState.IsValid)
            {
                try
                {
                    var modelItem = model.FirstOrDefault(it => it.LichCongTacId == item.LichCongTacId);
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
        public ActionResult GridViewPartialDelete(System.Int32 LichCongTacId)
        {
            var model = db.LichCongTacs;
            if (LichCongTacId != null)
            {
                try
                {
                    var item = model.FirstOrDefault(it => it.LichCongTacId == LichCongTacId);
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
