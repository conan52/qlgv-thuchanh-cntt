using System;
using System.Linq;
using TkbThucHanh.Models.Enums;

namespace TkbThucHanh.Models.Ultils
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
            var split = tenDayDu.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            string s = "";
            for (int i = 0; i < split.Count()-1; i++)
            {
                s += split[i][0];
            }
            return s + " " + split.Last();
        }
    }
}