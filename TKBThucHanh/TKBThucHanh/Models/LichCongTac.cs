using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TKBThucHanh.Models
{
    public class LichCongTac
    {
        [Key]
        [Required]
        public int LichCongTacId { get; set; }

        public int GiangVienId { get; set; }

        [Display(Name = "Lý do")]
        public string LyDo { get; set; }

        [Display(Name = "Thời gian bắt đầu")]
        public DateTime? ThoiGianBd { get; set; }

        [Display(Name = "Thời gian kết thúc")]
        public DateTime? ThoiGianKt { get; set; }

        [ForeignKey("GiangVienId")]
        public virtual GiangVien GiangVien { get; set; }
    }
}