using System;
using System.Collections.Generic;

namespace TkbThucHanh.Models
{
    public partial class TuanHoc
    {
        public int SoTuan { get; set; }
        public string NamHoc { get; set; }
        public string HocKy { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
    }
}
