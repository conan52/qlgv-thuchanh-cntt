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
                var tuanHoc = context.TuanHocs.OrderByDescending(t => t.NamHoc).ThenByDescending(t => t.SttTuan).ToList().LastOrDefault();
                if (tuanHoc == null)
                    return 0;
                return tuanHoc.SttTuan;
            }
        }

        public static List<TkbGiangVien> GetTeacherTimeTables(List<TeacherFullTable> tbs, DateTime monDay)
        {

            using (var context = new TkbThucHanhContext())
            {
                var tkb = from gvs in context.GiangViens.ToList()
                          join tb in tbs on gvs.MaGv equals tb.TeacherCode
                          select new TkbGiangVien()
                          {
                              NgayHoc = monDay.AddDays(tb.DayOfWeek),
                              Phong = tb.Room,
                              TenMonHoc = tb.Subject,
                              TietBatDau = tb.Start,
                              TietKetThuc = tb.End,
                              GiangVienId = gvs.GiangVienId,
                              LopHoc = tb.ClassCode
                          };
                return tkb.ToList();
            }

        }
    }
}