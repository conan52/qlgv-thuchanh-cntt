using System;

namespace TkbThucHanh.Models.Ultils
{
    public static class StaticUltils
    {
        public static string LayThu(this DateTime date)
        {
            switch (date.DayOfWeek)
            {
                case System.DayOfWeek.Sunday:
                    return "Chủ nhật";

                case System.DayOfWeek.Monday:
                    return "Thứ hai";

                case System.DayOfWeek.Tuesday:
                    return "Thứ ba";

                case System.DayOfWeek.Wednesday:
                    return "Thứ tư";

                case System.DayOfWeek.Thursday:
                    return "Thứ năm";

                case System.DayOfWeek.Friday:
                    return "Thứ sáu";

                case System.DayOfWeek.Saturday:
                    return "Thứ bảy";
                default:
                    return "";
            }

        }
    }
}