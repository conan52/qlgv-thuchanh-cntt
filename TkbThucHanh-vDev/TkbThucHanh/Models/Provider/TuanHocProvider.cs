using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TkbThucHanh.Models.Provider
{
    public class TuanHocProvider
    {
        public static void DanhDauDaLayDuLieu(int tuan, DateTime thuHai)
        {
            using (var db = new TkbThucHanhContext())
            {
                var tuanHoc = db.TuanHocs.Find(tuan);
                if (tuanHoc == null)
                    db.TuanHocs.Add(new TuanHoc() { DaLayThongTin = true, DaXepLichThucHanh = false, NgayBatDau = thuHai });
                else
                    tuanHoc.DaLayThongTin = true;
                db.SaveChanges();
            }
        }
    }
}