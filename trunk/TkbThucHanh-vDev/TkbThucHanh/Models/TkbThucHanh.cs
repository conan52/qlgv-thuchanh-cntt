using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TkbThucHanh.Models.Ultils;

namespace TkbThucHanh.Models
{
    public class TkbThucHanh
    {
        [Key]
        public int TkbThucHanhId { get; set; }

        [Display(Name = "Mã môn học")]
        [Required(ErrorMessage = "Môn học không được để trống!")]
        public int MonHocId { get; set; }
        [ForeignKey("MonHocId")]
        public virtual MonHoc MonHoc { get; set; }
        
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
        
        public virtual List<PhanCongThucHanh> PhanCongThucHanhs { get; set; }

        public int TuanHoc { get; set; }

        [NotMapped]
        public string Thu
        {
            get { return NgayHoc.LayThu(); }
        }


    }
}