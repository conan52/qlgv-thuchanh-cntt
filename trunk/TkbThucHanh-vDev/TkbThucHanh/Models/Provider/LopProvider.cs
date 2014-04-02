using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TkbThucHanh.Models.Provider
{
    public class LopProvider
    {

        public static IList<Lop> LayDsLopChuaRaTruong()
        {
            return DataProvider<Lop>.GetList(l => l.NamNhapHoc >= DateTime.Now.Year - 5);
        }
    }
}