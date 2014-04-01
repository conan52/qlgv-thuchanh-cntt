using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TkbThucHanh.Models;

namespace TKBThucHanh.Models
{
    public class PhanCongGiangDay
    {
        [Key]
        public int IdPhanCong { get; set; }

        [ForeignKey("LopId")]
        public Lop Lop { get; set; }

        [Required]
        [Range(2000, 2050, ErrorMessage = "Năm học không hợp lệ")]
        public int NamHoc { get; set; }

        [Required]
        [Range(1, 2, ErrorMessage = "Học kỳ phải là 1, 2 hoặc 3")]
        public int HocKy { get; set; }

        [Required(ErrorMessage = "Chưa nhập lớp")]
        public int LopId { get; set; }

        public int? IdGiangVienChinh { get; set; }

        public int? IdGiangVienPhu { get; set; }

        [ForeignKey("IdGiangVienChinh")]
        public virtual GiangVien GiangVienChinh { get; set; }

        [ForeignKey("IdGiangVienPhu")]
        public virtual GiangVien GiangVienPhu { get; set; }

        public int IdMonHoc { get; set; }

        [ForeignKey("IdMonHoc")]
        public MonHoc MonHoc { get; set; }
    }
}