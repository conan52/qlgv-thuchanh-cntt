using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TkbThucHanh.Models
{
    public class PhongThucHanh
    {
        [Key]
        public int PhongThucHanhId { get; set; }

        [Display(Name = "Tên phòng")]
        [Required(ErrorMessage = "Tên phòng không được để trống!")]
        public string TenPhong { get; set; }

        public virtual List<TkbThucHanh> TkbThucHanhs { get; set; }
    }
}