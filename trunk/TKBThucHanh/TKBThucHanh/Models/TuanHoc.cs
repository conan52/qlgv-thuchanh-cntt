using System;
using System.ComponentModel.DataAnnotations;

namespace TKBThucHanh.Models
{
    public class TuanHoc
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Display(Name = "STT Tuần")]
        public int SttTuan { get; set; }
        [Display(Name = "Năm học")]
        public string NamHoc { get; set; }
        [Display(Name = "Ngày bắt đầu")]
        public DateTime? NgayBatDau { get; set; }
        [Display(Name = "Ngày kết thúc")]
        public DateTime? NgayKetThuc { get; set; }
        [Display(Name = "Đã lấy thông tin")]
        public bool? DaLayThongTin { get; set; }
        [Display(Name = "Đã xếp lịch thực hành")]
        public bool? DaXepLichThucHanh { get; set; }
    }
}