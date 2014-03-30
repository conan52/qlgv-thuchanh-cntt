using System;
using System.Collections.Generic;

namespace TkbThucHanh.Models
{
    public partial class GiangVien
    {
        public GiangVien()
        {
            this.LichCongTacs = new List<LichCongTac>();
            this.ThoiKhoaBieux = new List<ThoiKhoaBieu>();
        }

        public string MaGV { get; set; }
        public string TenDayDu { get; set; }
        public string TenHienThi { get; set; }
        public string ChuyenNganh { get; set; }
        public bool CongTac { get; set; }
        public bool Enable { get; set; }
        public virtual ICollection<LichCongTac> LichCongTacs { get; set; }
        public virtual ICollection<ThoiKhoaBieu> ThoiKhoaBieux { get; set; }
    }
}
