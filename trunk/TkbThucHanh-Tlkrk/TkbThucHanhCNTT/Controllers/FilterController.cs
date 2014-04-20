using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
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
            return this.Json(result, JsonRequestBehavior.AllowGet);
        }

        public JsonResult LayGvPhanCong(int monHocId, string tenLop)
        {
            var gv = DataProvider<PhanCongGiangDay>.GetList(p => p.TenLop == tenLop && p.MonHocId == monHocId, p => p.GiangVien)
                                                   .Select(g => new { g.GiangVien.HoVaTen, g.GiangVien.MaGv });

            return this.Json(gv, JsonRequestBehavior.AllowGet);
        }

        public JsonResult LayDsGvRanh(int sttTuan, NgayTrongTuan ngayTrongTuan, int tietBatDau, int tietKetThuc, string gvA, string gvB)
        {
            var dsgv = this.LayDsGvRanh(sttTuan, ngayTrongTuan, tietBatDau, tietKetThuc);
            var result = from gv in DataProvider<GiangVien>.GetAll()
                         join ds in dsgv on gv.MaGv equals ds
                         where gv.MaGv != gvA && gv.MaGv != gvB
                         select new { gv.MaGv, gv.HoVaTen, gv.TenNganGon };

            return this.Json(result, JsonRequestBehavior.AllowGet);
        }

        private IEnumerable<string> LayDsGvRanh(int sttTuan, NgayTrongTuan ngayTrongTuan, int tietBatDau, int tietKetThuc)
        {
            var dsgv = DataProvider<GiangVien>.GetList(gv => gv.CoThePhanCong).Select(g => g.MaGv);
            var kq = from gv in dsgv
                     where this.GiangVienKhongCoTkbThucHanh(gv, sttTuan, ngayTrongTuan, tietBatDau, tietKetThuc) &&
                           this.GiangVienKhongCoTkbTruong(gv, sttTuan, ngayTrongTuan, tietBatDau, tietKetThuc) &&
                           this.GiangVienKhongCongTac(gv, sttTuan, ngayTrongTuan) &&
                           this.GiangVienKhongBanViecKhac(gv, sttTuan, ngayTrongTuan, tietKetThuc)
                     select gv;

            return kq.ToList();
        }

        private bool GiangVienKhongCongTac(string maGv, int tuan, NgayTrongTuan ngay)
        {
            var ngayHoc = TuanHocProvider.LayNgayHoc(tuan, ngay);
            return !DataProvider<LichCongTac>.GetList(ct => ct.ThoiGianBd <= ngayHoc && ct.ThoiGianKt >= ngayHoc && ct.MaGv == maGv).Any();
        }

        private bool GiangVienKhongCoTkbTruong(string maGv, int tuan, NgayTrongTuan ngay, int tietBatDau, int tietKetThuc)
        {
            var thoigianxet = Enumerable.Range(tietBatDau, tietKetThuc - tietBatDau + 1);
            return !DataProvider<TkbGiangVien>.GetList(t => t.SttTuan == tuan && t.NgayTrongTuan == ngay && t.MaGv == maGv)
                                              .Any(t => Enumerable.Range(t.TietBatDau, t.TietKetThuc - t.TietBatDau + 1).Intersect(thoigianxet).Any());
        }

        private bool GiangVienKhongCoTkbThucHanh(string maGv, int tuan, NgayTrongTuan ngay, int tietBatDau, int tietKetThuc)
        {
            var thoigianxet = Enumerable.Range(tietBatDau, tietKetThuc - tietBatDau + 1);
            return !DataProvider<LichThucHanh>.GetList(t => t.SttTuan == tuan && t.NgayTrongTuan == ngay && (t.Gvhd1 == maGv || t.Gvhd2 == maGv || t.Gvhd3 == maGv))
                                              .Any(t => Enumerable.Range(t.TietBatDau, t.TietKetThuc - t.TietBatDau + 1).Intersect(thoigianxet).Any());
        }

        private bool GiangVienKhongBanViecKhac(string maGv, int tuan, NgayTrongTuan ngay, int tietKetThuc)
        {
            int buoi = tietKetThuc / 6;
            return !DataProvider<LichBan>.GetList(b => b.SttTuan == tuan && b.MaGv == maGv && b.TrangThaiBan[(int)ngay * 3 + buoi] == '1').Any();
        }
    }
}