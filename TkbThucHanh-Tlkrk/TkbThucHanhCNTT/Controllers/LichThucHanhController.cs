using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using Kendo.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using NPOI.HSSF.UserModel;
using NPOI.HSSF.Util;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using TkbThucHanhCNTT.Models;
using TkbThucHanhCNTT.Models.Enums;
using TkbThucHanhCNTT.Models.Provider;
using TkbThucHanhCNTT.Models.Ultils;

namespace TkbThucHanhCNTT.Controllers
{
    [Authorize(Roles = "AdminTeacher, Teacher, Admin")]
    public class LichThucHanhController : Controller
    {
        //
        // GET: /LichThucHanh/
        [Authorize(Roles = "AdminTeacher, Admin")]
        public ActionResult Index()
        {
            ViewData["GiangViens"] = DataProvider<GiangVien>.GetList(gv => gv.CoThePhanCong).Select(gv => new {gv.HoVaTen, gv.MaGv});
            ViewData["MonHocs"] = DataProvider<MonHoc>.GetAll().Select(t => new {t.TenMonHoc, t.MaMonHoc, t.TenThucHanh, t.MonHocId});
            ViewData["Lops"] = DataProvider<Lop>.GetAll().Select(l => new {l.TenLop});
            ViewData["Phongs"] = DataProvider<PhongThucHanh>.GetAll().Select(p => new {p.TenPhong});
            ViewData["TuanCoTkb"] = DataProvider<TuanHoc>.GetList(t => t.LichThucHanhs.Any(), t => t.LichThucHanhs).Select(t => t.SttTuan);
            ViewData["TuanChuaCoTkb"] = DataProvider<TuanHoc>.GetList(t => !t.LichThucHanhs.Any() && t.NgayKetThuc >= DateTime.Now, t => t.LichThucHanhs).Select(t => t.SttTuan);
            ViewData["TuanGanNhat"] = LayTuanGanNhat();

            IList<TuanHoc> dsTuan = DataProvider<TuanHoc>.GetAll();
            ViewData["Tuans"] = dsTuan.Select(t => new {t.SttTuan});
            if (dsTuan.Any(t => t.NgayBatDau > DateTime.Now))
                ViewData["TuanMoiNhat"] = dsTuan.First(t => t.NgayBatDau > DateTime.Now).SttTuan;
            else
                ViewData["TuanMoiNhat"] = 0;

            return View();
        }


        public ActionResult LayTuanChuaCoTkb([DataSourceRequest] DataSourceRequest request)
        {
            IOrderedEnumerable<int> dsTuan =
                DataProvider<TuanHoc>.GetList(t => !t.LichThucHanhs.Any() && t.NgayKetThuc >= DateTime.Now, t => t.LichThucHanhs).Select(t => t.SttTuan)
                    .OrderByDescending(t => t);
            return Json(dsTuan, JsonRequestBehavior.AllowGet);
        }


        public ActionResult LayTuanCoTkb([DataSourceRequest] DataSourceRequest request)
        {
            IOrderedEnumerable<int> dsTuan =
                DataProvider<TuanHoc>.GetList(t => t.LichThucHanhs.Any(), t => t.LichThucHanhs).Select(t => t.SttTuan)
                    .OrderByDescending(t => t);
            return Json(dsTuan, JsonRequestBehavior.AllowGet);
        }


        public ActionResult LichThucHanhGV()
        {
            ViewData["GiangViens"] = DataProvider<GiangVien>.GetList(gv => gv.CoThePhanCong).Select(gv => new {gv.HoVaTen, gv.MaGv});
            ViewData["MonHocs"] = DataProvider<MonHoc>.GetAll().Select(t => new {t.TenMonHoc, t.MaMonHoc, t.TenThucHanh, t.MonHocId});
            ViewData["Lops"] = DataProvider<Lop>.GetAll().Select(l => new {l.TenLop});
            ViewData["Phongs"] = DataProvider<PhongThucHanh>.GetAll().Select(p => new {p.TenPhong});
            ViewData["TuanCoTkb"] = DataProvider<TuanHoc>.GetList(t => t.LichThucHanhs.Any(), t => t.LichThucHanhs).Select(t => t.SttTuan);
            ViewData["TuanChuaCoTkb"] = DataProvider<TuanHoc>.GetList(t => !t.LichThucHanhs.Any() && t.NgayKetThuc >= DateTime.Now, t => t.LichThucHanhs).Select(t => t.SttTuan);
            ViewData["TuanGanNhat"] = LayTuanGanNhat();

            IList<TuanHoc> dsTuan = DataProvider<TuanHoc>.GetAll();
            ViewData["Tuans"] = dsTuan.Select(t => new {t.SttTuan});
            if (dsTuan.Any(t => t.NgayBatDau > DateTime.Now))
                ViewData["TuanMoiNhat"] = dsTuan.First(t => t.NgayBatDau > DateTime.Now).SttTuan;
            else
                ViewData["TuanMoiNhat"] = 0;

            return View();
        }


