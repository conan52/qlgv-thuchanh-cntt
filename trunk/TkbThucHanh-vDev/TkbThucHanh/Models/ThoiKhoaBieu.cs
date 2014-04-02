using System;
using System.Collections.Generic;
using TKBThucHanh.Models;

namespace TkbThucHanh.Models
{
    public partial class ThoiKhoaBieu
    {
        public ThoiKhoaBieu()
        {
            this.PhanCongThucHanhs = new List<PhanCongThucHanh>();
        }

        public int MaTKB { get; set; }
        public string TenMonHoc { get; set; }
        public string Lop { get; set; }
        public string Phong { get; set; }
        public int TietBatDau { get; set; }
        public int TietKetThuc { get; set; }
        public string GvDay { get; set; }
        public System.DateTime NgayHoc { get; set; }
        public virtual GiangVien GiangVien { get; set; }
        public virtual Lop Lop1 { get; set; }
        public virtual MonHoc MonHoc { get; set; }
        public virtual ICollection<PhanCongThucHanh> PhanCongThucHanhs { get; set; }
      //  public virtual PhongThucHanh Phong1 { get; set; }
    }
}
