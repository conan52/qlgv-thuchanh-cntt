﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TKBThucHanh.Models
{
    public class TuanHoc
    {
        [Key]
        public int TuanHocId { get; set; }

        [Display(Name = "STT Tuần")]
        public int SttTuan { get; set; }

        [Display(Name = "Năm học")]
        [Range(2000,2099)]
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