using System.Collections.Generic;

namespace TkbThucHanh.Models
{
    public class Phong
    {
        public Phong()
        {
            ThoiKhoaBieux = new List<ThoiKhoaBieu>();
        }

        public string TenPhong { get; set; }
        public virtual ICollection<ThoiKhoaBieu> ThoiKhoaBieux { get; set; }
    }
}