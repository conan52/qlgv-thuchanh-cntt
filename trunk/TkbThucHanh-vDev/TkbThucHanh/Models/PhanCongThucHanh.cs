using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TkbThucHanh.Models
{
    public class PhanCongThucHanh
    {
        [Key]
        public int PhanCongThucHanhId { get; set; }

        public virtual List<TkbThucHanh> TkbThucHanhs { get; set; }

        public int GiangVienId { get; set; }

        [ForeignKey("GiangVienId")]
        public virtual GiangVien GiangVien { get; set; }
    }
}