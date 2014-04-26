﻿using System.ComponentModel.DataAnnotations;

namespace TkbThucHanhCNTT.Models.Viewer
{
    public class LichBanModelViewer
    {
        [ScaffoldColumn(false)]
        public int LichBanId { get; set; }

        [Display(Name = "Tuần")]
        public int SttTuan { get; set; }

        [Display(Name = "Tên giảng viên")]
        public string TenGv { get; set; }

        [Display(Name = "Số buổi bận")]
        public int SoBuoiBan { get; set; }

        [Display(Name = "Số buổi rảnh")]
        public int SoBuoiRanh { get; set; }
    }
}