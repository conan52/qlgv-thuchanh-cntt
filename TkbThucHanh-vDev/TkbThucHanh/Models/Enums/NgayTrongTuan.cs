using System.ComponentModel;

namespace TkbThucHanh.Models.Enums
{
    public enum NgayTrongTuan
    {
        [Description("Thứ hai")] ThuHai = 1,
        [Description("Thứ ba")] ThuBa = 2,
        [Description("Thứ tư")] ThuTu = 3,
        [Description("Thứ năm")] ThuNam = 4,
        [Description("Thứ sáu")] ThuSau = 5,
        [Description("Thứ bảy")] ThuBay = 6,
        [Description("Chủ nhật")] ChuNhat = 0
    }
}