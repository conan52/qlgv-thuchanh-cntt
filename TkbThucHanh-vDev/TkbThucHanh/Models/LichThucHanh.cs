using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using TkbThucHanh.Models.Ultils;

namespace TkbThucHanh.Models
{
    public class LichThucHanh
    {
        [Key]
        public int MaLichTH { get; set; }


        [Display(Name = "Tên môn học")]
        [Required(ErrorMessage = "Tên môn học không được để trống!")]
        public string TenMonHoc { get; set; }

        [Display(Name = "Phòng")]
        [Required(ErrorMessage = "Phòng không được để trống!")]
        public string Phong { get; set; }

        [Display(Name = "Lớp")]
        //  [Required(ErrorMessage = "Lớp không được để trống!")]
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

        [Required(ErrorMessage = "Giảng viên không được để trống!")]


        public string MaGv1 { get; set; }

        [ForeignKey("MaGv1")]
        public virtual GiangVien GiangVien1 { get; set; }

        public string MaGv2 { get; set; }

        [ForeignKey("MaGv2")]
        public virtual GiangVien GiangVien2 { get; set; }

        public string MaGv3 { get; set; }

        [ForeignKey("MaGv3")]
        public virtual GiangVien GiangVien3 { get; set; }

        public string GvVang { get; set; }

        public string GhiChu { get; set; }


        public int TuanHoc { get; set; }

        [NotMapped]
        public string Thu
        {
            get { return NgayHoc.LayThu(); }
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