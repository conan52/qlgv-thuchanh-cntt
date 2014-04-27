using System;
using System.Collections.Generic;
using System.Linq;

namespace TkbThucHanhCNTT.Models.Provider
{
    public class LopProvider
    {
        public static IList<Lop> LayDsLopChuaRaTruong()
        {
            return DataProvider<Lop>.GetList(l => l.NamNhapHoc >= DateTime.Now.Year - 5);
        }

        public static List<Lop> LayDsLop()
        {
            return DataProvider<Lop>.GetAll().OrderByDescending(l => l.NamNhapHoc).ToList();
        }

        public static List<string> GetListCodes()
        {
            return DataProvider<Lop>.GetAll().Select(l => l.TenLop).ToList();
        }
    }
}