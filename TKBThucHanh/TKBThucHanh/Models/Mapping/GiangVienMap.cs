using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TkbThucHanh.Models.Mapping
{
    public class GiangVienMap : EntityTypeConfiguration<GiangVien>
    {
        public GiangVienMap()
        {
            // Primary Key
            this.HasKey(t => t.MaGV);

            // Properties
            this.Property(t => t.MaGV)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.TenDayDu)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TenHienThi)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.ChuyenNganh)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("GiangVien");
            this.Property(t => t.MaGV).HasColumnName("MaGV");
            this.Property(t => t.TenDayDu).HasColumnName("TenDayDu");
            this.Property(t => t.TenHienThi).HasColumnName("TenHienThi");
            this.Property(t => t.ChuyenNganh).HasColumnName("ChuyenNganh");
            this.Property(t => t.CongTac).HasColumnName("CongTac");
            this.Property(t => t.Enable).HasColumnName("Enable");
        }
    }
}
