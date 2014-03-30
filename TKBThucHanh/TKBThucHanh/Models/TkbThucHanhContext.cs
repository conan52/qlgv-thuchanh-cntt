using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using TKBThucHanh.Migrations;
using TKBThucHanh.Models;

namespace TKBThucHanh.Models
{
    public class TkbThucHanhContext : DbContext
    {
        static TkbThucHanhContext()
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<TkbThucHanhContext, Configuration>());
            //Database.SetInitializer(new DropCreateDatabaseAlways<TkbThucHanhContext>());
        }

        public TkbThucHanhContext()
            : base("Name=TkbCloud")
        {
        }

        public DbSet<GiangVien> GiangViens { get; set; }
        public DbSet<LichCongTac> LichCongTacs { get; set; }
        public DbSet<MonHoc> MonHocs { get; set; }
        public DbSet<PhanCongGvThucHanh> PhanCongGvThucHanhs { get; set; }
        public DbSet<PhongThucHanh> PhongThucHanhs { get; set; }
        public DbSet<ThoiKhoaBieuGiangVien> ThoiKhoaBieuGiangViens { get; set; }
        public DbSet<TuanHoc> TuanHocs { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //        modelBuilder.Entity<GiangVien>()
            //.HasRequired(t => t.UserProfile)
            //.WithOptional(t => t.GiangVien);
        }
    }
}