using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TkbThucHanh.Models.Enums;

namespace TkbThucHanh.Models
{
    public class GiangVien
    {
        [Key]
        public int GiangVienId { get; set; }

        [Required(ErrorMessage = "Mã giảng viên không được để trống!")]
        [MaxLength(10)]
        [Display(Name = "Mã giảng viên")]
        public string MaGv { get; set; }

        [Required(ErrorMessage = "Chuyên nghành không được để trống!")]
        [Display(Name = "Chuyên nghành")]
        public ChuyenNganh ChuyenNganh { get; set; }

        [Required(ErrorMessage = "Tển giảng viên không được để trống!")]
        [Display(Name = "Tên giảng viên")]
        public string HoVaTen { get; set; }

        [Display(Name = "Nhận phân công")]
        public bool? CoThePhanCong { get; set; }

        public virtual List<PhanCongGiangDay> PhanCongGiangDays { get; set; }

        public virtual List<PhanCongThucHanh> PhanCongThucHanhs { get; set; }

        public virtual List<TkbGiangVien> TkbGangViens { get; set; }

        public virtual List<LichCongTac> LichCongTacs { get; set; }


        public int? UserProfileId { get; set; }

        [ForeignKey("UserProfileId")]
        public UserProfile UserProfile { get; set; }
    }
}