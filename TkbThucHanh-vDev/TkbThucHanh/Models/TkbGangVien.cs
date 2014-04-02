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
        public string TenMonHoc { get; set; }

        [Display(Name = "Phòng")]
        public string Phong { get; set; }

        [Display(Name = "Tiết bắt đầu")]
        public int TietBatDau { get; set; }

        [Display(Name = "Tiết kết thúc")]
        public int TietKetThuc { get; set; }

        [Display(Name = "Ngày học")]
        public DateTime NgayHoc { get; set; }

        public int GiangVienId { get; set; }

        [ForeignKey("GiangVienId")]
        public virtual GiangVien GiangVien { get; set; }

        public int? TkbThucHanhId { get; set; }

        [ForeignKey("TkbThucHanhId")]
        public virtual TkbThucHanh TkbThucHanh { get; set; }
    }
}