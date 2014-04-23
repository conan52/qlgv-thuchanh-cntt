using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using TkbThucHanhCNTT.Models;
using TkbThucHanhCNTT.Models.Provider;
using TkbThucHanhCNTT.Models.Enums;
using NPOI.SS.Util;
using NPOI.HSSF.Util;

namespace TkbThucHanhCNTT.Controllers
{
    [Authorize(Roles = "AdminTeacher,Teacher")]
    public class LichThucHanhController : Controller
    {
        //
        // GET: /LichThucHanh/
        [Authorize(Roles = "AdminTeacher")]
        public ActionResult Index()
        {
            this.ViewData["GiangViens"] = DataProvider<GiangVien>.GetList(gv => gv.CoThePhanCong).Select(gv => new { gv.HoVaTen, gv.MaGv });
            this.ViewData["MonHocs"] = DataProvider<MonHoc>.GetAll().Select(t => new { t.TenMonHoc, t.MaMonHoc, t.TenThucHanh, t.MonHocId });
            this.ViewData["Lops"] = DataProvider<Lop>.GetAll().Select(l => new { l.TenLop });
            this.ViewData["Phongs"] = DataProvider<PhongThucHanh>.GetAll().Select(p => new { p.TenPhong });
            this.ViewData["TuanCoTkb"] = DataProvider<TuanHoc>.GetList(t => t.LichThucHanhs.Any(), t => t.LichThucHanhs).Select(t => t.SttTuan);
            this.ViewData["TuanChuaCoTkb"] = DataProvider<TuanHoc>.GetList(t => !t.LichThucHanhs.Any() && t.NgayKetThuc >= DateTime.Now, t => t.LichThucHanhs).Select(t => t.SttTuan);

            var dsTuan = DataProvider<TuanHoc>.GetAll();
            this.ViewData["Tuans"] = dsTuan.Select(t => new { t.SttTuan });
            if (dsTuan.Any(t => t.NgayBatDau > DateTime.Now))
                this.ViewData["TuanMoiNhat"] = dsTuan.First(t => t.NgayBatDau > DateTime.Now).SttTuan;
            else
                this.ViewData["TuanMoiNhat"] = 0;

            return this.View();
        }

        [Authorize(Roles = "Teacher")]
        public ActionResult LichThucHanhGV()
        {
            this.ViewData["GiangViens"] = DataProvider<GiangVien>.GetList(gv => gv.CoThePhanCong).Select(gv => new { gv.HoVaTen, gv.MaGv });
            this.ViewData["MonHocs"] = DataProvider<MonHoc>.GetAll().Select(t => new { t.TenMonHoc, t.MaMonHoc, t.TenThucHanh, t.MonHocId });
            this.ViewData["Lops"] = DataProvider<Lop>.GetAll().Select(l => new { l.TenLop });
            this.ViewData["Phongs"] = DataProvider<PhongThucHanh>.GetAll().Select(p => new { p.TenPhong });
            this.ViewData["TuanCoTkb"] = DataProvider<TuanHoc>.GetList(t => t.LichThucHanhs.Any(), t => t.LichThucHanhs).Select(t => t.SttTuan);
            this.ViewData["TuanChuaCoTkb"] = DataProvider<TuanHoc>.GetList(t => !t.LichThucHanhs.Any() && t.NgayKetThuc >= DateTime.Now, t => t.LichThucHanhs).Select(t => t.SttTuan);

            var dsTuan = DataProvider<TuanHoc>.GetAll();
            this.ViewData["Tuans"] = dsTuan.Select(t => new { t.SttTuan });
            if (dsTuan.Any(t => t.NgayBatDau > DateTime.Now))
                this.ViewData["TuanMoiNhat"] = dsTuan.First(t => t.NgayBatDau > DateTime.Now).SttTuan;
            else
                this.ViewData["TuanMoiNhat"] = 0;

            return this.View();
        }

