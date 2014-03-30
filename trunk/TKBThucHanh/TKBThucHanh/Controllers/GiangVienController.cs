using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TkbThucHanh.Models;

namespace TKBThucHanh.Controllers
{
    public class GiangVienController : Controller
    {
        //
        // GET: /GiangVien/

        public ActionResult Index()
        {
            var db = new NckhContext();
            return View(db.GiangViens);
        }

    }
}
