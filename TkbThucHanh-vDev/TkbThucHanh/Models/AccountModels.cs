using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace TkbThucHanh.Models
{
    [Table("UserProfile")]
    public class UserProfile
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [Display(Name = "Tên đăng nhập")]
        public string UserName { get; set; }

        public string Email { get; set; }
        [Display(Name = "Tên hiển thị")]
        public string DisplayName { get; set; }

         [Display(Name = "Quyền hạng")]
        public string Role { get; set; }
    }


    public class ChangePasswordModel
    {
        [Required(ErrorMessage = "Mật khẩu cũ không được để trống!")]
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu cũ")]
        public string OldPassword { get; set; }

        [Required(ErrorMessage = "Mật khẩu cũ không được để trống!")]
        [StringLength(100, ErrorMessage = "Mật khẩu chỉ được từ {0} đến {2} ký tự.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu mới")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Nhập lại mật nhẩu mới không được để trống!")]
        [Display(Name = "Nhập lại mật nhẩu mới")]
        [Compare("NewPassword", ErrorMessage = "Mật khẩu mới không trùng khớp.")]
        public string ConfirmPassword { get; set; }
    }

    public class LoginModel
    {
        private bool? rememberMe;

        [Required(ErrorMessage = "Tên đăng nhập không được để trống!")]
        [Display(Name = "Tên đăng nhập")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Mật khẩu không được để trống!")]
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu")]
        public string Password { get; set; }

        [Display(Name = "Ghi nhớ?")]
        public bool? RememberMe
        {
            get { return rememberMe ?? false; }
            set { rememberMe = value; }
        }
    }

    public class RegisterModel
    {
        [Required(ErrorMessage = "Tên đăng nhập không được để trống!")]
        [Display(Name = "Tên đăng nhập")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Địa chỉ Email không được để trống!")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Địa chỉ Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Mật khẩu không được để trống!")]
        [StringLength(100, ErrorMessage = "Mật khẩu chỉ được từ {0} đến {2} ký tự.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Nhập lại mật khẩu không được để trống!")]
        [Display(Name = "Nhập lại mật khẩu")]
        [Compare("Password", ErrorMessage = "Mật khẩu mới không trùng khớp.")]
        public string ConfirmPassword { get; set; }
    }
}