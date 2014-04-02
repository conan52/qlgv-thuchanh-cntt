using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TkbThucHanh.Models
{
    public class LichCongTac
    {
        [Key]
        [Required]
        public int LichCongTacId { get; set; }

        [Required(ErrorMessage = "Lý do không được để trống!")]
        [Display(Name = "Lý do")]
        public string LyDo { get; set; }

        [Required(ErrorMessage = "Thời gian bắt đầu không được để trống!")]
        [Display(Name = "Thời gian bắt đầu")]
        public DateTime ThoiGianBd { get; set; }

          [Required(ErrorMessage = "Thời gian kết thúc không được để trống!")]
        [Display(Name = "Thời gian kết thúc")]
        public DateTime? ThoiGianKt { get; set; }

        [Required(ErrorMessage = "Giảng viên không được để trống!")]
        public int GiangVienId { get; set; }

        [ForeignKey("GiangVienId")]
        public virtual GiangVien GiangVien { get; set; }
    }
}