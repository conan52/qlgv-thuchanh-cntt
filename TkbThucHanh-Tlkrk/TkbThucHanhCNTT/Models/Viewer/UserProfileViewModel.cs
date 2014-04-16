using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using TkbThucHanhCNTT.Models.Enums;

namespace TkbThucHanhCNTT.Models.Viewer
{
    public class UserProfileViewModel
    {
        [ScaffoldColumn(false)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [UIHint("GiangVien")]
        [Required(ErrorMessage = "Giáo viên không được để trống!")]
        [Display(Name = "Mã giảng viên")]
        public string MaGv { get; set; }

        [Required(ErrorMessage = "Tên đăng nhập không được để trống!")]
        [Display(Name = "Tên đăng nhập")]
        public string UserName { get; set; }

        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Địa chỉ email không hợp lệ")]
        public string Email { get; set; }

        [Display(Name = "Quyền hạn")]
        [UIHint("Quyenhan")]
        public QuyenHan Role { get; set; }
    }
}