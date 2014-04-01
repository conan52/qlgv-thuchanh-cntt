using System.ComponentModel;

namespace TKBThucHanh.Models.Enums
{
    public enum TrinhDo
    {
        [Description("Cao đẳng")]
        CaoDang,
        [Description("Đại học")]
        DaiHoc,
        [Description("Liên thông")]
        LienThong,
        [Description("Vừa học vừa làm")]
        VuaHocVuaLam
    }
}