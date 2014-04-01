using System.Collections.Generic;
using TKBThucHanh.Models;

namespace TkbThucHanh.Models
{
    public class Lop
    {
        public int LopId { get; set; }
        public string TenLop { get; set; }
        public string TrinhDo { get; set; }
        public int NamNhapHoc { get; set; }

        public virtual List<PhanCongGiangDay> PhanCongGiang { get; set; }
    }
}