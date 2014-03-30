using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TkbThucHanh.Models.Mapping
{
    public class LopMap : EntityTypeConfiguration<Lop>
    {
        public LopMap()
        {
            // Primary Key
            this.HasKey(t => t.TenLop);

            // Properties
            this.Property(t => t.TenLop)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TrinhDo)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("Lop");
            this.Property(t => t.TenLop).HasColumnName("TenLop");
            this.Property(t => t.TrinhDo).HasColumnName("TrinhDo");
        }
    }
}
