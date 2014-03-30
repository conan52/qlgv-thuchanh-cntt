using System;
using System.Collections.Generic;

namespace TkbThucHanh.Models
{
    public partial class MonHoc
    {
        public MonHoc()
        {
            this.ThoiKhoaBieux = new List<ThoiKhoaBieu>();
        }

        public string TenMonHoc { get; set; }
        public string ChuyenNganh { get; set; }
        public virtual ICollection<ThoiKhoaBieu> ThoiKhoaBieux { get; set; }
    }
}
