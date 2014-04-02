using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DevExpress.Web.ASPxHtmlEditor.Internal;
using TkbThucHanh.Models.Enums;

namespace TkbThucHanh.Models
{
    public class MonHoc
    {
        [Key]
        public int MonHocId { get; set; }

        [Required(ErrorMessage = "Mã môn học không được để trống!")]
        [Display(Name = "Mã môn học")]
        public string MaMonHoc { get; set; }

        [Display(Name = "Tên môn học")]
        [Required(ErrorMessage = "Tên môn học không được để trống!")]
        public string TenMonHoc { get; set; }

        [Required(ErrorMessage = "Số tín chỉ không được viên")]
        [Display(Name = "Số tín chỉ")]
        public int SoTinChi { get; set; }

        [Display(Name = "Bắt buộc")]
        public bool? BatBuoc { get; set; }

        public TrinhDo TrinhDo { get; set; }
        public ChuyenNganh ChuyenNganh { get; set; }

        public virtual List<PhanCongGiangDay> PhanCongGiangDays { get; set; }


        [NotMapped]
        public string HienThiTrinhDo
        {
            get { return EnumUltils.GetDescriptionAttribute<TrinhDo>(TrinhDo.ToString()); }
        }

        [NotMapped]
        public string HienThiChuyenNganh
        {
            get { return EnumUltils.GetDescriptionAttribute<ChuyenNganh>(ChuyenNganh.ToString()); }
        }

        [NotMapped]
        public string HienThiBatBuoc
        {
            get
            {
                if (BatBuoc != null && BatBuoc.Value)
                    return "BB";
                return "TC";
            }
        }
    }
}