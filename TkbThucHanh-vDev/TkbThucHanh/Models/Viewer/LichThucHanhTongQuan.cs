using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using TkbThucHanh.Models.Enums;

namespace TkbThucHanh.Models.Viewer
{
    public class LichThucHanhTongQuan
    {
        public int TkbThucHanhId { get; set; }
        public string TenMonHoc { get; set; }
        public int MaMonHoc { get; set; }

        public string Phong { get; set; }
        public int TietBatDau { get; set; }
        public int TietKetThuc { get; set; }
        public DateTime NgayHoc { get; set; }
        public string TenLop{ get; set; }
        public int? Gvhd1 { get; set; }
        public int? Gvhd2 { get; set; }
        public int? Gvhd3 { get; set; }

        public string GvVang { get; set; }
        public string GhiChu { get; set; }

        public static explicit operator LichThucHanhTongQuan(TkbThucHanh tkbThucHanh)
        {
            var thtq = new LichThucHanhTongQuan
            {
                NgayHoc = tkbThucHanh.NgayHoc,
                TietKetThuc = tkbThucHanh.TietKetThuc,
                Phong = tkbThucHanh.Phong,
                TietBatDau = tkbThucHanh.TietBatDau,
                TenMonHoc = tkbThucHanh.MonHoc.TenMonHoc,
                MaMonHoc = tkbThucHanh.MonHocId,
                GhiChu = string.Join(", ", tkbThucHanh.PhanCongThucHanhs.Where(pc => !string.IsNullOrWhiteSpace(pc.GhiChu)).Select(pc => pc.GhiChu)),
                GvVang = string.Join(", ", tkbThucHanh.PhanCongThucHanhs.Where(pc => pc.TrangThai == TrangThaiHuongDanTH.Vang).Select(pc => pc.GiangVien.HoVaTen)),
                TenLop = tkbThucHanh.TenLop,
                TkbThucHanhId = tkbThucHanh.TkbThucHanhId
            };
            
            return thtq;
        }

        public string Tiet
        {
            get
            {
                return string.Format("{0} - {1}", TietBatDau, TietKetThuc);
            }
        }

        public int SoTiet
        {
            get { return TietKetThuc - TietBatDau + 1; }
        }
    }
}