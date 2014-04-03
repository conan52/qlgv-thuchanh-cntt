using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TkbThucHanh.Models.Viewer;

namespace TkbThucHanh.Models.Provider
{
    public class LichThucHanhProvider
    {
        public static List<LichThucHanhTongQuan> LayDsTongQuan()
        {
         return   DataProvider<TkbThucHanh>.GetAll().Select(tk => (LichThucHanhTongQuan) tk).ToList();
        }
    }
}