        public ActionResult LayDsTuan([DataSourceRequest] DataSourceRequest request)
        {
            IOrderedEnumerable<int> dsTuan =
                DataProvider<TuanHoc>.GetList(t => t.LichThucHanhs != null && t.LichThucHanhs.Count > 0)
                    .Select(t => t.SttTuan)
                    .OrderByDescending(t => t);
            return Json(dsTuan, JsonRequestBehavior.AllowGet);
        }

        [Authorize(Roles = "AdminTeacher, Teacher")]
        public JsonResult AjaxReadData_Limit([DataSourceRequest] DataSourceRequest request)
        {
            if (!request.Filters.Any())
            {
                request.Filters.Add(new FilterDescriptor("SttTuan", FilterOperator.IsEqualTo, LayTuanGanNhat()));
            }

            IOrderedEnumerable<LichThucHanh> result = DataProvider<LichThucHanh>.GetAll(l => l.MonHoc, l => l.GiangVien1, l => l.GiangVien2, l => l.GiangVien3)
                .OrderByDescending(t => t.SttTuan)
                .ThenBy(t => t.NgayTrongTuan)
                .ThenBy(t => t.TietBatDau)
                .ThenBy(t => t.TietKetThuc)
                .ThenBy(t => t.MonHocId);
            string maGv = StaticValue.MaGv;
            IEnumerable<LichThucHanh> r = result.Where(l => l.Gvhd1 != null && l.Gvhd1.Equals(maGv, StringComparison.CurrentCultureIgnoreCase) ||
                                                            l.Gvhd2 != null && l.Gvhd2.Equals(maGv, StringComparison.CurrentCultureIgnoreCase) ||
                                                            l.Gvhd3 != null && l.Gvhd3.Equals(maGv, StringComparison.CurrentCultureIgnoreCase));
            return Json(r.ToDataSourceResult(request, l => new
            {
                l.MaLichTh,
                l.TenLop,
                l.TenPhong,
                l.MonHocId,
                l.NgayTrongTuan,
                l.SttTuan,
                l.TietBatDau,
                l.TietKetThuc,
                l.Gvhd1,
                l.Gvhd2,
                l.Gvhd3,
                l.Gv1CoMat,
                l.Gv2CoMat,
                l.Gv3CoMat,
                l.Vang,
                l.GhiChu,
                l.MonHoc.TenThucHanh,
                TenGv1 = l.Gvhd1 != null ? l.GiangVien1.HoVaTen : null,
                TenGv2 = l.Gvhd2 != null ? l.GiangVien2.HoVaTen : null,
                TenGv3 = l.Gvhd3 != null ? l.GiangVien3.HoVaTen : null
            }), JsonRequestBehavior.AllowGet);
        }

        [Authorize(Roles = "AdminTeacher, Admin")]
        public JsonResult AjaxReadData([DataSourceRequest] DataSourceRequest request)
        {
            if (!request.Filters.Any())
            {
                request.Filters.Add(new FilterDescriptor("SttTuan", FilterOperator.IsEqualTo, LayTuanGanNhat()));
            }


            IOrderedEnumerable<LichThucHanh> result = DataProvider<LichThucHanh>.GetAll(l => l.MonHoc, l => l.GiangVien1, l => l.GiangVien2, l => l.GiangVien3)
                .OrderByDescending(t => t.SttTuan)
                .ThenBy(t => t.NgayTrongTuan)
                .ThenBy(t => t.TietBatDau)
                .ThenBy(t => t.TietKetThuc)
                .ThenBy(t => t.MonHocId);
            return Json(result.ToDataSourceResult(request, l => new
            {
                l.MaLichTh,
                l.TenLop,
                l.TenPhong,
                l.MonHocId,
                l.NgayTrongTuan,
                l.SttTuan,
                l.TietBatDau,
                l.TietKetThuc,
                l.Gvhd1,
                l.Gvhd2,
                l.Gvhd3,
                l.Gv1CoMat,
                l.Gv2CoMat,
                l.Gv3CoMat,
                l.Vang,
                l.GhiChu,
                l.MonHoc.TenThucHanh,
                TenGv1 = l.Gvhd1 != null ? l.GiangVien1.HoVaTen : null,
                TenGv2 = l.Gvhd2 != null ? l.GiangVien2.HoVaTen : null,
                TenGv3 = l.Gvhd3 != null ? l.GiangVien3.HoVaTen : null
            }));
        }

