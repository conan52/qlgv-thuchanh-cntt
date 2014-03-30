using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TkbThucHanh.Models.Mapping
{
    public class TuanHocMap : EntityTypeConfiguration<TuanHoc>
    {
        public TuanHocMap()
        {
            // Primary Key
            this.HasKey(t => t.SoTuan);

            // Properties
            this.Property(t => t.SoTuan)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NamHoc)
                .HasMaxLength(10);

            this.Property(t => t.HocKy)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("TuanHoc");
            this.Property(t => t.SoTuan).HasColumnName("SoTuan");
            this.Property(t => t.NamHoc).HasColumnName("NamHoc");
            this.Property(t => t.HocKy).HasColumnName("HocKy");
            this.Property(t => t.NgayBatDau).HasColumnName("NgayBatDau");
            this.Property(t => t.NgayKetThuc).HasColumnName("NgayKetThuc");
        }
    }
}