            [Authorize(Roles = "AdminTeacher, Teacher")]
        public ActionResult LayDsTuan([DataSourceRequest]
                                      DataSourceRequest request)
        {
            var dsTuan =
                DataProvider<TuanHoc>.GetList(t => t.LichThucHanhs != null && t.LichThucHanhs.Count > 0)
                                     .Select(t => t.SttTuan)
                                     .OrderByDescending(t => t);
            return this.Json(dsTuan, JsonRequestBehavior.AllowGet);
        }

         [Authorize(Roles = "AdminTeacher, Teacher")]
        public JsonResult AjaxReadData_Limit([DataSourceRequest]
                                       DataSourceRequest request)
        {
            var result = DataProvider<LichThucHanh>.GetAll(l => l.MonHoc, l => l.GiangVien1, l => l.GiangVien2, l => l.GiangVien3)
                                                   .OrderByDescending(t => t.SttTuan)
                                                   .ThenBy(t => t.NgayTrongTuan)
                                                   .ThenBy(t => t.TietBatDau)
                                                   .ThenBy(t => t.TietKetThuc);
            string maGv = Models.Ultils.StaticValue.MaGv;
            var r = result.Where(l =>  l.Gvhd1!=null&& l.Gvhd1.Equals(maGv, StringComparison.CurrentCultureIgnoreCase) ||
                                     l.Gvhd2 != null && l.Gvhd2.Equals(maGv, StringComparison.CurrentCultureIgnoreCase) ||
                                     l.Gvhd3 != null && l.Gvhd3.Equals(maGv, StringComparison.CurrentCultureIgnoreCase));
            return this.Json(r.ToDataSourceResult(request, l => new 
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

            [Authorize(Roles = "AdminTeacher")]
        public JsonResult AjaxReadData([DataSourceRequest]
                                       DataSourceRequest request)
        {
            var result = DataProvider<LichThucHanh>.GetAll(l => l.MonHoc, l => l.GiangVien1, l => l.GiangVien2, l => l.GiangVien3)
                                                   .OrderByDescending(t => t.SttTuan)
                                                   .ThenBy(t => t.NgayTrongTuan)
                                                   .ThenBy(t => t.TietBatDau)
                                                   .ThenBy(t => t.TietKetThuc);

            return this.Json(result.ToDataSourceResult(request, l => new
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

            [Authorize(Roles = "AdminTeacher")]
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult AjaxUpdate([DataSourceRequest]
                                       DataSourceRequest request, [Bind(Prefix = "models")]
                                       IEnumerable<LichThucHanh> ls)
        {
            var results = new List<LichThucHanh>();

            if (ls != null && this.ModelState.IsValid)
            {
                foreach (var l in ls)
                {
                    if (l != null && this.ModelState.IsValid)
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
            return this.Json(results.ToDataSourceResult(request, ModelState));
        }

            [Authorize(Roles = "AdminTeacher")]
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult AjaxCreate([DataSourceRequest]
                                       DataSourceRequest request, [Bind(Prefix = "models")]
                                       IEnumerable<LichThucHanh> ls)
        {
            var results = new List<LichThucHanh>();

            if (ls != null && this.ModelState.IsValid)
            {
                foreach (var l in ls)
                {
                    if (l != null && this.ModelState.IsValid)
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
            return this.Json(results.ToDataSourceResult(request, ModelState));
        }

            [Authorize(Roles = "AdminTeacher")]
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult AjaxDelete([DataSourceRequest]
                                       DataSourceRequest request, [Bind(Prefix = "models")]
                                       IEnumerable<LichThucHanh> ls)
        {
            var results = ls.ToList();
            DataProvider<LichThucHanh>.Remove(results);
            return this.Json(results.ToDataSourceResult(request, ModelState));
        }

            [Authorize(Roles = "AdminTeacher")]
        public JsonResult DongBoLichThucHanh()
        {
            try
            {
                var phancong = DataProvider<PhanCongGiangDay>.GetAll(p => p.MonHoc);
                var phongTh = DataProvider<PhongThucHanh>.GetAll();
                var tkbgv = DataProvider<TkbGiangVien>.GetList(t => !t.TuanHoc.DaXepLichThucHanh && phongTh.Any(p => p.TenPhong == t.Phong), t => t.TuanHoc);

                int n = 0;
                foreach (var tkb in tkbgv)
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
                        if (tkb.TenMonHoc.Contains("2"))
                        {

                        }
                        var pc = phancong.SingleOrDefault(p => p.MonHoc.TenThucHanh.StartsWith(tkb.TenMonHoc, StringComparison.OrdinalIgnoreCase) && p.TenLop == tkb.LopHoc);
                     
                        if (pc != null)
                        {
                            lichTh.MonHocId = pc.MonHocId;

                            DataProvider<LichThucHanh>.Add(lichTh);
                            DataProvider<TkbGiangVien>.Remove(tkb);
                            n++;
                        }
                        else
                        {
                            System.Diagnostics.Debug.WriteLine("{0}\t{1}\t{2}", tkb.TenMonHoc, tkb.MaGv, tkb.LopHoc);
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

                return this.Json(new { Result = "OK", Message = n });
            }
            catch (Exception ex)
            {
                return this.Json(new { Result = "Fail", ex.Message });
            }
        }

        public JsonResult DiemDanhGv(int lichHocId, bool gv1, bool gv2, bool gv3)
        {
            try
            {
                var lichTh = DataProvider<LichThucHanh>.GetSingle(l => l.MaLichTh == lichHocId);
                lichTh.Gv1CoMat = gv1;
                lichTh.Gv2CoMat = gv2;
                lichTh.Gv3CoMat = gv3;

                DataProvider<LichThucHanh>.Update(lichTh);
                return this.Json(new { Result = "OK" });
            }
            catch (Exception ex)
            {
                return this.Json(new { Result = "Fail", ex.Message });
            }
        }

            [Authorize(Roles = "AdminTeacher")]
        public JsonResult SaoChepLich(int tuTuan, int denTuan)
        {
            try
            {
                var dsLichCanChep = DataProvider<LichThucHanh>.GetList(l => l.SttTuan == tuTuan);
                var result = new List<LichThucHanh>();

                foreach (var lth in dsLichCanChep)
                {
                    LichThucHanh l = new LichThucHanh()
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

                return this.Json(new { Result = "OK", Message = result.Count });
            }
            catch (Exception ex)
            {
                return this.Json(new { Result = "Fail", ex.Message });
            }
        }

            [Authorize(Roles = "AdminTeacher")]
        public JsonResult TuPhanCong(int chonTuan)
        {
            try
            {
                var all = DataProvider<LichThucHanh>.GetAll();
                var dsLichCanChep = all.Where(l => l.SttTuan == chonTuan).ToList();
                foreach (var lth in dsLichCanChep)
                {
                    var dsGvRanh = FilterController.LayDsGvRanh(lth.SttTuan, lth.NgayTrongTuan, lth.TietBatDau, lth.TietKetThuc);
                    if (lth.Gvhd1 == null)
                    {
                        var lt = all.Where(l => l.MonHocId == lth.MonHocId && l.TenLop == lth.TenLop && l.Gvhd1 != null)
                            .Select(l=>l.Gvhd1).Intersect(dsGvRanh);
                        if (lt.Any())
                            lth.Gvhd1 = lt.First();
                        else
                            continue;
                    }
                    if (lth.Gvhd2 == null)
                    {
                        var lt = all.Where(l => l.MonHocId == lth.MonHocId && l.TenLop == lth.TenLop && l.Gvhd2 != null)
                            .Select(l => l.Gvhd1).Intersect(dsGvRanh);
                        if (lt.Any())
                            lth.Gvhd2 = lt.First();
                    }
                    if (lth.Gvhd3 == null)
                    {
                        var lt = all.Where(l => l.MonHocId == lth.MonHocId && l.TenLop == lth.TenLop && l.Gvhd3 != null)
                        .Select(l => l.Gvhd1).Intersect(dsGvRanh);
                        if (lt != null)
                            lth.Gvhd3 = lt.First();
                    }
                }
                DataProvider<LichThucHanh>.Update(dsLichCanChep);

                return this.Json(new { Result = "OK", Message = dsLichCanChep.Count });
            }
            catch (Exception ex)
            {
                return this.Json(new { Result = "Fail", ex.Message });
            }
        }

            [Authorize(Roles = "AdminTeacher")]
        public ActionResult XuatExcel(int tuanXuat)
        {

            var lth = DataProvider<LichThucHanh>.GetList(l => l.SttTuan == tuanXuat, l => l.MonHoc, l => l.GiangVien1, l => l.GiangVien2, l => l.GiangVien3, l => l.TuanHoc)
                .OrderBy(l => l.SttTuan)
                .ThenBy(l => (int)l.NgayTrongTuan)
                .ToList();


            var workbook = new HSSFWorkbook();
            var sheet = workbook.CreateSheet("Tuan" + tuanXuat);
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
            blackBorder.FillForegroundColor = NPOI.HSSF.Util.HSSFColor.Grey40Percent.Index;
            blackBorder.FillBackgroundColor = NPOI.HSSF.Util.HSSFColor.Grey40Percent.Index;






            AddRow(ref numRow, "TRƯỜNG ĐẠI HỌC ĐÀ LẠT", sheet, 3);
            AddRow(ref numRow, "KHOA CNTT", sheet, 3);
            AddRow(ref numRow, string.Format("Lịch hướng dẫn thực hành tuần {0}", tuanXuat), sheet, 10, 15);
            AddRow(ref numRow, string.Format("Từ ngày {0} đến ngày {1}", lth.First().TuanHoc.NgayBatDau.ToString("dd/MM/yyyy"), lth.First().TuanHoc.NgayKetThuc.ToString("dd/MM/yyyy")), sheet, 10);

            numRow++;

            var columns = new[] { "Thứ", "Tiết", "Tên môn học", "Lớp", "Phòng", "GVHD 1", "GVHD 2", "GVHD 3", "Ghi chú", "GV vắng" };
            var headerRow = sheet.CreateRow(numRow++);



            //create header
            for (int i = 0; i < columns.Length; i++)
            {
                var cell = headerRow.CreateCell(i);
                cell.SetCellValue(columns[i]);
                //  cell.CellStyle=


                var font = workbook.CreateFont();

                font.FontHeightInPoints = 11;
                font.FontName = "Calibri";
                font.Boldweight = (short)NPOI.SS.UserModel.FontBoldWeight.Bold;
                cell.CellStyle = blackBorder;
                cell.CellStyle.SetFont(font);


            }
            sheet.SetColumnWidth(0, 10 * 256);
            sheet.SetColumnWidth(1, 10 * 256);
            sheet.SetColumnWidth(2, 30 * 256);
            sheet.SetColumnWidth(3, 10 * 256);
            sheet.SetColumnWidth(4, 10 * 256);
            sheet.SetColumnWidth(5, 15 * 256);
            sheet.SetColumnWidth(6, 15 * 256);
            sheet.SetColumnWidth(7, 15 * 256);
            sheet.SetColumnWidth(8, 30 * 256);
            sheet.SetColumnWidth(9, 30 * 256);


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
                NPOI.SS.UserModel.IRow row = sheet.CreateRow(numRow);

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



        void AddRow(ref int numRow, string context, ISheet sheet, int colSpan = 1, short size = 13)
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
            var cell = sheet.CreateRow(numRow++).CreateCell(0);

            cell.SetCellValue(context);
            cell.CellStyle = style;


        }

        void SetValue(NPOI.SS.UserModel.IRow row, LichThucHanh l, ICellStyle style, bool merge = false)
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

        void AddBlank(NPOI.SS.UserModel.IRow row)
        {
            var cell = row.CreateCell(row.Cells.Count);

        }
        void AddCell(NPOI.SS.UserModel.IRow row, string value, ICellStyle style)
        {
            var cell = row.CreateCell(row.Cells.Count);
            cell.SetCellValue(value);

            cell.CellStyle = style;
        }
    }
}