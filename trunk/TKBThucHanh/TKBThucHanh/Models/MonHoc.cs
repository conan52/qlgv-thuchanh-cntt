using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TKBThucHanh.Models.Enums;

namespace TKBThucHanh.Models
{
    public class MonHoc
    {
        [Key]
        public int MonHocId { get; set; }

        [Required(ErrorMessage = "Mã môn học không được để trống")]
        [Display(Name = "Mã môn học")]
        public string MaMonHoc { get; set; }

        [Display(Name = "Tên môn học")]
        public string TenMonHoc { get; set; }

        [Display(Name = "Tín chỉ thực hành")]
        public int SoTinChiThucHanh { get; set; }

        [Display(Name = "Tín chỉ lý thuyết")]
        public int SoTinChiLyThuyet { get; set; }

        [Display(Name = "Chuyên ngành")]
        public ChuyenNganh ChuyenNganh { get; set; }

        public virtual List<PhanCongGiangDay> PhanCongGiang { get; set; }

    }
}