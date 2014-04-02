using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TkbThucHanh.Models
{
    public class Lop
    {
        [Key]
        public int LopId { get; set; }
        [Required(ErrorMessage = "Tên lớp không được để trống")]
        [Display(Name = "Tên lớp")]
        public string TenLop { get; set; }
        [Display(Name = "Trình độ")]
        public string TrinhDo { get; set; }
        [Display(Name = "Năm nhập học")]
        public int NamNhapHoc { get; set; }

        public List<PhanCongGiangDay> PhanCongGiang { get; set; }

        public virtual List<TkbThucHanh> TkbThucHanhs { get; set; }
    }
}
