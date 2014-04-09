using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using TkbThucHanhCNTT.Models.Enums;
using TkbThucHanhCNTT.Models.Ultils;

namespace TkbThucHanhCNTT.Models.Viewer
{
    public class TkbGiangVienViewModel
    {
        [Key]
        [ScaffoldColumn(false)]
        public int MaTkb { get; set; }

        [UIHint("GridForeignKey")]
        [Display(Name = "Tuần")]
        public int SttTuan { get; set; }

        [ForeignKey("SttTuan")]
        public TuanHoc TuanHoc { get; set; }

        [UIHint("GridForeignKey")]
        public NgayTrongTuan NgayTrongTuan { get; set; }

        [Display(Name = "Giảng viên")]
        [UIHint("GridForeignKey")]
        [Required(ErrorMessage = "Giảng viên không được để trống!")]
        public string MaGv { get; set; }

        [ForeignKey("MaGv")]
        public virtual GiangVien GiangVien { get; set; }



        
        [Display(Name = "Tên môn học")]
        [Required(ErrorMessage = "Tên môn học không được để trống!")]
        public string TenMonHoc { get; set; }

        [Display(Name = "Phòng")]
        [Required(ErrorMessage = "Phòng không được để trống!")]
        public string Phong { get; set; }

        [Display(Name = "Lớp")]
        public string LopHoc { get; set; }

        [Display(Name = "Tiết bắt đầu")]
        [Required(ErrorMessage = "Tiết bắt đầu không được để trống!")]
        public int TietBatDau { get; set; }

        [Display(Name = "Tiết kết thúc")]
        [Required(ErrorMessage = "Tiết kết th không được để trống!")]
        public int TietKetThuc { get; set; }

        [Display(Name = "Ngày học")]
        [Required(ErrorMessage = "Ngày học không được để trống!")]
        public DateTime NgayHoc { get; set; }



    }
}