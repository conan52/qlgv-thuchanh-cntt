using System.Collections.Generic;
using System.Linq;

namespace TkbThucHanhCNTT.Models.Provider
{
    public class GiangVienProvider
    {
        public static List<string> GetListTeacherCodes()
        {
            return DataProvider<GiangVien>.GetAll().Select(gv => gv.MaGv).ToList();
        }

        public static List<GiangVien> LayDsGiangVienCoTKB()
        {
            var dsTkb = DataProvider<TkbGiangVien>.GetAll().Select(tk => tk.MaGv).Distinct();

            return DataProvider<GiangVien>.GetAll().ToList().Where(g => dsTkb.Contains(g.MaGv)).ToList();
        }

        public static List<GiangVien> LayDsGiangVienCoTheXep()
        {
            return DataProvider<GiangVien>.GetAll().ToList();
          //  return DataProvider<GiangVien>.GetList(gv => gv.CoThePhanCong != null && gv.CoThePhanCong.Value).ToList();
        }
    }
}