        [Authorize(Roles = "AdminTeacher, Admin")]
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult AjaxUpdate([DataSourceRequest] DataSourceRequest request, [Bind(Prefix = "models")] IEnumerable<LichThucHanh> ls)
        {
            var results = new List<LichThucHanh>();

            if (ls != null && ModelState.IsValid)
            {
                foreach (LichThucHanh l in ls)
                {
                    if (l != null && ModelState.IsValid)
                    {
                        if (l.Gvhd2 != null && (l.Gvhd2.Length <= 2 || l.Gvhd2.Contains("]")))
                            l.Gvhd2 = null;
                        if (l.Gvhd3 != null && (l.Gvhd3.Length <= 2 || l.Gvhd3.Contains("]")))
                            l.Gvhd3 = null;
                        results.Add(l);
                    }
                }
            }
            DataProvider<LichThucHanh>.Update(results);
            return Json(results.ToDataSourceResult(request, ModelState));
        }

        [Authorize(Roles = "AdminTeacher, Admin")]
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult AjaxCreate([DataSourceRequest] DataSourceRequest request, [Bind(Prefix = "models")] IEnumerable<LichThucHanh> ls)
        {
            var results = new List<LichThucHanh>();

            if (ls != null && ModelState.IsValid)
            {
                foreach (LichThucHanh l in ls)
                {
                    if (l != null && ModelState.IsValid)
                    {
                        l.Gv1CoMat = l.Gv2CoMat = l.Gv3CoMat = true;
                        if (l.Gvhd2 != null && l.Gvhd2.Length <= 2)
                            l.Gvhd2 = null;
                        if (l.Gvhd3 != null && l.Gvhd3.Length <= 2)
                            l.Gvhd3 = null;
                        results.Add(l);
                    }
                }
            }
            DataProvider<LichThucHanh>.Add(results);
            return Json(results.ToDataSourceResult(request, ModelState));
        }

        [Authorize(Roles = "AdminTeacher, Admin")]
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult AjaxDelete([DataSourceRequest] DataSourceRequest request, [Bind(Prefix = "models")] IEnumerable<LichThucHanh> ls)
        {
            List<LichThucHanh> results = ls.ToList();
            DataProvider<LichThucHanh>.Remove(results);
            return Json(results.ToDataSourceResult(request, ModelState));
        }

        [Authorize(Roles = "AdminTeacher, Admin")]
        public JsonResult DongBoLichThucHanh()
        {
            try
            {
                IList<PhanCongGiangDay> phancong = DataProvider<PhanCongGiangDay>.GetAll(p => p.MonHoc);
                IList<PhongThucHanh> phongTh = DataProvider<PhongThucHanh>.GetAll();
                IList<TkbGiangVien> tkbgv = DataProvider<TkbGiangVien>.GetList(t => !t.TuanHoc.DaXepLichThucHanh && phongTh.Any(p => p.TenPhong == t.Phong), t => t.TuanHoc);

                int n = 0;
                foreach (TkbGiangVien tkb in tkbgv)
                {
                    try
                    {
                        var lichTh = new LichThucHanh
                        {
                            SttTuan = tkb.SttTuan,
                            NgayTrongTuan = tkb.NgayTrongTuan,
                            TenLop = tkb.LopHoc,
                            TietBatDau = tkb.TietBatDau,
                            TietKetThuc = tkb.TietKetThuc,
                            Gvhd1 = tkb.MaGv,
                            //GhiChu = tkb.TenMonHoc,
                            TenPhong = tkb.Phong,
                            Gv1CoMat = true,
                            Gv2CoMat = true,
                            Gv3CoMat = true
                        };

                        PhanCongGiangDay pc = phancong.SingleOrDefault(p => p.MonHoc.TenThucHanh.RemoveCase().StartsWith(tkb.TenMonHoc.RemoveCase()) && p.TenLop == tkb.LopHoc);

                        if (pc != null)
                        {
                            lichTh.MonHocId = pc.MonHocId;

                            DataProvider<LichThucHanh>.Add(lichTh);
                            DataProvider<TkbGiangVien>.Remove(tkb);
                            n++;
                        }
                        else
                        {
                            Debug.WriteLine("{0}\t{1}\t{2}", tkb.TenMonHoc, tkb.MaGv, tkb.LopHoc);
                            throw new FormatException("Không nhận dạng được môn học hoặc không có trong phân công");
                        }
                    }
                    catch (FormatException)
                    {
                        Console.Beep();
                    }
                    catch (Exception)
                    {
                    }
                }

                return Json(new {Result = "OK", Message = n});
            }
            catch (Exception ex)
            {
                return Json(new {Result = "Fail", ex.Message});
            }
        }


