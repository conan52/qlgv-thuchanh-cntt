using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using TkbThucHanhCNTT.Models.Enums;

namespace TkbThucHanhCNTT.Models.Viewer
{
    public class LichThucHanhViewModel
    {
        [Key]
        public int MaLichTh { get; set; }

        [Display(Name = "Môn học")]
        [Required(ErrorMessage = "Môn học không được để trống!")]
        public int MonHocId { get; set; }

        [ForeignKey("MonHocId")]
        //[Required]
        public MonHoc MonHoc { get; set; }

        [Display(Name = "Phòng")]
        [UIHint("GridForeignKey")]
        [Required(ErrorMessage = "Phòng không được để trống!")]
        public string TenPhong { get; set; }

        [ForeignKey("TenPhong")]
        //[Required]
        public PhongThucHanh PhongThucHanh { get; set; }

        [Display(Name = "Lớp")]
        [Required(ErrorMessage = "Lớp không được để trống!")]
        public string TenLop { get; set; }

        [ForeignKey("TenLop")]
        public Lop Lop { get; set; }


        //[UIHint("TietHoc")]
        //[Display(Name = "Tiết")]
        //public TietHoc TietHoc { get; set; }


        //public int TietBatDau { get; set; }

        [Range(1, 13)]
        [UIHint("TietHoc")]
        [Display(Name = "Tiết bắt đầu")]
        [Required(ErrorMessage = "Tiết bắt đầu không được để trống!")]
        public int TietBatDau { get; set; }



        [Range(1, 13)]
         [UIHint("TietHoc")]
        [Display(Name = "Tiết kết thúc")]
        [Required(ErrorMessage = "Tiết kết thúc không được để trống!")]
        public int TietKetThuc { get; set; }

        [UIHint("GridForeignKey")]
        [Display(Name = "Tuần")]
        public int SttTuan { get; set; }
        public TuanHoc TuanHoc { get; set; }

         [Display(Name = "Thứ")]
        public NgayTrongTuan NgayTrongTuan { get; set; }


        [Display(Name = "GVHD1")]
        [Required(ErrorMessage = "GVHD1 không được để trống")]
        public string Gvhd1 { get; set; }
        [ForeignKey("Gvhd1")]
        public GiangVien GiangVien1 { get; set; }


        [Display(Name = "GVHD2")]
        public string Gvhd2 { get; set; }
        [ForeignKey("Gvhd2")]
        public GiangVien GiangVien2 { get; set; }

        [Display(Name = "GVHD3")]
        public string Gvhd3 { get; set; }
        [ForeignKey("Gvhd3")]
        public GiangVien GiangVien3 { get; set; }
         [Display(Name = "Ghi chú")]
        public string GhiChu { get; set; }
         [Display(Name = "Vắng")]
        public string Vang { get; set; }

        public virtual List<PhanCongThucHanh> PhanCongThucHanhs { get; set; }

    }
}