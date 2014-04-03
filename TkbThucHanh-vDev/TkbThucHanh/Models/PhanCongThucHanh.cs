using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TkbThucHanh.Models.Enums;

namespace TkbThucHanh.Models
{
    public class PhanCongThucHanh
    {
        [Key]
        public int PhanCongThucHanhId { get; set; }

        public virtual List<TkbThucHanh> TkbThucHanhs { get; set; }

        [Display(Name = "Trạng thái")]
        public TrangThaiHuongDanTH TrangThai { get; set; }

        [Display(Name = "Ghi chú")]
        public string GhiChu { get; set; }

        [Required(ErrorMessage = "Giảng viên không được để trống!")]
        public string MaGv { get; set; }

        [ForeignKey("MaGv")]
        public virtual GiangVien GiangVien { get; set; }
    }
}