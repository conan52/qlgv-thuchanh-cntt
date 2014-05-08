using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TkbThucHanhCNTT.Models
{
    public class ChiTietPhanCong
    {
        public int IdPhanCong { get; set; }
        public int ChiTietPhanCongId { get; set; }
        public string MaGiangVien { get; set; }
        public int ThuTuUuTien { get; set; }
        public bool PhuTrachGiangDay { get; set; }

        [ForeignKey("IdPhanCong")]
        public PhanCong PhanCong { get; set; }

        [ForeignKey("MaGiangVien")]
        public GiangVien GiangVien { get; set; }

    }
}