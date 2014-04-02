using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TkbThucHanh.Models
{
    public class PhanCongThucHanh
    {
        [Key]
        public int PhanCongThucHanhId { get; set; }

        public virtual List<TkbThucHanh> TkbThucHanhs { get; set; }

        [Display(Name = "Vắng")]
        public bool? Vang { get; set; }

        [Display(Name = "Ghi chú")]
        public string GhiChu { get; set; }

        [Required(ErrorMessage = "Giảng viên không được để trống!")]
        public int GiangVienId { get; set; }

        [ForeignKey("GiangVienId")]
        public virtual GiangVien GiangVien { get; set; }
    }
}