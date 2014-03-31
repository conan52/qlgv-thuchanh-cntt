using System.ComponentModel.DataAnnotations;

namespace TKBThucHanh.Models
{
    public class MonHoc
    {
        [Key]
        public int MonHocId { get; set; }
        
        [Required(ErrorMessage = "Mã môn học không được để trống")]
        [Display(Name = "Mã môn học")]
        public string MaMonHoc { get; set; }

        [Display(Name = "Tên môn học")]
        public string TenMonHoc { get; set; }

        [Display(Name = "Chuyên ngành")]
        public string ChuyenNganh { get; set; }
    }
}