using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using DluWebHelper;

namespace TkbThucHanh.Models.Provider
{
    public class ThoiKhoaBieuProvider
    {
        public static int GetLastTimeTable()
        {
            using (var context = new TkbThucHanhContext())
            {
                var tuanHoc = context.TuanHocs.OrderByDescending(t => t.SttTuan).ToList().LastOrDefault();
                if (tuanHoc == null)
                    return 0;
                return tuanHoc.SttTuan;
            }
        }

        public static List<TkbGiangVien> GetTeacherTimeTables(List<TeacherFullTable> tbs, DateTime monDay, int week)
        {
            var tkb = from tb in tbs
                      select new TkbGiangVien()
                      {
                          NgayHoc = monDay.AddDays(tb.DayOfWeek),
                          Phong = tb.Room,
                          TenMonHoc = tb.Subject,
                          TietBatDau = tb.Start,
                          MaGv = tb.TeacherCode,
                          LopHoc = tb.ClassCode,
                          TuanHoc = week
                      };
            return tkb.ToList();
        }
    }
}