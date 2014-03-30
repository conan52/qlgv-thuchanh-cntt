using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public string TenMonHoc { get; set; }
        public int Lop { get; set; }
        public int Phong { get; set; }
        public int TietBatDau { get; set; }
        public int TietKetThuc { get; set; }
        public string GiangVienPhuTrach { get; set; }
        public DateTime NgayHoc { get; set; }
        [ForeignKey("GiangVienPhuTrach")]
        public virtual GiangVien GiangVien { get; set; }
        public virtual ICollection<PhanCongGvThucHanh> PhanCongGvThucHanhs { get; set; }
        [ForeignKey("Phong")]
        public virtual PhongThucHanh PhongThucHanh { get; set; }
    }
}