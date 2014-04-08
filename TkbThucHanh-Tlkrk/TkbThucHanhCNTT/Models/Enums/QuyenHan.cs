using System.ComponentModel;

namespace TkbThucHanhCNTT.Models.Enums
{
    public enum QuyenHan
    {
        [Description("Bị khóa")] Blocked = 1,
        [Description("Giảng viên")] Teacher,
        [Description("Admin")] Admin,
        [Description("Giảng viên + Admin")] AdminTeacher,
    }
}