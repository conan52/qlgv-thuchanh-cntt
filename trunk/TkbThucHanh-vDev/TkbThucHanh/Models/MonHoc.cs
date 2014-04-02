using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TkbThucHanh.Models.Enums;

namespace TkbThucHanh.Models
{
    public class MonHoc
    {
        [Key]
        public int MonHocId { get; set; }

        [Required(ErrorMessage = "Mã môn học không được để trống")]
        [Display(Name = "Mã môn học")]
        public string MaMonHoc { get; set; }

        [Display(Name = "Tên môn học")]
        public string TenMonHoc { get; set; }

        [Display(Name = "Số tín chỉ")]
        public int SoTinChi { get; set; }

        [Display(Name = "Bắt buộc")]
        public bool BatBuoc { get; set; }

        public TrinhDo TrinhDo { get; set; }
        public ChuyenNganh ChuyenNganh { get; set; }

        public virtual List<PhanCongGiangDay> PhanCongGiangDays { get; set; }

    }
}
