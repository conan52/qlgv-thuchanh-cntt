using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TkbThucHanh.Models;

namespace TKBThucHanh.Controllers
{
    public class PhongHocController : Controller
    {

        //
        // GET: /PhongHoc/

        public ActionResult Index()
        {
            var db = new NckhContext();

            return View(db.Phongs.ToList());
        }


        [HttpGet]
        public ActionResult Delete(string id)
        {
            var db = new NckhContext();
            var ph = db.Phongs.SingleOrDefault(p => p.TenPhong.Equals(id));
            db.Phongs.Remove(ph);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
