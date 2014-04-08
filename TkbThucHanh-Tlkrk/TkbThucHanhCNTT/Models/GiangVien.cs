﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TkbThucHanhCNTT.Models.Enums;
using TkbThucHanhCNTT.Models.Ultils;

namespace TkbThucHanhCNTT.Models
{
    public class GiangVien
    {
        [Key]
        [Required(ErrorMessage = "Mã giảng viên không được để trống!")]
        [MaxLength(10)]
        [Display(Name = "Mã giảng viên")]
        public string MaGv { get; set; }

        [Required(ErrorMessage = "Chuyên ngành không được để trống!")]
        [Display(Name = "Chuyên ngành")]
    //    [UIHint("ChuyenNganh")]
        public ChuyenNganh ChuyenNganh { get; set; }

        [Required(ErrorMessage = "Tên giảng viên không được để trống!")]
        [Display(Name = "Tên giảng viên")]
        public string HoVaTen { get; set; }

        [Display(Name = "Nhận phân công")]
        public bool CoThePhanCong { get; set; }


        public int? UserProfileId { get; set; }

        [ScaffoldColumn(false)]
        [ForeignKey("UserProfileId")]
        public UserProfile UserProfile { get; set; }


        [NotMapped]
        [ScaffoldColumn(false)]
        public string TenNganGon
        {
            get { return HoVaTen.LayTenVietTat(); }
        }

        //[NotMapped]
        //[Display(Name = "Tên chuyên ngành")]
        //public string TenChuyenNganh
        //{
        //    get { return ChuyenNganh.GetDescriptionAttribute(); }
        //    set
        //    {
        //        if(value!=null)
        //        ChuyenNganh = (ChuyenNganh)Enum.Parse(typeof(ChuyenNganh), value);
        //    }
        //}
    }
}