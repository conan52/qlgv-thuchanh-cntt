using System;
using System.ComponentModel.DataAnnotations;

namespace TKBThucHanh.Models
{
    public class TuanHoc
    {
        [Key]
        public int Id { get; set; }
        public int SttTuan { get; set; }
        public string NamHoc { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public bool? DaLayThongTin { get; set; }
        public bool? DaXepLichThucHanh { get; set; }
    }
}