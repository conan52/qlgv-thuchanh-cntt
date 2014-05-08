using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TkbThucHanhCNTT.Models
{
    public class PhanCong
    {
        public PhanCong()
        {
            ChiTietPhanCongs = new List<ChiTietPhanCong>();
        }

        [Key]
        [ScaffoldColumn(false)]
        public int IdPhanCong { get; set; }

        [UIHint("NamHoc")]
        [Display(Name = "Năm học")]
        [Required(ErrorMessage = "Năm học không được để trống!")]
        [Range(2000, 2050, ErrorMessage = "Năm học không hợp lệ")]
        public int NamHoc { get; set; }

        [UIHint("HocKy")]
        [Display(Name = "Học kỳ")]
        [Required(ErrorMessage = "Học kỳ không được để trống!")]
        [Range(1, 3, ErrorMessage = "Học kỳ phải là 1, 2 hoặc 3")]
        public int HocKy { get; set; }

        [Display(Name = "Môn học")]
        [UIHint("GridForeignKey")]
        [Required(ErrorMessage = "Môn học không được để trống!")]
        public int MonHocId { get; set; }

        [ForeignKey("MonHocId")]
        public virtual MonHoc MonHoc { get; set; }

        [Display(Name = "Tên lớp")]
        [UIHint("GridForeignKey")]
        [Required(ErrorMessage = "Lớp không được để trống!")]
        public string TenLop { get; set; }

        [ForeignKey("TenLop")]
        public virtual Lop Lop { get; set; }


        public int SoLuongGiangVien { get;private set; }

        public List<ChiTietPhanCong> ChiTietPhanCongs { get; set; }

    }
}