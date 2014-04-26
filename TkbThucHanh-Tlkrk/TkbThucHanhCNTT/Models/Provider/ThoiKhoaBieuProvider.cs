using System;
using System.Collections.Generic;
using System.Linq;
using DluWebHelper;

namespace TkbThucHanhCNTT.Models.Provider
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
        
        public static List<TuanHoc> LayTuanChuaXepLichThucHanh()
        {
          return  DataProvider<TuanHoc>.GetList(tuan =>  !tuan.DaXepLichThucHanh)
               .ToList();
        }


    }
}