using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DluWebHelper;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using TkbThucHanhCNTT.Models;
using TkbThucHanhCNTT.Models.Provider;
using TkbThucHanhCNTT.Models.Ultils;
using TkbThucHanhCNTT.Models.Viewer;

namespace TkbThucHanhCNTT.Controllers
{
//    [Authorize(Roles = "AdminTeacher")]
    public class TuanHocController : Controller
    {
        //
        // GET: /TuanHoc/

        public ActionResult Index()
        {
            return View();
        }


        public JsonResult AjaxReadData([DataSourceRequest] DataSourceRequest request)
        {
            var result = DataProvider<TuanHoc>.GetAll()
                .Select(t=>new TuanHocViewModel()
                {
                    DaLayThongTin = t.DaLayThongTin,
                    SttTuan = t.SttTuan,
                    DaXepLichThucHanh = t.DaXepLichThucHanh,
                    NgayBatDau = t.NgayBatDau,
                    NgayKetThuc = t.NgayKetThuc
                })
                .OrderBy(t => t.SttTuan);
            return Json(result.ToDataSourceResult(request));
        }

        
        public JsonResult AjaxInitWeek(int week, string dateOfWeek)
        {
            try
            {
                var thls = new List<TuanHoc>();
                var startDay = DateTime.ParseExact(dateOfWeek, "dd/MM/yyyy", null).AddDays((week - 1) * -7).Monday();

                for (var i = 1; i < 54; i++)
                {
                    var th = new TuanHoc
                    {
                        DaLayThongTin = false,
                        DaXepLichThucHanh = false,
                        NgayBatDau = startDay,
                        SttTuan = i
                    };
                    thls.Add(th);
                    startDay = startDay.AddDays(7);
                }
                DataProvider<TuanHoc>.RemoveAll();
                DataProvider<TuanHoc>.Add(thls);

                return Json(new { Result = "OK" });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "Fail", ex.Message });
            }
        }

        
        public JsonResult AjaxSyncWeek()
        {
            try
            {
                DluWebRequest request = new DluWebRequest();
                var result = request.GetCurentTimeTable();
                

                var thls = new List<TuanHoc>();
                var startDay = result.StartDate.AddDays((result.CurrentWeek - 1) * -7).Monday();

                for (var i = 1; i < 54; i++)
                {
                    var th = new TuanHoc
                    {
                        DaLayThongTin = false,
                        DaXepLichThucHanh = false,
                        NgayBatDau = startDay,
                        SttTuan = i
                    };
                    thls.Add(th);
                    startDay = startDay.AddDays(7);
                }
                DataProvider<TuanHoc>.RemoveAll();
                DataProvider<TuanHoc>.Add(thls);

                return Json(new { Result = "OK" });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "Fail", ex.Message });
            }
        }

         
        public JsonResult AjaxClearWeek()
        {
            try
            {
                DataProvider<TuanHoc>.RemoveAll();
                return Json(new { Result = "OK" });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "Fail", ex.Message });
            }
        }

       

    }
}
