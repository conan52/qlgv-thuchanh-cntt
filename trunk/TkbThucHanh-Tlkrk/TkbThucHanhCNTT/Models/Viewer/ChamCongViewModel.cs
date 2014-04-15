using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TkbThucHanhCNTT.Models.Viewer
{
    public class ChamCongViewModel
    {
        public int MonHocId { get; set; }
        public string TenLop { get; set; }
        public string MaGv { get; set; }
        public int SoTiet { get; set; }


        public string TenGv { get; set; }
        public string TenMonHoc { get; set; }
    }
}