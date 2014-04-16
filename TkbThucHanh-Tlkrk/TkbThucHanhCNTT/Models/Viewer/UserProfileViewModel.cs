using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TkbThucHanhCNTT.Models.Enums;
using TkbThucHanhCNTT.Models.Provider;

namespace TkbThucHanhCNTT.Models.Viewer
{
    public class UserProfileViewModel
    {
        private string _maGv;

        [HiddenInput(DisplayValue = false)]
        [ScaffoldColumn(false)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        //        [UIHint("GiangVien")]
        //        [Required(ErrorMessage = "Giáo viên không được để trống!")]
        //        [Display(Name = "Mã giảng viên")]
        //        public string MaGv { get; set; }
        [HiddenInput(DisplayValue = false)]
        [Display(Name = "Tên giảng viên")]
        public string MaGv
        {
            get
            {
                return _maGv;
            }
            set { _maGv = value; }
        }

        [HiddenInput(DisplayValue = false)]
        [Required(ErrorMessage = "Tên đăng nhập không được để trống!")]
        [Display(Name = "Tên đăng nhập")]
        public string UserName { get; set; }

        [HiddenInput(DisplayValue = false)]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Địa chỉ email không hợp lệ")]
        public string Email { get; set; }

        [Display(Name = "Quyền hạn")]
        [UIHint("Quyenhan")]
        public QuyenHan Role { get; set; }
    }
}