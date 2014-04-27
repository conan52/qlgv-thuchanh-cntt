﻿using System.ComponentModel.DataAnnotations;

namespace TkbThucHanhCNTT.Models.Viewer
{
    public class ChamCongGrouped
    {
        [Display(Name = "Nhóm")]
        public string Nhom { get; set; }

        [Display(Name = "Giảng viên")]
        public string TenGv { get; set; }

        [Display(Name = "Số tiết")]
        public int TongSoTiet { get; set; }
    }
}