        public JsonResult DiemDanhGv(int lichHocId, bool gv1, bool gv2, bool gv3)
        {
            try
            {
                LichThucHanh lichTh = DataProvider<LichThucHanh>.GetSingle(l => l.MaLichTh == lichHocId);
                lichTh.Gv1CoMat = gv1;
                lichTh.Gv2CoMat = gv2;
                lichTh.Gv3CoMat = gv3;

                DataProvider<LichThucHanh>.Update(lichTh);
                return Json(new {Result = "OK"});
            }
            catch (Exception ex)
            {
                return Json(new {Result = "Fail", ex.Message});
            }
        }

        [Authorize(Roles = "AdminTeacher, Admin")]
        public JsonResult SaoChepLich(int tuTuan, int denTuan)
        {
            try
            {
                IList<LichThucHanh> dsLichCanChep = DataProvider<LichThucHanh>.GetList(l => l.SttTuan == tuTuan);
                var result = new List<LichThucHanh>();

                foreach (LichThucHanh lth in dsLichCanChep)
                {
                    var l = new LichThucHanh
                    {
                        Gv1CoMat = true,
                        Gv2CoMat = true,
                        Gv3CoMat = true,
                        Gvhd1 = lth.Gvhd1,

                        // Gvhd2 = lth.Gvhd2 ?? null,
                        // Gvhd3 = lth.Gvhd3 ?? null,
                        MonHocId = lth.MonHocId,
                        NgayTrongTuan = lth.NgayTrongTuan,
                        SttTuan = denTuan,
                        TenLop = lth.TenLop,
                        TenPhong = lth.TenPhong,
                        TietBatDau = lth.TietBatDau,
                        TietKetThuc = lth.TietKetThuc
                    };

                    l.Gvhd2 = lth.Gvhd2 != null && FilterController.GvRanh(lth.Gvhd2, denTuan, lth.NgayTrongTuan, lth.TietBatDau, lth.TietKetThuc) ? lth.Gvhd2 : null;
                    l.Gvhd3 = lth.Gvhd3 != null && FilterController.GvRanh(lth.Gvhd3, denTuan, lth.NgayTrongTuan, lth.TietBatDau, lth.TietKetThuc) ? lth.Gvhd3 : null;

                    result.Add(l);
                }
                DataProvider<LichThucHanh>.Add(result);

                return Json(new {Result = "OK", Message = result.Count});
            }
            catch (Exception ex)
            {
                return Json(new {Result = "Fail", ex.Message});
            }
        }

