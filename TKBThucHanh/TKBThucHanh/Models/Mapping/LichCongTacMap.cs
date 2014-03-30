using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TkbThucHanh.Models.Mapping
{
    public class LichCongTacMap : EntityTypeConfiguration<LichCongTac>
    {
        public LichCongTacMap()
        {
            // Primary Key
            this.HasKey(t => t.MaLct);

            // Properties
            this.Property(t => t.MaGv)
                .HasMaxLength(10);

            this.Property(t => t.LyDo)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("LichCongTac");
            this.Property(t => t.MaLct).HasColumnName("MaLCT");
            this.Property(t => t.MaGv).HasColumnName("MaGV");
            this.Property(t => t.LyDo).HasColumnName("LyDo");
            this.Property(t => t.NgayBd).HasColumnName("NgayBD");
            this.Property(t => t.NgayKt).HasColumnName("NgayKT");

            // Relationships
            this.HasOptional(t => t.GiangVien)
                .WithMany(t => t.LichCongTacs)
                .HasForeignKey(d => d.MaGv);

        }
    }
}
