using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TkbThucHanhCNTT.Models
{
    public class LichCongTac
    {
        [Key]
        [Required]
        [ScaffoldColumn(false)]
        public int LichCongTacId { get; set; }

        [Required(ErrorMessage = "Lý do không được để trống!")]
        [Display(Name = "Lý do")]
        public string LyDo { get; set; }

        [Required(ErrorMessage = "Thời gian bắt đầu không được để trống!")]
        [UIHint("Date")]
        [Display(Name = "Thời gian bắt đầu")]
        public DateTime ThoiGianBd { get; set; }

        [UIHint("Date")]
        [Required(ErrorMessage = "Thời gian kết thúc không được để trống!")]
        [Display(Name = "Thời gian kết thúc")]
        public DateTime ThoiGianKt { get; set; }

        [Required(ErrorMessage = "Giảng viên không được để trống!")]
        [Display(Name = "Giảng viên")]
        [UIHint("GridForeignKey")]
        public string MaGv { get; set; }

        [ForeignKey("MaGv")]
        public virtual GiangVien GiangVien { get; set; }
    }
}