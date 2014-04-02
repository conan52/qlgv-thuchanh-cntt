using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using TkbThucHanh.Models;

namespace TkbThucHanh.Controllers
{
    public class LichCongTacController : Controller
    {
        //
        // GET: /LichCongTac/

        private readonly TkbThucHanhContext db = new TkbThucHanhContext();

        public ActionResult Index()
        {
            return View();
        }

        [ValidateInput(false)]
        public ActionResult GridViewPartial()
        {
            DbSet<LichCongTac> model = db.LichCongTacs;
            return PartialView("_GridViewPartial", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialAddNew(LichCongTac item)
        {
            DbSet<LichCongTac> model = db.LichCongTacs;
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
        public ActionResult GridViewPartialUpdate(LichCongTac item)
        {
            DbSet<LichCongTac> model = db.LichCongTacs;
            if (ModelState.IsValid)
            {
                try
                {
                    LichCongTac modelItem = model.FirstOrDefault(it => it.LichCongTacId == item.LichCongTacId);
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
        public ActionResult GridViewPartialDelete(Int32 LichCongTacId)
        {
            DbSet<LichCongTac> model = db.LichCongTacs;
            if (LichCongTacId != null)
            {
                try
                {
                    LichCongTac item = model.FirstOrDefault(it => it.LichCongTacId == LichCongTacId);
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