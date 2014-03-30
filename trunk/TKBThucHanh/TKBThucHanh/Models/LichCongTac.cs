using System;
using System.Collections.Generic;

namespace TkbThucHanh.Models
{
    public partial class LichCongTac
    {
        public int MaLct { get; set; }
        public string MaGv { get; set; }
        public string LyDo { get; set; }
        public DateTime? NgayBd { get; set; }
        public DateTime? NgayKt { get; set; }
        public virtual GiangVien GiangVien { get; set; }
    }
}
