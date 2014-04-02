using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TkbThucHanh.Models.Enums;

namespace TkbThucHanh.Models
{
    public class GiangVien
    {
        [Key]
        [Required]
        public int GiangVienId { get; set; }

        [Required]
        [MaxLength(10)]
        [Display(Name = "Mã giảng viên")]
        public string MaGv { get; set; }


        public ChuyenNganh ChuyenNganh { get; set; }

        [Required]
        [Display(Name = "Tên giảng viên")]
        public string HoVaTen { get; set; }

        [Display(Name = "Nhận phân công")]
        public bool CoThePhanCong { get; set; }

        public virtual List<PhanCongGiangDay> PhanCongGiangDays { get; set; }

        public virtual List<PhanCongThucHanh> PhanCongThucHanhs { get; set; }

        public virtual List<TkbGangVien> TkbGangViens { get; set; }

        public virtual List<LichCongTac> LichCongTacs { get; set; }



        public int? UserProfileId { get; set; }
        [ForeignKey("UserProfileId")]
        public UserProfile UserProfile { get; set; }
    }
}
