using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TKBThucHanh.Models.Enums
{
    public enum TrinhDo
    {
        [Display(Description = "Cao đẳng")]
        CaoDang,
        [Display(Description = "Đại học")]
        DaiHoc,
        [Display(Description = "Liên thông")]
        LienThong,
        [Display(Description = "Vừa học vừa làm")]
        VuaHocVuaLam
    }
}