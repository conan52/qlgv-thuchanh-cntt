using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TKBThucHanh.Models
{
    public class LichCongTac
    {
        [Key]
        public int Id { get; set; }
        public string MaGiangVien { get; set; }
        public string LyDo { get; set; }
        public DateTime? ThoiGianBd { get; set; }
        public DateTime? ThoiGianKt { get; set; }
        [ForeignKey("MaGiangVien")]
        public virtual GiangVien GiangVien { get; set; }
    }
}