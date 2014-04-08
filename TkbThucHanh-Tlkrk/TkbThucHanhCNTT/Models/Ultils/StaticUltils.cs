using System;
using System.Linq;
using TkbThucHanhCNTT.Models.Enums;

namespace TkbThucHanhCNTT.Models.Ultils
{
    public static class StaticUltils
    {
        public static NgayTrongTuan LayThu(this DayOfWeek dayOfWeek)
        {
            return (NgayTrongTuan)dayOfWeek;
        }

        public static string LayThu(this DateTime date)
        {
            switch (date.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    return "Chủ nhật";
                case DayOfWeek.Monday:
                    return "Thứ hai";
                case DayOfWeek.Tuesday:
                    return "Thứ ba";
                case DayOfWeek.Wednesday:
                    return "Thứ tư";
                case DayOfWeek.Thursday:
                    return "Thứ năm";
                case DayOfWeek.Friday:
                    return "Thứ sáu";
                case DayOfWeek.Saturday:
                    return "Thứ bảy";
                default:
                    return "";
            }
        }


        public static string LayTen(this string tenDayDu)
        {
            return tenDayDu.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Last();
        }

        public static string LayTenVietTat(this string tenDayDu)
        {
            if (tenDayDu == null) return "";
            var split = tenDayDu.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var s = "";
            for (var i = 0; i < split.Count()-1; i++)
            {
                s += split[i][0];
            }
            return s + " " + split.Last();
        }

        public static DateTime Monday(this DateTime curr)
        {
            return curr.AddDays(-(int)curr.DayOfWeek + 1);
        }
    }
}