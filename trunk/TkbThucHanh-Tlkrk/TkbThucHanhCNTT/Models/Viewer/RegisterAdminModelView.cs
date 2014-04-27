using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace TkbThucHanhCNTT.Models.Viewer
{
    public class RegisterAdminModelView
    {
        [Required(ErrorMessage = "Mã giảng viên không được để trống!")]
        [MaxLength(10)]
        [Display(Name = "Mã giảng viên")]
        public string MaGv { get; set; }

        [Required(ErrorMessage = "Tên giảng viên không được để trống!")]
        [Display(Name = "Tên giảng viên")]
        public string HoVaTen { get; set; }

        [HiddenInput(DisplayValue = false)]
        [Display(Name = "Tài khoản đăng nhập")]
        public string TaiKhoan { get; set; }

        [UIHint("QuyenHan")]
        [Display(Name = "Quyền hạn")]
        public string QuyenHan { get; set; }
    }
}