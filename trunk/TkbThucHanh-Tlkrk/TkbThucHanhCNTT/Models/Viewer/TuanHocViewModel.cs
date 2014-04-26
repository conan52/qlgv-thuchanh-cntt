using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TkbThucHanhCNTT.Models.Viewer
{
    public class TuanHocViewModel
    {
        [KeyAttribute]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "STT Tuần")]
        [Required(ErrorMessage = "Tuần học không được để trống!")]
        [Range(1, 53, ErrorMessage = "Tuần học phải là số thuộc khoảng 1 -> 53")]
        public int SttTuan { get; set; }

        [Display(Name = "Ngày bắt đầu")]
        [Required(ErrorMessage = "Ngày bắt đầu không được để trống!")]
        public DateTime NgayBatDau { get; set; }

        [Display(Name = "Ngày kết thúc")]
        public DateTime NgayKetThuc { get; set; }

        [Display(Name = "Đã lấy thông tin")]
        public bool DaLayThongTin { get; set; }

        [Display(Name = "Đã xếp lịch thực hành")]
        public bool DaXepLichThucHanh { get; set; }
    }
}