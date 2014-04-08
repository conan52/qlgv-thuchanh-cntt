using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TkbThucHanhCNTT.Models
{
    public class PhanCongGiangDay
    {
        [Key]
        public int IdPhanCong { get; set; }

        [Required(ErrorMessage = "Năm học không được để trống!")]
        [Range(2000, 2050, ErrorMessage = "Năm học không hợp lệ")]
        public int NamHoc { get; set; }

        [Required(ErrorMessage = "Học kỳ không được để trống!")]
        [Range(1, 3, ErrorMessage = "Học kỳ phải là 1, 2 hoặc 3")]
        public int HocKy { get; set; }

        [Required(ErrorMessage = "Môn học không được để trống!")]
        public int MonHocId { get; set; }

        [ForeignKey("MonHocId")]
        public virtual MonHoc MonHoc { get; set; }

        public string MaGv { get; set; }

        [ForeignKey("MaGv")]
        [UIHint("GiangVien")]
        public virtual GiangVien GiangVien { get; set; }

        [Required(ErrorMessage = "Lớp không được để trống!")]
        public string TenLop { get; set; }

        [ForeignKey("TenLop")]
        public virtual Lop Lop { get; set; }
    }
}