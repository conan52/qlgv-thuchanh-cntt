using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace TkbThucHanhCNTT.Models.Viewer
{
    public class UserProfileViewModel
    {
        /* private string _maGv;

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
         [UIHint("QuyenHan")]
         public QuyenHan Role { get; set; }*/

        [Display(Name = "Tên giảng viên")]
        [HiddenInput(DisplayValue = false)]
        public string MaGv { get; set; }

        [Display(Name = "Tên đăng nhập")]
        [HiddenInput(DisplayValue = false)]
        public string TenDangNhap { get; set; }

        [UIHint("QuyenHan")]
        [Display(Name = "Quyền hạn")]
        public string QuyenHan { get; set; }

        [ScaffoldColumn(false)]
        public int UserId { get; set; }
    }
}