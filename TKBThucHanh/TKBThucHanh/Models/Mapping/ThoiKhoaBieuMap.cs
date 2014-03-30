using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TkbThucHanh.Models.Mapping
{
    public class ThoiKhoaBieuMap : EntityTypeConfiguration<ThoiKhoaBieu>
    {
        public ThoiKhoaBieuMap()
        {
            // Primary Key
            this.HasKey(t => t.MaTKB);

            // Properties
            this.Property(t => t.TenMonHoc)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Lop)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Phong)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.GvDay)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("ThoiKhoaBieu");
            this.Property(t => t.MaTKB).HasColumnName("MaTKB");
            this.Property(t => t.TenMonHoc).HasColumnName("TenMonHoc");
            this.Property(t => t.Lop).HasColumnName("Lop");
            this.Property(t => t.Phong).HasColumnName("Phong");
            this.Property(t => t.TietBatDau).HasColumnName("TietBatDau");
            this.Property(t => t.TietKetThuc).HasColumnName("TietKetThuc");
            this.Property(t => t.GvDay).HasColumnName("GvDay");
            this.Property(t => t.NgayHoc).HasColumnName("NgayHoc");

            // Relationships
            this.HasRequired(t => t.GiangVien)
                .WithMany(t => t.ThoiKhoaBieux)
                .HasForeignKey(d => d.GvDay);
            this.HasRequired(t => t.Lop1)
                .WithMany(t => t.ThoiKhoaBieux)
                .HasForeignKey(d => d.Lop);
            this.HasRequired(t => t.MonHoc)
                .WithMany(t => t.ThoiKhoaBieux)
                .HasForeignKey(d => d.TenMonHoc);
            this.HasRequired(t => t.Phong1)
                .WithMany(t => t.ThoiKhoaBieux)
                .HasForeignKey(d => d.Phong);

        }
    }
}
