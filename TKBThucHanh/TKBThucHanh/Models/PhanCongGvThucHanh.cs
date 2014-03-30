using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TKBThucHanh.Models
{
    public class PhanCongGvThucHanh
    {
        [Key]
        public int MaTkbThucHanh { get; set; }
        public int MaTkb { get; set; }
        public int Gvhd { get; set; }
        public string GhiChu { get; set; }
        public string Loai { get; set; }
        public bool? VangMat { get; set; }
        [ForeignKey("MaTkb")]
        public virtual ThoiKhoaBieuGiangVien ThoiKhoaBieuGiangVien { get; set; }
    }
}