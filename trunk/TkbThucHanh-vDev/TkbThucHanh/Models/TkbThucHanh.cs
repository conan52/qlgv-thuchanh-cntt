using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TkbThucHanh.Models
{
    public class TkbThucHanh
    {
        [Key]
        public int TkbThucHanhId { get; set; }

        [Display(Name = "Tên môn học")]
        [Required(ErrorMessage = "Tên môn học không được để trống!")]
        public string TenMonHoc { get; set; }

        [Display(Name = "Phòng")]
        [Required(ErrorMessage = "Phòng không được để trống!")]
        public string Phong { get; set; }

        [Display(Name = "Tiết bắt đầu")]
        [Required(ErrorMessage = "Tiết bắt đầu không được để trống!")]
        public int TietBatDau { get; set; }

        [Display(Name = "Tiết kết thúc")]
        [Required(ErrorMessage = "Tiết kết thúc không được để trống!")]
        public int TietKetThuc { get; set; }

        [Display(Name = "Ngày học")]
        [Required(ErrorMessage = "Ngày học không được để trống!")]
        public DateTime NgayHoc { get; set; }

        [Required(ErrorMessage = "Lớp không được để trống!")]
        public int LopId { get; set; }

        [ForeignKey("LopId")]
        public virtual Lop Lop { get; set; }

        [Required(ErrorMessage = "Phòng thực hành không được để trống!")]
        public int PhongThucHanhId { get; set; }

        [ForeignKey("PhongThucHanhId")]
        public virtual PhongThucHanh PhongThucHanh { get; set; }

        [Required(ErrorMessage = "Phân công thực hành không được để trống!")]
        public int PhanCongThucHanhId { get; set; }

        [ForeignKey("PhanCongThucHanhId")]
        public virtual PhanCongThucHanh PhanCongThucHanh { get; set; }

        public virtual List<TkbGiangVien> TkbGangViens { get; set; }
    }
}