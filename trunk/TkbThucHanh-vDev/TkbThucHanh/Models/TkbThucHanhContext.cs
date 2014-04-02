using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace TkbThucHanh.Models
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
        public DbSet<LichCongTac> LichCongTacs { get; set; }
        public DbSet<Lop> Lops { get; set; }
        public DbSet<MonHoc> MonHocs { get; set; }
        public DbSet<PhanCongGiangDay> PhanCongGiangDays { get; set; }
        public DbSet<PhanCongThucHanh> PhanCongThucHanhs { get; set; }
        public DbSet<PhongThucHanh> PhongThucHanhs { get; set; }
        public DbSet<TkbGiangVien> TkbGangViens { get; set; }
        public DbSet<TkbThucHanh> TkbThucHanhs { get; set; }
        public DbSet<TuanHoc> TuanHocs { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}