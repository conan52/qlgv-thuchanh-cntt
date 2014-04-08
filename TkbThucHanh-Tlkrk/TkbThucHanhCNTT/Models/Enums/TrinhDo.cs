using System.ComponentModel;

namespace TkbThucHanhCNTT.Models.Enums
{
    public enum TrinhDo
    {
        [Description("")] Khac,
        [Description("Cao đẳng")] CaoDang,
        [Description("Đại học")] DaiHoc,
        [Description("Liên thông")] LienThong,
        [Description("Vừa học vừa làm")] VuaHocVuaLam,
    }
}