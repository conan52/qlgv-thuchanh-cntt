namespace TKBThucHanh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GiangVien",
                c => new
                    {
                        GiangVienId = c.Int(nullable: false, identity: true),
                        MaGv = c.String(nullable: false, maxLength: 10),
                        HoVaTen = c.String(nullable: false),
                        MaTaiKhoanDangNhap = c.Int(),
                        ChuyenNganh = c.Int(nullable: false),
                        CoThePhanCong = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.GiangVienId)
                .ForeignKey("dbo.UserProfile", t => t.MaTaiKhoanDangNhap)
                .Index(t => t.MaTaiKhoanDangNhap);
            
            CreateTable(
                "dbo.LichCongTac",
                c => new
                    {
                        LichCongTacId = c.Int(nullable: false, identity: true),
                        GiangVienId = c.Int(nullable: false),
                        LyDo = c.String(),
                        ThoiGianBd = c.DateTime(),
                        ThoiGianKt = c.DateTime(),
                    })
                .PrimaryKey(t => t.LichCongTacId)
                .ForeignKey("dbo.GiangVien", t => t.GiangVienId, cascadeDelete: true)
                .Index(t => t.GiangVienId);
            
            CreateTable(
                "dbo.PhanCongGiangDay",
                c => new
                    {
                        IdPhanCong = c.Int(nullable: false, identity: true),
                        NamHoc = c.Int(nullable: false),
                        HocKy = c.Int(nullable: false),
                        LopId = c.Int(nullable: false),
                        IdGiangVienChinh = c.Int(),
                        IdGiangVienPhu = c.Int(),
                        IdMonHoc = c.Int(nullable: false),
                        GiangVien_GiangVienId = c.Int(),
                    })
                .PrimaryKey(t => t.IdPhanCong)
                .ForeignKey("dbo.GiangVien", t => t.IdGiangVienChinh)
                .ForeignKey("dbo.GiangVien", t => t.IdGiangVienPhu)
                .ForeignKey("dbo.Lop", t => t.LopId, cascadeDelete: true)
                .ForeignKey("dbo.MonHoc", t => t.IdMonHoc, cascadeDelete: true)
                .ForeignKey("dbo.GiangVien", t => t.GiangVien_GiangVienId)
                .Index(t => t.LopId)
                .Index(t => t.IdGiangVienChinh)
                .Index(t => t.IdGiangVienPhu)
                .Index(t => t.IdMonHoc)
                .Index(t => t.GiangVien_GiangVienId);
            
            CreateTable(
                "dbo.Lop",
                c => new
                    {
                        LopId = c.Int(nullable: false, identity: true),
                        TenLop = c.String(),
                        TrinhDo = c.String(),
                        NamNhapHoc = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LopId);
            
            CreateTable(
                "dbo.MonHoc",
                c => new
                    {
                        MonHocId = c.Int(nullable: false, identity: true),
                        MaMonHoc = c.String(nullable: false),
                        TenMonHoc = c.String(),
                        SoTinChiThucHanh = c.Int(nullable: false),
                        SoTinChiLyThuyet = c.Int(nullable: false),
                        ChuyenNganh = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MonHocId);
            
            CreateTable(
                "dbo.ThoiKhoaBieuGiangVien",
                c => new
                    {
                        MaTkb = c.Int(nullable: false, identity: true),
                        TenMonHoc = c.String(),
                        Lop = c.Int(nullable: false),
                        Phong = c.Int(nullable: false),
                        TietBatDau = c.Int(nullable: false),
                        TietKetThuc = c.Int(nullable: false),
                        GiangVienPhuTrach = c.Int(nullable: false),
                        NgayHoc = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MaTkb)
                .ForeignKey("dbo.GiangVien", t => t.GiangVienPhuTrach, cascadeDelete: true)
                .ForeignKey("dbo.PhongThucHanh", t => t.Phong, cascadeDelete: true)
                .Index(t => t.Phong)
                .Index(t => t.GiangVienPhuTrach);
            
            CreateTable(
                "dbo.PhanCongGvThucHanh",
                c => new
                    {
                        MaTkbThucHanh = c.Int(nullable: false, identity: true),
                        MaTkb = c.Int(nullable: false),
                        Gvhd = c.Int(nullable: false),
                        GhiChu = c.String(),
                        Loai = c.String(),
                        VangMat = c.Boolean(),
                    })
                .PrimaryKey(t => t.MaTkbThucHanh)
                .ForeignKey("dbo.ThoiKhoaBieuGiangVien", t => t.MaTkb, cascadeDelete: true)
                .Index(t => t.MaTkb);
            
            CreateTable(
                "dbo.PhongThucHanh",
                c => new
                    {
                        PhongThucHanhId = c.Int(nullable: false, identity: true),
                        TenPhong = c.String(),
                    })
                .PrimaryKey(t => t.PhongThucHanhId);
            
            CreateTable(
                "dbo.UserProfile",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Email = c.String(),
                        DisplayName = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.TuanHoc",
                c => new
                    {
                        TuanHocId = c.Int(nullable: false, identity: true),
                        SttTuan = c.Int(nullable: false),
                        NamHoc = c.String(),
                        NgayBatDau = c.DateTime(),
                        NgayKetThuc = c.DateTime(),
                        DaLayThongTin = c.Boolean(),
                        DaXepLichThucHanh = c.Boolean(),
                    })
                .PrimaryKey(t => t.TuanHocId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GiangVien", "MaTaiKhoanDangNhap", "dbo.UserProfile");
            DropForeignKey("dbo.ThoiKhoaBieuGiangVien", "Phong", "dbo.PhongThucHanh");
            DropForeignKey("dbo.PhanCongGvThucHanh", "MaTkb", "dbo.ThoiKhoaBieuGiangVien");
            DropForeignKey("dbo.ThoiKhoaBieuGiangVien", "GiangVienPhuTrach", "dbo.GiangVien");
            DropForeignKey("dbo.PhanCongGiangDay", "GiangVien_GiangVienId", "dbo.GiangVien");
            DropForeignKey("dbo.PhanCongGiangDay", "IdMonHoc", "dbo.MonHoc");
            DropForeignKey("dbo.PhanCongGiangDay", "LopId", "dbo.Lop");
            DropForeignKey("dbo.PhanCongGiangDay", "IdGiangVienPhu", "dbo.GiangVien");
            DropForeignKey("dbo.PhanCongGiangDay", "IdGiangVienChinh", "dbo.GiangVien");
            DropForeignKey("dbo.LichCongTac", "GiangVienId", "dbo.GiangVien");
            DropIndex("dbo.PhanCongGvThucHanh", new[] { "MaTkb" });
            DropIndex("dbo.ThoiKhoaBieuGiangVien", new[] { "GiangVienPhuTrach" });
            DropIndex("dbo.ThoiKhoaBieuGiangVien", new[] { "Phong" });
            DropIndex("dbo.PhanCongGiangDay", new[] { "GiangVien_GiangVienId" });
            DropIndex("dbo.PhanCongGiangDay", new[] { "IdMonHoc" });
            DropIndex("dbo.PhanCongGiangDay", new[] { "IdGiangVienPhu" });
            DropIndex("dbo.PhanCongGiangDay", new[] { "IdGiangVienChinh" });
            DropIndex("dbo.PhanCongGiangDay", new[] { "LopId" });
            DropIndex("dbo.LichCongTac", new[] { "GiangVienId" });
            DropIndex("dbo.GiangVien", new[] { "MaTaiKhoanDangNhap" });
            DropTable("dbo.TuanHoc");
            DropTable("dbo.UserProfile");
            DropTable("dbo.PhongThucHanh");
            DropTable("dbo.PhanCongGvThucHanh");
            DropTable("dbo.ThoiKhoaBieuGiangVien");
            DropTable("dbo.MonHoc");
            DropTable("dbo.Lop");
            DropTable("dbo.PhanCongGiangDay");
            DropTable("dbo.LichCongTac");
            DropTable("dbo.GiangVien");
        }
    }
}
