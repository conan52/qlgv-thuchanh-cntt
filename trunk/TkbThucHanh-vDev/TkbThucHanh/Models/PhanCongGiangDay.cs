using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TkbThucHanh.Models
{
    public class PhanCongGiangDay
    {
        [Key]
        public int IdPhanCong { get; set; }

        [Required]
        [Range(2000, 2050, ErrorMessage = "Năm học không hợp lệ")]
        public int NamHoc { get; set; }

        [Required]
        [Range(1, 3, ErrorMessage = "Học kỳ phải là 1, 2 hoặc 3")]
        public int HocKy { get; set; }


        public int MonHocId { get; set; }
        [ForeignKey("MonHocId")]
        public virtual MonHoc MonHoc { get; set; }

        public int? GiangVienId { get; set; }
        [ForeignKey("GiangVienId")]
        public virtual GiangVien GiangVien { get; set; }

        public int LopId { get; set; }
        [ForeignKey("LopId")]
        public virtual Lop Lop { get; set; }


    }
}
