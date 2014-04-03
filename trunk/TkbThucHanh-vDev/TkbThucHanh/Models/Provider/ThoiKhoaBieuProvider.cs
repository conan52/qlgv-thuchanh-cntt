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
        public static int LayTkbCuNhat()
        {
            using (var context = new TkbThucHanhContext())
            {
                var tuanHoc = context.TuanHocs.OrderByDescending(t => t.SttTuan).ToList().LastOrDefault();
                if (tuanHoc == null)
                    return 0;
                return tuanHoc.SttTuan;
            }
        }



        public static List<TkbGiangVien> LayTkbGiangVien(List<TeacherFullTable> tbs, DateTime monDay, int week)
        {
            var tkb = from tb in tbs
                      select new TkbGiangVien
                      {
                          NgayHoc = monDay.AddDays(tb.DayOfWeek),
                          Phong = tb.Room,
                          TenMonHoc = tb.Subject,
                          TietBatDau = tb.Start,
                          TietKetThuc = tb.End,
                          MaGv = tb.TeacherCode,
                          LopHoc = tb.ClassCode,
                          TuanHoc = week
                      };
            return tkb.ToList();
        }

        public static List<TuanHoc> LayTuanChuaXepLichThucHanh()
        {
          return  DataProvider<TuanHoc>.GetList(tuan => tuan.DaXepLichThucHanh == null || !tuan.DaXepLichThucHanh.Value)
               .ToList();
        }
    }
}