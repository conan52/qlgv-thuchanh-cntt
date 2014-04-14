﻿using System.ComponentModel;

namespace TkbThucHanh.Models.Enums
{
    public enum QuyenHan
    {
        [Description("Bị khóa")] Blocked = 1,
        [Description("Giảng viên")] Teacher,
        [Description("Admin")] Admin,
        [Description("Giảng viên + Admin")] AdminTeacher,
    }
}