        [Authorize(Roles = "AdminTeacher, Admin")]
        public JsonResult TuPhanCong(int chonTuan)
        {
            try
            {
                IList<LichThucHanh> all = DataProvider<LichThucHanh>.GetAll();
                List<LichThucHanh> dsLichCanChep = all.Where(l => l.SttTuan == chonTuan).ToList();
                foreach (LichThucHanh lth in dsLichCanChep)
                {
                    IEnumerable<string> dsGvRanh = FilterController.LayDsGvRanh(lth.SttTuan, lth.NgayTrongTuan, lth.TietBatDau, lth.TietKetThuc);
                    if (lth.Gvhd1 == null)
                    {
                        IEnumerable<string> lt = all.Where(l => l.MonHocId == lth.MonHocId && l.TenLop == lth.TenLop && l.Gvhd1 != null)
                            .Select(l => l.Gvhd1).Intersect(dsGvRanh);
                        if (lt.Any())
                            lth.Gvhd1 = lt.First();
                        else
                            continue;
                    }
                    if (lth.Gvhd2 == null)
                    {
                        IEnumerable<string> lt = all.Where(l => l.MonHocId == lth.MonHocId && l.TenLop == lth.TenLop && l.Gvhd2 != null)
                            .Select(l => l.Gvhd2).Intersect(dsGvRanh);
                        if (lt.Any())
                            lth.Gvhd2 = lt.First();
                    }
                    if (lth.Gvhd3 == null)
                    {
                        IEnumerable<string> lt = all.Where(l => l.MonHocId == lth.MonHocId && l.TenLop == lth.TenLop && l.Gvhd3 != null)
                            .Select(l => l.Gvhd3).Intersect(dsGvRanh);
                        if (lt.Any())
                            lth.Gvhd3 = lt.First();
                    }
                }
                DataProvider<LichThucHanh>.Update(dsLichCanChep);

                return Json(new {Result = "OK", Message = dsLichCanChep.Count});
            }
            catch (Exception ex)
            {
                return Json(new {Result = "Fail", ex.Message});
            }
        }

        private int LayTuanGanNhat()
        {
            IOrderedEnumerable<TuanHoc> dsTuan = DataProvider<TuanHoc>.GetList(t => t.LichThucHanhs.Any()).OrderBy(t => Math.Abs((DateTime.Now - t.NgayBatDau).TotalHours));
            if (dsTuan.Any())
                return dsTuan.First().SttTuan;
            return 0;
        }


        public ActionResult XuatExcel(int tuanXuat)
        {
            List<LichThucHanh> lth = DataProvider<LichThucHanh>.GetList(l => l.SttTuan == tuanXuat, l => l.MonHoc, l => l.GiangVien1, l => l.GiangVien2, l => l.GiangVien3, l => l.TuanHoc)
                .OrderBy(l => l.SttTuan)
                .ThenBy(l => (int) l.NgayTrongTuan)
                .ToList();


            var workbook = new HSSFWorkbook();
            ISheet sheet = workbook.CreateSheet("Tuan" + tuanXuat);
            int numRow = 0;
            ICellStyle blackBorder = workbook.CreateCellStyle();
            blackBorder.BorderBottom = BorderStyle.Thin;
            blackBorder.BorderLeft = BorderStyle.Thin;
            blackBorder.BorderRight = BorderStyle.Thin;
            blackBorder.BorderTop = BorderStyle.Thin;
            blackBorder.BottomBorderColor = HSSFColor.Black.Index;
            blackBorder.LeftBorderColor = HSSFColor.Black.Index;
            blackBorder.RightBorderColor = HSSFColor.Black.Index;
            blackBorder.TopBorderColor = HSSFColor.Black.Index;

            blackBorder.FillPattern = FillPattern.SolidForeground;
            blackBorder.FillForegroundColor = HSSFColor.Grey40Percent.Index;
            blackBorder.FillBackgroundColor = HSSFColor.Grey40Percent.Index;


            AddRow(ref numRow, "TRƯỜNG ĐẠI HỌC ĐÀ LẠT", sheet, 3);
            AddRow(ref numRow, "KHOA CNTT", sheet, 3);
            AddRow(ref numRow, string.Format("Lịch hướng dẫn thực hành tuần {0}", tuanXuat), sheet, 10, 15);
            AddRow(ref numRow, string.Format("Từ ngày {0} đến ngày {1}", lth.First().TuanHoc.NgayBatDau.ToString("dd/MM/yyyy"), lth.First().TuanHoc.NgayKetThuc.ToString("dd/MM/yyyy")), sheet, 10);

            numRow++;

            var columns = new[] {"Thứ", "Tiết", "Tên môn học", "Lớp", "Phòng", "GVHD 1", "GVHD 2", "GVHD 3", "Ghi chú", "GV vắng"};
            IRow headerRow = sheet.CreateRow(numRow++);


            //create header
            for (int i = 0; i < columns.Length; i++)
            {
                ICell cell = headerRow.CreateCell(i);
                cell.SetCellValue(columns[i]);
                //  cell.CellStyle=


                IFont font = workbook.CreateFont();

                font.FontHeightInPoints = 11;
                font.FontName = "Calibri";
                font.Boldweight = (short) FontBoldWeight.Bold;
                cell.CellStyle = blackBorder;
                cell.CellStyle.SetFont(font);
            }
            sheet.SetColumnWidth(0, 10*256);
            sheet.SetColumnWidth(1, 10*256);
            sheet.SetColumnWidth(2, 30*256);
            sheet.SetColumnWidth(3, 10*256);
            sheet.SetColumnWidth(4, 10*256);
            sheet.SetColumnWidth(5, 15*256);
            sheet.SetColumnWidth(6, 15*256);
            sheet.SetColumnWidth(7, 15*256);
            sheet.SetColumnWidth(8, 30*256);
            sheet.SetColumnWidth(9, 30*256);


            // fill content 

            ICellStyle cellBorder = workbook.CreateCellStyle();
            cellBorder.BorderBottom = BorderStyle.Thin;
            cellBorder.BorderLeft = BorderStyle.Thin;
            cellBorder.BorderRight = BorderStyle.Thin;
            cellBorder.BorderTop = BorderStyle.Thin;
            cellBorder.BottomBorderColor = HSSFColor.Black.Index;
            cellBorder.LeftBorderColor = HSSFColor.Black.Index;
            cellBorder.RightBorderColor = HSSFColor.Black.Index;
            cellBorder.TopBorderColor = HSSFColor.Black.Index;


            for (int i = 0; i < lth.Count; i++)
            {
                IRow row = sheet.CreateRow(numRow);

                if (i > 0 && lth[i].NgayTrongTuan == lth[i - 1].NgayTrongTuan)
                {
                    SetValue(row, lth[i], cellBorder, true);
                    sheet.AddMergedRegion(new CellRangeAddress(numRow - 1, numRow, 0, 0));
                }
                else
                {
                    SetValue(row, lth[i], cellBorder);
                }
                numRow++;
            }

            var stream = new MemoryStream();
            workbook.Write(stream);
            stream.Close();

            return File(stream.ToArray(), "application/vnd.ms-excel", "LichThucHanhTuan" + tuanXuat);
        }


