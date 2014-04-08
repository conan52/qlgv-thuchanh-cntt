using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TkbThucHanhCNTT.Models.Enums;

namespace TkbThucHanhCNTT.Models
{
    public class PhanCongThucHanh
    {
        [Key]
        public int PhanCongThucHanhId { get; set; }

        [Display(Name = "Trạng thái")]
        public TrangThaiHuongDanTh TrangThai { get; set; }

        [Display(Name = "Ghi chú")]
        public string GhiChu { get; set; }

        [Required(ErrorMessage = "Giảng viên không được để trống!")]
        public string MaGv { get; set; }

        [ForeignKey("MaGv")]
        public virtual GiangVien GiangVien { get; set; }

        public int MaLichTh { get; set; }
        [ForeignKey("MaLichTh")]
        public LichThucHanh LichThucHanh { get; set; }

    }
}