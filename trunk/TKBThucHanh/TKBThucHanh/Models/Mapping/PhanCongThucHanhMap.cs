using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TkbThucHanh.Models.Mapping
{
    public class PhanCongThucHanhMap : EntityTypeConfiguration<PhanCongThucHanh>
    {
        public PhanCongThucHanhMap()
        {
            // Primary Key
            this.HasKey(t => t.MaTkbThucHanh);

            // Properties
            this.Property(t => t.Gvhd)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Gvbs)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("PhanCongThucHanh");
            this.Property(t => t.MaTkbThucHanh).HasColumnName("MaTkbThucHanh");
            this.Property(t => t.MaTkb).HasColumnName("MaTKB");
            this.Property(t => t.Gvhd).HasColumnName("GVHD");
            this.Property(t => t.Gvbs).HasColumnName("GVBS");

            // Relationships
            this.HasRequired(t => t.ThoiKhoaBieu)
                .WithMany(t => t.PhanCongThucHanhs)
                .HasForeignKey(d => d.MaTkb);

        }
    }
}
