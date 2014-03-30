using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TKBThucHanh.Models
{
    public class LichCongTac
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(10)]
        [Display(Name = "Mã giảng viên")]
        public string MaGiangVien { get; set; }

        [Display(Name = "Lý do")]
        public string LyDo { get; set; }

        [Display(Name = "Thời gian bắt đầu")]
        public DateTime? ThoiGianBd { get; set; }

        [Display(Name = "Thời gian kết thúc")]
        public DateTime? ThoiGianKt { get; set; }

        [ForeignKey("MaGiangVien")]
        public virtual GiangVien GiangVien { get; set; }
    }
}