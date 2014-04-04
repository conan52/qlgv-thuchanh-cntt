using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using TkbThucHanh.Models;

namespace TkbThucHanh.Controllers
{
    [Authorize(Roles = "AdminTeacher,Admin")]
    public class GiangVienController : Controller
    {
        //
        // GET: /GiangVien/

        private readonly TkbThucHanhContext db = new TkbThucHanhContext();

        public ActionResult Index()
        {
            return View();
        }

        [ValidateInput(false)]
        public ActionResult GridViewPartial()
        {
            DbSet<GiangVien> model = db.GiangViens;
            return PartialView("_GridViewPartial", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialAddNew(GiangVien item)
        {
            DbSet<GiangVien> model = db.GiangViens;
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
                ViewData["EditError"] = "Có lỗi xảy ra. Vui lòng xem chi tiết!.";
            return PartialView("_GridViewPartial", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialUpdate(GiangVien item)
        {
            DbSet<GiangVien> model = db.GiangViens;
            if (ModelState.IsValid)
            {
                try
                {
                    GiangVien modelItem = model.FirstOrDefault(it => it.MaGv == item.MaGv);
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
                ViewData["EditError"] = "Có lỗi xảy ra. Vui lòng xem chi tiết!.";
            return PartialView("_GridViewPartial", model.ToList());
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult GridViewPartialDelete(string mgv)
        {
            DbSet<GiangVien> model = db.GiangViens;
            if (mgv != null)
            {
                try
                {
                    GiangVien item = model.FirstOrDefault(it => it.MaGv == mgv);
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