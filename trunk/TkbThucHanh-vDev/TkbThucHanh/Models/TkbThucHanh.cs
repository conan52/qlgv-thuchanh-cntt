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
        public string TenMonHoc { get; set; }

        [Display(Name = "Phòng")]
        public string Phong { get; set; }

        [Display(Name = "Tiết bắt đầu")]
        public int TietBatDau { get; set; }

        [Display(Name = "Tiết kết thúc")]
        public int TietKetThuc { get; set; }

        [Display(Name = "Ngày học")]
        public DateTime NgayHoc { get; set; }

        public int LopId { get; set; }

        [ForeignKey("LopId")]
        public virtual Lop Lop { get; set; }

        public int PhongThucHanhId { get; set; }

        [ForeignKey("PhongThucHanhId")]
        public virtual PhongThucHanh PhongThucHanh { get; set; }

        public int PhanCongThucHanhId { get; set; }

        [ForeignKey("PhanCongThucHanhId")]
        public virtual PhanCongThucHanh PhanCongThucHanh { get; set; }

        public virtual List<TkbGiangVien> TkbGangViens { get; set; }
    }
}