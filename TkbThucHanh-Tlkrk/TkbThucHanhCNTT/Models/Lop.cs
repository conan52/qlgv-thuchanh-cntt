using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;


namespace TkbThucHanhCNTT.Models
{
    public class Lop
    {
        [Key]
        [Required(ErrorMessage = "Tên lớp không được để trống!")]
        [Display(Name = "Tên lớp")]
        public string TenLop { get; set; }

        [Display(Name = "Trình độ")]
        [Required(ErrorMessage = "Trình độ không được để trống!")]
        [UIHint("TrinhDo")]
        public string TrinhDo { get; set; }

        [Display(Name = "Năm nhập học")]
        [Required(ErrorMessage = "Năm nhập học không được để trống!")]
        public int NamNhapHoc { get; set; }

        public List<PhanCongGiangDay> PhanCongGiang { get; set; }
    }
}