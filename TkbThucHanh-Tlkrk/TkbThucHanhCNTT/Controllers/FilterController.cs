using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DluWebHelper;
using Kendo.Mvc.UI;
using TkbThucHanhCNTT.Models;
using TkbThucHanhCNTT.Models.Enums;
using TkbThucHanhCNTT.Models.Provider;

namespace TkbThucHanhCNTT.Controllers
{
    public class FilterController : Controller
    {
        public JsonResult LayMonHocDuocPhanCong(string tenLop)
        {
            var result = DataProvider<PhanCongGiangDay>.GetList(p => p.TenLop == tenLop, p => p.MonHoc)
                .Select(t => new { t.MonHoc.TenMonHoc, t.MonHoc.MaMonHoc, t.MonHoc.TenThucHanh, t.MonHoc.MonHocId });
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public JsonResult LayGvPhanCong(int monHocId, string tenLop)
        {
            var gv = DataProvider<PhanCongGiangDay>.GetList(p => p.TenLop == tenLop && p.MonHocId == monHocId, p => p.GiangVien)
                .Select(g => new { g.GiangVien.HoVaTen, g.GiangVien.MaGv });

            return Json(gv, JsonRequestBehavior.AllowGet);
        }



        public JsonResult LayDsGvRanh(int sttTuan, NgayTrongTuan ngayTrongTuan, int tietBatDau, int tietKetThuc, string gvA, string gvB, int chuyenNganh)
        {
            var dsgv = LayDsGvRanh(sttTuan, ngayTrongTuan, tietBatDau, tietKetThuc, chuyenNganh);
            var result = from gv in DataProvider<GiangVien>.GetAll()
                         join ds in dsgv on gv.MaGv equals ds
                         where gv.MaGv != gvA && gv.MaGv != gvB
                         select new { gv.MaGv, gv.HoVaTen, gv.TenNganGon };

            return Json(result, JsonRequestBehavior.AllowGet);
        }








        List<string> LayDsGvRanh(int sttTuan, NgayTrongTuan ngayTrongTuan, int tietBatDau, int tietKetThuc, int chuyenNganh)
        {

            var dsgv = DataProvider<GiangVien>.GetList(gv => gv.CoThePhanCong && (chuyenNganh == 0 || chuyenNganh == (int)gv.ChuyenNganh)).Select(g => g.MaGv);
            var kq = from gv in dsgv
                     where GiangVienKhongCoTkbThucHanh(gv, sttTuan, ngayTrongTuan, tietBatDau, tietKetThuc)
                           && GiangVienKhongCoTkbTruong(gv, sttTuan, ngayTrongTuan, tietBatDau, tietKetThuc)
                           && GiangVienKhongCongTac(gv, sttTuan, ngayTrongTuan)
                     select gv;

            return kq.ToList();
        }

        bool GiangVienKhongCongTac(string maGv, int tuan, NgayTrongTuan ngay)
        {
            var ngayHoc = TuanHocProvider.LayNgayHoc(tuan, ngay);
            return !DataProvider<LichCongTac>.GetList(ct => ct.ThoiGianBd <= ngayHoc && ct.ThoiGianKt >= ngayHoc && ct.MaGv == maGv).Any();
        }

        bool GiangVienKhongCoTkbTruong(string maGv, int tuan, NgayTrongTuan ngay, int tietBatDau, int tietKetThuc)
        {
            var thoigianxet = Enumerable.Range(tietBatDau, tietKetThuc - tietBatDau + 1);
            return !DataProvider<TkbGiangVien>.GetList(t => t.SttTuan == tuan && t.NgayTrongTuan == ngay && t.MaGv == maGv)
                .Any(t => Enumerable.Range(t.TietBatDau, t.TietKetThuc - t.TietBatDau + 1).Intersect(thoigianxet).Any());
        }

        bool GiangVienKhongCoTkbThucHanh(string maGv, int tuan, NgayTrongTuan ngay, int tietBatDau, int tietKetThuc)
        {
            var thoigianxet = Enumerable.Range(tietBatDau, tietKetThuc - tietBatDau + 1);
            return !DataProvider<LichThucHanh>.GetList(t => t.SttTuan == tuan && t.NgayTrongTuan == ngay && (t.Gvhd1 == maGv || t.Gvhd2 == maGv || t.Gvhd3 == maGv))
                .Any(t => Enumerable.Range(t.TietBatDau, t.TietKetThuc - t.TietBatDau + 1).Intersect(thoigianxet).Any());
        }

    }
}
