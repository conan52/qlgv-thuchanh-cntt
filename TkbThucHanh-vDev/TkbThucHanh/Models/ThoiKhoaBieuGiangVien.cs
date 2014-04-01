using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TkbThucHanh.Models;

namespace TKBThucHanh.Models
{
    public class ThoiKhoaBieuGiangVien
    {
        public ThoiKhoaBieuGiangVien()
        {
            PhanCongGvThucHanhs = new List<PhanCongGvThucHanh>();
        }

        [Key]
        public int MaTkb { get; set; }

        [Display(Name = "Tên môn học")]
        public string TenMonHoc { get; set; }

        [Display(Name = "Lớp")]
        public int? LopId { get; set; }

        [Display(Name = "Phòng")]
        public int Phong { get; set; }

        [Display(Name = "Tiết bắt đầu")]
        public int TietBatDau { get; set; }

        [Display(Name = "Tiết kết thúc")]
        public int TietKetThuc { get; set; }

        [Display(Name = "Giảng viên phụ trách")]
        public int GiangVienPhuTrach { get; set; }

        [Display(Name = "Ngày học")]
        public DateTime NgayHoc { get; set; }


        [ForeignKey("LopId")]
        public virtual Lop Lop { get; set; }

        [ForeignKey("GiangVienPhuTrach")]
        public virtual GiangVien GiangVien { get; set; }

        public virtual ICollection<PhanCongGvThucHanh> PhanCongGvThucHanhs { get; set; }

        [ForeignKey("Phong")]
        public virtual PhongThucHanh PhongThucHanh { get; set; }
    }
}