﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TkbThucHanh.Models
{
    public class LichCongTac
    {
        [Key]
        [Required]
        public int LichCongTacId { get; set; }


        [Display(Name = "Lý do")]
        public string LyDo { get; set; }

        [Display(Name = "Thời gian bắt đầu")]
        public DateTime? ThoiGianBd { get; set; }

        [Display(Name = "Thời gian kết thúc")]
        public DateTime? ThoiGianKt { get; set; }

        [Required]
        public int GiangVienId { get; set; }
        [ForeignKey("GiangVienId")]
        public virtual GiangVien GiangVien { get; set; }
    }
}