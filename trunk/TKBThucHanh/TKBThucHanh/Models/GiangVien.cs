using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TKBThucHanh.Models.Enums;

namespace TKBThucHanh.Models
{
    public class GiangVien
    {
        public GiangVien()
        {
            LichCongTac = new List<LichCongTac>();
            ThoiKhoaBieuGiangVien = new List<ThoiKhoaBieuGiangVien>();
        }

        [Key]
        [Required]
        public int GiangVienId { get; set; }

        [Required]
        [MaxLength(10)]
        [Display(Name = "Mã giảng viên")]
        public string MaGv { get; set; }

        [Required]
        [Display(Name = "Tên giảng viên")]
        public string HoVaTen { get; set; }

        [Display(Name = "Tài khoản đăng nhập")]
        public int? MaTaiKhoanDangNhap { get; set; }

        [Display(Name = "Chuyên ngành")]
        public ChuyenNganh ChuyenNganh { get; set; }

        [Display(Name = "Nhận phân công")]
        public bool CoThePhanCong { get; set; }

        [ForeignKey("MaTaiKhoanDangNhap")]
        public virtual UserProfile UserProfile { get; set; }

        public virtual ICollection<LichCongTac> LichCongTac { get; set; }
        public virtual ICollection<ThoiKhoaBieuGiangVien> ThoiKhoaBieuGiangVien { get; set; }
        public virtual ICollection<PhanCongGiangDay> PhanCongGiangDay { get; set; }


        [NotMapped]
        public string TaiKhoanDangNhap
        {
            get { return MaTaiKhoanDangNhap != null ? UserProfile.UserName : ""; }
        }
    }
}