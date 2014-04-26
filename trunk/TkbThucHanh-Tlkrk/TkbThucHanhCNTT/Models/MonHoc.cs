using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TkbThucHanhCNTT.Models.Enums;

namespace TkbThucHanhCNTT.Models
{
    public class MonHoc
    {
        [Key]
        [ScaffoldColumn(false)]
        public int MonHocId { get; set; }

        [Required(ErrorMessage = "Mã môn học không được để trống!")]
        [Display(Name = "Mã môn học")]
        public string MaMonHoc { get; set; }

        [Display(Name = "Tên môn học")]
        [Required(ErrorMessage = "Tên môn học không được để trống!")]
        public string TenMonHoc { get; set; }

        [UIHint("Integer")]
        [Required(ErrorMessage = "Số tín chỉ không được để trống!")]
        [Display(Name = "Số tín chỉ")]
        public int SoTinChi { get; set; }

        [Display(Name = "Bắt buộc")]
        public bool BatBuoc { get; set; }

        [Required(ErrorMessage = "Trình độ không được để trống!")]
        [Display(Name = "Trình độ")]
        [UIHint("TrinhDoInt")]
        public TrinhDo TrinhDo { get; set; }

        [Required(ErrorMessage = "Chuyên ngành không được để trống!")]
        [Display(Name = "Chuyên ngành")]
        [UIHint("ChuyenNganh")]
        public ChuyenNganh ChuyenNganh { get; set; }

        [NotMapped]
        [ScaffoldColumn(false)]
        public string TenThucHanh
        {
            get { return "TH. " + TenMonHoc; }
        }

        public virtual List<PhanCongGiangDay> PhanCongGiangDays { get; set; }
    }
}