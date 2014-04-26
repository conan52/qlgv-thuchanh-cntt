using System.ComponentModel;

namespace TkbThucHanhCNTT.Models.Enums
{
    public enum TrinhDo
    {
        [Description("")]
        Khac =0,
        [Description("Cao đẳng")]
        CaoDang = 1,
        [Description("Đại học")]
        DaiHoc = 2,
        [Description("Liên thông")]
        LienThong = 3,
        [Description("Vừa học vừa làm")]
        VuaHocVuaLam = 4,
    }
}