using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TKBThucHanh.Models
{
    public class PhongThucHanh
    {
        public PhongThucHanh()
        {
            ThoiKhoaBieuGiangViens = new List<ThoiKhoaBieuGiangVien>();
        }

        [Key]
        public int PhongThucHanhId { get; set; }

        [Display(Name = "Tên phòng")]
        public string TenPhong { get; set; }

        public virtual ICollection<ThoiKhoaBieuGiangVien> ThoiKhoaBieuGiangViens { get; set; }
    }
}