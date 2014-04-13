using System;
using TkbThucHanhCNTT.Models.Enums;

namespace TkbThucHanhCNTT.Models.Provider
{
    public class TuanHocProvider
    {
        public static void DanhDauDaLayDuLieu(int tuan, DateTime thuHai)
        {
            using (var db = new TkbThucHanhContext())
            {
                var tuanHoc = db.TuanHocs.Find(tuan);
                if (tuanHoc == null)
                    db.TuanHocs.Add(new TuanHoc() { DaLayThongTin = true, DaXepLichThucHanh = false, NgayBatDau = thuHai,SttTuan = tuan});
                else
                    tuanHoc.DaLayThongTin = true;
                db.SaveChanges();
            }
        }

        public static DateTime LayNgayHoc(int tuan, NgayTrongTuan ngay)
        {
            var t2 = DataProvider<TuanHoc>.GetSingle(t => t.SttTuan == tuan).NgayBatDau;
            return t2.AddDays((int) ngay);
        }
    }
}