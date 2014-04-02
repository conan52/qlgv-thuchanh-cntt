using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TkbThucHanh.Models.Provider
{
    public class GiangVienProvider
    {
        public static List<string> GetListTeacherCodes()
        {
            return DataProvider<GiangVien>.GetAll().Select(gv => gv.MaGv).ToList();
        }
    }
}