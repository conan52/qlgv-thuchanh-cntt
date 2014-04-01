using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;


namespace TKBThucHanh.Models
{
    public class TkbThucHanhContext : DbContext
    {
        static TkbThucHanhContext()
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<TkbThucHanhContext, Configuration>());
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<TkbThucHanhContext>());
        }

        public TkbThucHanhContext()
            : base("Name=TkbCloud")
        {
        }

        public DbSet<GiangVien> GiangViens { get; set; }
        public DbSet<PhanCongGiangDay> PhanCongGiangDay { get; set; }
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
        }
    }
}