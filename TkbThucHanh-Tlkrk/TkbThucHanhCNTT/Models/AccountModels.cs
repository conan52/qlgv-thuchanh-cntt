using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace TkbThucHanhCNTT.Models
{
    [Table("UserProfile")]
    public class UserProfile
    {
        private string _role;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Giáo viên không được để trống!")]
        public string MaGv { get; set; }

        [Required(ErrorMessage = "Tên đăng nhập không được để trống!")]
        [Display(Name = "Tên đăng nhập")]
        public string UserName { get; set; }

        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Địa chỉ email không hợp lệ")]
        public string Email { get; set; }
        //[Display(Name = "Tên hiển thị")]
        //public string DisplayName { get; set; }

        //        [Required(ErrorMessage = "Phải chọn quyền cho tài khoản!")]
        [Display(Name = "Quyền hạn")]
        public string Role
        {
            get { return _role; }
            set
            {
                if (value == null)
                    value = "Blocked";
                else
                    _role = value;
            }
        }
    }

    public class RegisterExternalLoginModel
    {
        [Required]
        [Display(Name = "Tên đăng nhập")]
        public string UserName { get; set; }

        public string ExternalLoginData { get; set; }
    }

    public class LocalPasswordModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu cũ")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Mật khẩu phải từ {0} đến {2} ký tự.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu mới")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Nhập lại mật khẩu mới")]
        [Compare("NewPassword", ErrorMessage = "Nhập lại mật khẩu mới không khớp.")]
        public string ConfirmPassword { get; set; }
    }

    public class LoginModel
    {
        [Required]
        [Display(Name = "Tên đăng nhập")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu")]
        public string Password { get; set; }

        [Display(Name = "Ghi nhớ?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterModel
    {
        [Required]
        [Display(Name = "Tên đăng nhập")]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Mật khẩu phải từ {0} đến {2} ký tự.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẩu")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Nhập lại mật khẩu mới")]
        [Compare("Password", ErrorMessage = "Nhập lại mật khẩu mới không khớp.")]
        public string ConfirmPassword { get; set; }
    }

    public class ExternalLogin
    {
        public string Provider { get; set; }
        public string ProviderDisplayName { get; set; }
        public string ProviderUserId { get; set; }
    }
}
