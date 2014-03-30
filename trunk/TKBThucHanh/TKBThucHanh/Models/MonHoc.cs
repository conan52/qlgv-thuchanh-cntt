using System.ComponentModel.DataAnnotations;

namespace TKBThucHanh.Models
{
    public class MonHoc
    {
        [Key]
        public string MaMonHoc { get; set; }
        public string TenMonHoc { get; set; }
        public string ChuyenNganh { get; set; }
    }
}