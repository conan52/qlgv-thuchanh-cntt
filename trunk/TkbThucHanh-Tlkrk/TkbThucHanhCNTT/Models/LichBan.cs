using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TkbThucHanhCNTT.Models
{
    public class LichBan
    {
        [Key]
        public int LichBanId { get; set; }

        public string MaGv { get; set; }
        [ForeignKey("MaGv")]
        public GiangVien GiangVien { get; set; }
        public int SttTuan { get; set; }
        [ForeignKey("SttTuan")]
        public TuanHoc TuanHoc { get; set; }


        public string TrangThaiBan { get; set; }


    }
}