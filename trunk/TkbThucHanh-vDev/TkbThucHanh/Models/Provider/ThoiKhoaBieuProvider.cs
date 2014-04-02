using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace TkbThucHanh.Models.Provider
{
    public class ThoiKhoaBieuProvider
    {
        public static int GetLastTimeTable()
        {
            using (var context = new TkbThucHanhContext())
            {
                var tuanHoc = context.TuanHocs.OrderByDescending(t => t.NamHoc).ThenByDescending(t => t.SttTuan).LastOrDefault();
                if (tuanHoc == null)
                    return 0;
                return tuanHoc.SttTuan;
            }
        }
    }
}