using System.Collections.Generic;
using TkbThucHanhCNTT.Models.Viewer;

namespace TkbThucHanhCNTT.Models.Provider
{
    public class ChamCongProvider
    {
        public static List<ChamCongViewModel> GetAll()
        {
            IList<LichThucHanh> dsLichTh = DataProvider<LichThucHanh>.GetAll(l => l.MonHoc, l => l.GiangVien1, l => l.GiangVien2, l => l.GiangVien3);
            var result = new List<ChamCongViewModel>();
            foreach (LichThucHanh lth in dsLichTh)
            {
                int soTiet = lth.TietKetThuc - lth.TietBatDau + 1;
                int tongSoNguoi = 1;
                if (lth.Gvhd2 != null)
                    tongSoNguoi++;
                if (lth.Gvhd3 != null)
                    tongSoNguoi++;

                int soNguoiCoMat = 0;
                if (lth.Gv1CoMat)
                    soNguoiCoMat++;
                if (lth.Gvhd2 != null && lth.Gv2CoMat)
                    soNguoiCoMat++;
                if (lth.Gvhd3 != null && lth.Gv3CoMat)
                    soNguoiCoMat++;

                if (soNguoiCoMat > 0)
                {
                    int tiet = soTiet*tongSoNguoi/soNguoiCoMat;

                    if (lth.Gv1CoMat)
                        result.Add(new ChamCongViewModel {MaGv = lth.Gvhd1, MonHocId = lth.MonHocId, SoTiet = tiet, TenLop = lth.TenLop, TenMonHoc = lth.MonHoc.TenThucHanh, TenGv = lth.GiangVien1.HoVaTen});
                    if (lth.Gvhd2 != null && lth.Gv2CoMat)
                        result.Add(new ChamCongViewModel {MaGv = lth.Gvhd2, MonHocId = lth.MonHocId, SoTiet = tiet, TenLop = lth.TenLop, TenMonHoc = lth.MonHoc.TenThucHanh, TenGv = lth.GiangVien2.HoVaTen});
                    if (lth.Gvhd3 != null && lth.Gv3CoMat)
                        result.Add(new ChamCongViewModel {MaGv = lth.Gvhd3, MonHocId = lth.MonHocId, SoTiet = tiet, TenLop = lth.TenLop, TenMonHoc = lth.MonHoc.TenThucHanh, TenGv = lth.GiangVien3.HoVaTen});
                }
            }
            return result;
        }
    }
}