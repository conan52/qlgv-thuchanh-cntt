﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace TkbThucHanh.Models.Provider
{
    public class LopProvider
    {
        public static IList<Lop> LayDsLopChuaRaTruong()
        {
            return DataProvider<Lop>.GetList(l => l.NamNhapHoc >= DateTime.Now.Year - 5);
        }

        public static List<string> GetListCodes()
        {
            return DataProvider<Lop>.GetAll().Select(l => l.TenLop).ToList();
        }
    }
}