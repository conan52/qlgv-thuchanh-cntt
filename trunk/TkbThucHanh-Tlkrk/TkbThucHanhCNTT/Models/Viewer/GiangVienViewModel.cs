﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using TkbThucHanhCNTT.Models.Enums;

namespace TkbThucHanhCNTT.Models.Viewer
{
    public class GiangVienViewModel
    {
        [Key]
        [Required(ErrorMessage = "Mã giảng viên không được để trống!")]
        [MaxLength(10)]
        [Display(Name = "Mã giảng viên")]
        public string MaGv { get; set; }

        [Required(ErrorMessage = "Tên giảng viên không được để trống!")]
        [Display(Name = "Tên giảng viên")]
        public string HoVaTen { get; set; }

        [Display(Name = "Hoạt động")]
        public bool CoThePhanCong { get; set; }

        [Required(ErrorMessage = "Chuyên ngành không được để trống!")]
        [Display(Name = "Chuyên ngành")]
        [UIHint("ChuyenNganh")]
        public ChuyenNganh ChuyenNganh { get; set; }

//        [Required(ErrorMessage = "Tài khoản đăng nhập")]
        [Display(Name = "Tài khoản đăng nhập")]
        public string TaiKhoan { get; set; }
    }
}