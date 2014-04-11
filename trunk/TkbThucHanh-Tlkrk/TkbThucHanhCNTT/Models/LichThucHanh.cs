using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TkbThucHanhCNTT.Models.Enums;
using TkbThucHanhCNTT.Models.Ultils;

namespace TkbThucHanhCNTT.Models
{
    public sealed class LichThucHanh
    {
        [Key]
        public int MaLichTh { get; set; }

        public int SttTuan { get; set; }
        public TuanHoc TuanHoc { get; set; }

        public NgayTrongTuan NgayTrongTuan { get; set; }


        [Display(Name = "Môn học")]
        [Required(ErrorMessage = "Môn học không được để trống!")]
        public int MonHocId { get; set; }

        [ForeignKey("MonHocId")]
      //  [Required]
        public MonHoc MonHoc { get; set; }

        [Display(Name = "Phòng")]
        [Required(ErrorMessage = "Phòng không được để trống!")]
        public string TenPhong { get; set; }

        [ForeignKey("TenPhong")]
      //  [Required]
        public PhongThucHanh PhongThucHanh { get; set; }


        [Display(Name = "Lớp")]
        [Required(ErrorMessage = "Lớp không được để trống!")]
        public string TenLop { get; set; }

        [ForeignKey("TenLop")]
        public Lop Lop { get; set; }


        [Display(Name = "Tiết bắt đầu")]
        [Required(ErrorMessage = "Tiết bắt đầu không được để trống!")]
        public int TietBatDau { get; set; }

        [Display(Name = "Tiết kết thúc")]
        [Required(ErrorMessage = "Tiết kết thúc không được để trống!")]
        public int TietKetThuc { get; set; }


        public string GhiChu { get; set; }

        public List<PhanCongThucHanh> PhanCongThucHanhs { get; set; }


        public LichThucHanh()
        {
            PhanCongThucHanhs = new List<PhanCongThucHanh>();
        }

    }
}