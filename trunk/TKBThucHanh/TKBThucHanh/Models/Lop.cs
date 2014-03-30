using System;
using System.Collections.Generic;

namespace TkbThucHanh.Models
{
    public partial class Lop
    {
        public Lop()
        {
            this.ThoiKhoaBieux = new List<ThoiKhoaBieu>();
        }

        public string TenLop { get; set; }
        public string TrinhDo { get; set; }
        public virtual ICollection<ThoiKhoaBieu> ThoiKhoaBieux { get; set; }
    }
}
