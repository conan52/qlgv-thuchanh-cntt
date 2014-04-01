using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TKBThucHanh.Models
{
    public class PhanCongGvThucHanh
    {
        [Key]
        public int MaTkbThucHanh { get; set; }

        [Display(Name = "Mã Thời khóa biểu")]
        public int MaTkb { get; set; }

        [Display(Name = "Giáo viên hướng dẫn")]
        public int Gvhd { get; set; }

        [Display(Name = "Ghi chú")]
        public string GhiChu { get; set; }

        [Display(Name = "Loại")]
        public string Loai { get; set; }

        [Display(Name = "Vắng mặt")]
        public bool? VangMat { get; set; }

        [ForeignKey("MaTkb")]
        public virtual ThoiKhoaBieuGiangVien ThoiKhoaBieuGiangVien { get; set; }
    }
}