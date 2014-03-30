using System;
using System.Collections.Generic;

namespace TkbThucHanh.Models
{
    public partial class PhanCongThucHanh
    {
        public int MaTkbThucHanh { get; set; }
        public int MaTkb { get; set; }
        public string Gvhd { get; set; }
        public string Gvbs { get; set; }
        public virtual ThoiKhoaBieu ThoiKhoaBieu { get; set; }
    }
}
