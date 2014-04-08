using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TkbThucHanhCNTT.Models.Ultils;

namespace TkbThucHanhCNTT.Models
{
    public class LichThucHanh
    {
        [Key]
        public int MaLichTh { get; set; }


        [Display(Name = "Tên môn học")]
        [Required(ErrorMessage = "Tên môn học không được để trống!")]
        public string TenMonHoc { get; set; }

        [Display(Name = "Phòng")]
        [Required(ErrorMessage = "Phòng không được để trống!")]
        public string Phong { get; set; }
        
        [Display(Name = "Lớp")]
        [Required(ErrorMessage = "Lớp không được để trống!")]
        public string TenLop { get; set; }

        [ForeignKey("TenLop")]
        public Lop Lop { get; set; }



        [Display(Name = "Tiết bắt đầu")]
        [Required(ErrorMessage = "Tiết bắt đầu không được để trống!")]
        public int TietBatDau { get; set; }

        [Display(Name = "Tiết kết thúc")]
        [Required(ErrorMessage = "Tiết kết th không được để trống!")]
        public int TietKetThuc { get; set; }

        [Display(Name = "Ngày học")]
        [Required(ErrorMessage = "Ngày học không được để trống!")]
        public DateTime NgayHoc { get; set; }
    }
}