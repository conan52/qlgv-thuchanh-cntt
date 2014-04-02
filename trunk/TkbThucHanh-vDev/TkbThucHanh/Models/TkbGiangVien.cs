using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TkbThucHanh.Models
{
    public class TkbGiangVien
    {
        [Key]
        public int MaTkb { get; set; }

        [Display(Name = "Tên môn học")]
        [Required(ErrorMessage = "Tên môn học không được để trống!")]
        public string TenMonHoc { get; set; }

        [Display(Name = "Phòng")]
        [Required(ErrorMessage = "Phòng không được để trống!")]
        public string Phong { get; set; }

        [Display(Name = "Lớp")]
    //    [Required(ErrorMessage = "Lớp không được để trống!")]
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
        public string MaGv { get; set; }

        [ForeignKey("MaGv")]
        public virtual GiangVien GiangVien { get; set; }

        public int? TkbThucHanhId { get; set; }

        [ForeignKey("TkbThucHanhId")]
        public virtual TkbThucHanh TkbThucHanh { get; set; }
    }
}