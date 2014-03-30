using System;
using System.Collections.Generic;

namespace TkbThucHanh.Models
{
    public partial class Phong
    {
        public Phong()
        {
            this.ThoiKhoaBieux = new List<ThoiKhoaBieu>();
        }

        public string TenPhong { get; set; }
        public virtual ICollection<ThoiKhoaBieu> ThoiKhoaBieux { get; set; }
    }
}
