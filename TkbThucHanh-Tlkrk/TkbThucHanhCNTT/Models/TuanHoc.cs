using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TkbThucHanhCNTT.Models
{
    public class TuanHoc
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "STT Tuần")]
        [Required(ErrorMessage = "Tuần học không được để trống!")]
        [Range(1, 53, ErrorMessage = "Tuần học phải là số thuộc khoảng 1 -> 52")]
        public int SttTuan { get; set; }

        //[Display(Name = "Năm học")]
        //[Required(ErrorMessage = "Năm học không được để trống!")]
        //[Range(2000, 2099, ErrorMessage = "Năm học không hợp lệ!")]
        //public int NamHoc { get; set; }

        [Display(Name = "Ngày bắt đầu")]
        [Required(ErrorMessage = "Ngày bắt đầu không được để trống!")]
        public DateTime NgayBatDau { get; set; }

        [Display(Name = "Ngày kết thúc")]
        [NotMapped]
        public DateTime NgayKetThuc
        {
            get { return NgayBatDau.AddDays(7); }
        }

        [Display(Name = "Đã lấy thông tin")]
        public bool DaLayThongTin { get; set; }

        [Display(Name = "Đã xếp lịch thực hành")]
        public bool DaXepLichThucHanh { get; set; }

        public virtual List<TkbGiangVien> TkbGiangViens { get; set; }
        public virtual List<LichThucHanh> LichThucHanhs { get; set; }
        public virtual List<LichBan> LichBans { get; set; }
    }
}