        private void AddRow(ref int numRow, string context, ISheet sheet, int colSpan = 1, short size = 13)
        {
            IFont font = sheet.Workbook.CreateFont();
            font.Color = HSSFColor.Black.Index;

            //font.Boldweight = Boldweight;
            font.FontHeightInPoints = size;

            //bind font with style 1
            ICellStyle style = sheet.Workbook.CreateCellStyle();
            style.Alignment = HorizontalAlignment.Center;
            style.SetFont(font);

            sheet.AddMergedRegion(new CellRangeAddress(numRow, numRow, 0, colSpan - 1));
            ICell cell = sheet.CreateRow(numRow++).CreateCell(0);

            cell.SetCellValue(context);
            cell.CellStyle = style;
        }

        private void SetValue(IRow row, LichThucHanh l, ICellStyle style, bool merge = false)
        {
            if (merge)
                AddBlank(row);
            else
                AddCell(row, l.NgayTrongTuan.GetDescriptionAttribute(), style);
            AddCell(row, string.Format("{0} - {1}", l.TietBatDau, l.TietKetThuc), style);
            AddCell(row, l.MonHoc.TenThucHanh, style);
            AddCell(row, l.TenLop, style);
            AddCell(row, l.TenPhong, style);
            AddCell(row, l.GiangVien1 != null ? l.GiangVien1.TenNganGon : "", style);
            AddCell(row, l.GiangVien2 != null ? l.GiangVien2.TenNganGon : "", style);
            AddCell(row, l.GiangVien3 != null ? l.GiangVien3.TenNganGon : "", style);
            AddCell(row, l.GhiChu, style);
            AddCell(row, l.Vang, style);
        }

        private void AddBlank(IRow row)
        {
            ICell cell = row.CreateCell(row.Cells.Count);
        }

        private void AddCell(IRow row, string value, ICellStyle style)
        {
            ICell cell = row.CreateCell(row.Cells.Count);
            cell.SetCellValue(value);

            cell.CellStyle = style;
        }
    }
}