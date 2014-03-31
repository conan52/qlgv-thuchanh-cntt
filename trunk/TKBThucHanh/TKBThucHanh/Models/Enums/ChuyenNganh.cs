using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TKBThucHanh.Models.Enums
{
    [TypeConverter(typeof(EnumToLocalizedName))]
    public enum ChuyenNganh
    {
        [Display(Description = "Cơ bản")]
        CoBan,
        [Display(Description = "Phần mềm")]
        CongNghePhanMem,
        [Display(Description = "Mạng")]
        MangTruyenThong
    }
}