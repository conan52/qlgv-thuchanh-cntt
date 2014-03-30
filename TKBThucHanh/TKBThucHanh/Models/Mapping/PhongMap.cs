using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TkbThucHanh.Models.Mapping
{
    public class PhongMap : EntityTypeConfiguration<Phong>
    {
        public PhongMap()
        {
            // Primary Key
            this.HasKey(t => t.TenPhong);

            // Properties
            this.Property(t => t.TenPhong)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Phong");
            this.Property(t => t.TenPhong).HasColumnName("TenPhong");
        }
    }
}
