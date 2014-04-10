using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TkbThucHanhCNTT.Models.Viewer
{
    public class TietHoc
    {
        public int TietBatDau { get; set; }
        public int TietKetThuc { get; set; }

        public TietHoc()
        {
            TietBatDau = 1;
            TietKetThuc = 4;
        }

        public override string ToString()
        {
            return string.Format("{0}-{1}", TietBatDau, TietKetThuc);
        }
    }
}