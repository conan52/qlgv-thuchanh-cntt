using System.Web.Mvc;
using TKBThucHanh.Models;

namespace TKBThucHanh.Controllers
{
    public class GiangVienController : Controller
    {
        public ActionResult Index()
        {
            var db = new TkbThucHanhContext();
            return View(db.GiangViens);
        }

    }
}
