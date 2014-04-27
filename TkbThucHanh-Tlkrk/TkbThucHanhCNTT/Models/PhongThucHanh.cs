using System.ComponentModel.DataAnnotations;

namespace TkbThucHanhCNTT.Models
{
    public class PhongThucHanh
    {
        [Key]
        [Display(Name = "Tên phòng")]
        [Required(ErrorMessage = "Tên phòng không được để trống!")]
        public string TenPhong { get; set; }
    }
}