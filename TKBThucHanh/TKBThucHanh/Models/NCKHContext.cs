using System.Data.Entity;

using TkbThucHanh.Models;
using TkbThucHanh.Models.Mapping;

namespace TkbThucHanh.Models
{
    public partial class NckhContext : DbContext
    {
        static NckhContext()
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<NckhContext, Configuration>());
        }

        public NckhContext()
            : base("Name=DbTest")
        {
        }


        public DbSet<GiangVien> GiangViens { get; set; }
        public DbSet<LichCongTac> LichCongTacs { get; set; }
        public DbSet<Lop> Lops { get; set; }
        public DbSet<MonHoc> MonHocs { get; set; }
        public DbSet<PhanCongThucHanh> PhanCongThucHanhs { get; set; }
        public DbSet<Phong> Phongs { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<ThoiKhoaBieu> ThoiKhoaBieux { get; set; }
        public DbSet<TuanHoc> TuanHocs { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new GiangVienMap());
            modelBuilder.Configurations.Add(new LichCongTacMap());
            modelBuilder.Configurations.Add(new LopMap());
            modelBuilder.Configurations.Add(new MonHocMap());
            modelBuilder.Configurations.Add(new PhanCongThucHanhMap());
            modelBuilder.Configurations.Add(new PhongMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new ThoiKhoaBieuMap());
            modelBuilder.Configurations.Add(new TuanHocMap());
        }
    }
}
