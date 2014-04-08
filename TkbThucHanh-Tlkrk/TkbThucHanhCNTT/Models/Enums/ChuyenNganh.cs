using System.ComponentModel;

namespace TkbThucHanhCNTT.Models.Enums
{
    public enum ChuyenNganh
    {
        [Description("Cơ bản")]
        CoBan = 0,
        [Description("Phần mềm")]
        CongNghePhanMem = 1,
        [Description("Mạng")]
        MangTruyenThong = 2
    }
}