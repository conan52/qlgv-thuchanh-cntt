using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TkbThucHanh.Models.Mapping
{
    public class MonHocMap : EntityTypeConfiguration<MonHoc>
    {
        public MonHocMap()
        {
            // Primary Key
            this.HasKey(t => t.TenMonHoc);

            // Properties
            this.Property(t => t.TenMonHoc)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ChuyenNganh)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MonHoc");
            this.Property(t => t.TenMonHoc).HasColumnName("TenMonHoc");
            this.Property(t => t.ChuyenNganh).HasColumnName("ChuyenNganh");
        }
    }
}
